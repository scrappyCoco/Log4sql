using System.Collections.Generic;

namespace Log4sql.Appenders
{
	public interface IAppender
	{
		void Write(string @namespace, LogLevel level, string template, Dictionary<string, string> parameters);
	}
}