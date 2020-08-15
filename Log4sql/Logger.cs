using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using JetBrains.Annotations;
using Log4sql.Appenders;
using Log4sql.Appenders.Impl;
using Microsoft.SqlServer.Server;

namespace Log4sql
{
	[Serializable]
	[SqlUserDefinedType(Format.Native, IsByteOrdered = true)]
	public partial class Logger : INullable
	{
		private List<IAppender> _appenders = new List<IAppender>();

		public string LoggerNamespace { get; private set; }
		public LogLevel MinLogLevel { get; private set; }

		/// <inheritdoc />
		public bool IsNull { get; private set; }

		[UsedImplicitly]
		public static Logger Null => new Logger
		{
			IsNull = true
		};

		public void AppendMsSqlTarget(SqlString connectionString, SqlString targetTable)
		{
			ExceptionUtil.CheckStringArg(connectionString, nameof(connectionString));
			ExceptionUtil.CheckStringArg(targetTable, nameof(targetTable));
			_appenders.Add(new MsSqlAppender(connectionString.Value, targetTable.Value));
		}

		public void AppendConsoleTarget() => _appenders.Add(new MsSqlConsoleAppender());

		/// <inheritdoc />
		public override string ToString() => string.Join(", ", _appenders.Select(a => a.GetType().Name));

		[SqlMethod(OnNullCall = true)]
		[UsedImplicitly]
		public static Logger Parse(SqlString s)
		{
			return new Logger();
		}
	}
}