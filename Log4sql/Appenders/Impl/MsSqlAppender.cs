using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace Log4sql.Appenders.Impl
{
	public class MsSqlAppender : IAppender
	{
		private readonly string _connectionString;
		private readonly string _insertSql;

		public MsSqlAppender(string connectionString, string logTable)
		{
			_connectionString = connectionString;
			_insertSql = $"INSERT INTO {logTable} (Time, Namespace, Template, ParameterXml) " +
			             "VALUES (GetDate(), @Namespace, @Template, @ParameterXml);";
		}

		/// <inheritdoc />
		public void Write(string @namespace, LogLevel level, string template, Dictionary<string, string> parameters)
		{
/*
 * CREATE TABLE dbo.MyLog (
 *   LogId        BIGINT IDENTITY NOT NULL PRIMARY KEY,
 *   Namespace    VARCHAR(200)    NOT NULL,
 *   Level        CHAR(5)         NOT NULL,
 *   Time         DateTime2(3)    NOT NULL,
 *   Template     NVARCHAR(MAX)   NOT NULL,
 *   ParameterXml XML
 * );
 */

			string parametersXml = SerializeParameters(parameters);
			
			using (SqlConnection connection = new SqlConnection(_connectionString))
			using (SqlCommand command = new SqlCommand(_insertSql, connection))
			{
				connection.Open();
				command.Parameters.AddWithValue("@Namespace", @namespace);
				command.Parameters.AddWithValue("@Level", level.ToString());
				command.Parameters.AddWithValue("@Template", template);
				command.Parameters.AddWithValue("@ParameterXml", parametersXml);
				command.ExecuteNonQuery();
			}
		}

		private static string SerializeParameters(Dictionary<string, string> parameters)
		{
			XmlWriter xmlWriter = new XmlTextWriter(new StringWriter());

			xmlWriter.WriteStartElement("Parameters");
			foreach (var parameter in parameters)
			{
				xmlWriter.WriteStartElement(parameter.Key);
				xmlWriter.WriteValue(parameter.Value);
				xmlWriter.WriteEndElement();
			}

			xmlWriter.WriteEndElement();

			return xmlWriter.ToString();
		}
	}
}