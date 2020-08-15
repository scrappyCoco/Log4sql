using System.Collections.Generic;
using System.Data.SqlClient;

namespace Log4sql.Appenders.Impl
{
	public class MsSqlConsoleAppender : IAppender
	{
		/// <inheritdoc />
		public void Write(string @namespace, LogLevel level, string template, Dictionary<string, string> parameters)
		{
			using (SqlConnection connection = new SqlConnection("context connection=true"))
			using (SqlCommand command = new SqlCommand("RAISERROR ('Foo', 10, 1) WITH NOWAIT", connection))
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
		}
	}
}