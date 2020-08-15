using System;
using System.Data.SqlTypes;

namespace Log4sql
{
	public static class ExceptionUtil
	{
		public static void CheckStringArg(SqlString value, string argName)
		{
			if (value.IsNull || string.IsNullOrWhiteSpace(value.Value))
				throw new InvalidOperationException(argName + " must be not null.");
		}
	}
}