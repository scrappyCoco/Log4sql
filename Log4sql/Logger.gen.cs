using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Log4sql
{
    public partial class Logger
    {

	    void Debug1(SqlString template
        , SqlString key1, SqlString value1
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug2(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug3(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug4(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug5(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug6(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug7(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug8(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug9(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug10(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug11(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug12(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug13(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug14(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug15(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug16(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug17(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug18(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug19(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Debug20(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
        , SqlString key20, SqlString value20
    )
        {
            if (MinLogLevel > LogLevel.Debug) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));ExceptionUtil.CheckStringArg(key20, nameof(key20));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value},        {key20.Value, value20.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Debug, template.Value, parameters);
            }
        } 
	    void Info1(SqlString template
        , SqlString key1, SqlString value1
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info2(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info3(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info4(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info5(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info6(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info7(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info8(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info9(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info10(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info11(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info12(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info13(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info14(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info15(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info16(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info17(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info18(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info19(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Info20(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
        , SqlString key20, SqlString value20
    )
        {
            if (MinLogLevel > LogLevel.Info) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));ExceptionUtil.CheckStringArg(key20, nameof(key20));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value},        {key20.Value, value20.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Info, template.Value, parameters);
            }
        } 
	    void Warn1(SqlString template
        , SqlString key1, SqlString value1
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn2(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn3(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn4(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn5(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn6(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn7(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn8(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn9(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn10(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn11(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn12(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn13(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn14(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn15(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn16(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn17(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn18(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn19(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Warn20(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
        , SqlString key20, SqlString value20
    )
        {
            if (MinLogLevel > LogLevel.Warn) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));ExceptionUtil.CheckStringArg(key20, nameof(key20));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value},        {key20.Value, value20.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Warn, template.Value, parameters);
            }
        } 
	    void Error1(SqlString template
        , SqlString key1, SqlString value1
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error2(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error3(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error4(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error5(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error6(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error7(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error8(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error9(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error10(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error11(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error12(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error13(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error14(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error15(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error16(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error17(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error18(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error19(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Error20(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
        , SqlString key20, SqlString value20
    )
        {
            if (MinLogLevel > LogLevel.Error) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));ExceptionUtil.CheckStringArg(key20, nameof(key20));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value},        {key20.Value, value20.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Error, template.Value, parameters);
            }
        } 
	    void Fatal1(SqlString template
        , SqlString key1, SqlString value1
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal2(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal3(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal4(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal5(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal6(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal7(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal8(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal9(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal10(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal11(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal12(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal13(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal14(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal15(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal16(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal17(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal18(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal19(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        } 
	    void Fatal20(SqlString template
        , SqlString key1, SqlString value1
        , SqlString key2, SqlString value2
        , SqlString key3, SqlString value3
        , SqlString key4, SqlString value4
        , SqlString key5, SqlString value5
        , SqlString key6, SqlString value6
        , SqlString key7, SqlString value7
        , SqlString key8, SqlString value8
        , SqlString key9, SqlString value9
        , SqlString key10, SqlString value10
        , SqlString key11, SqlString value11
        , SqlString key12, SqlString value12
        , SqlString key13, SqlString value13
        , SqlString key14, SqlString value14
        , SqlString key15, SqlString value15
        , SqlString key16, SqlString value16
        , SqlString key17, SqlString value17
        , SqlString key18, SqlString value18
        , SqlString key19, SqlString value19
        , SqlString key20, SqlString value20
    )
        {
            if (MinLogLevel > LogLevel.Fatal) return;
ExceptionUtil.CheckStringArg(key1, nameof(key1));ExceptionUtil.CheckStringArg(key2, nameof(key2));ExceptionUtil.CheckStringArg(key3, nameof(key3));ExceptionUtil.CheckStringArg(key4, nameof(key4));ExceptionUtil.CheckStringArg(key5, nameof(key5));ExceptionUtil.CheckStringArg(key6, nameof(key6));ExceptionUtil.CheckStringArg(key7, nameof(key7));ExceptionUtil.CheckStringArg(key8, nameof(key8));ExceptionUtil.CheckStringArg(key9, nameof(key9));ExceptionUtil.CheckStringArg(key10, nameof(key10));ExceptionUtil.CheckStringArg(key11, nameof(key11));ExceptionUtil.CheckStringArg(key12, nameof(key12));ExceptionUtil.CheckStringArg(key13, nameof(key13));ExceptionUtil.CheckStringArg(key14, nameof(key14));ExceptionUtil.CheckStringArg(key15, nameof(key15));ExceptionUtil.CheckStringArg(key16, nameof(key16));ExceptionUtil.CheckStringArg(key17, nameof(key17));ExceptionUtil.CheckStringArg(key18, nameof(key18));ExceptionUtil.CheckStringArg(key19, nameof(key19));ExceptionUtil.CheckStringArg(key20, nameof(key20));
            var parameters = new Dictionary<string, string>
		    {
        {key1.Value, value1.Value},        {key2.Value, value2.Value},        {key3.Value, value3.Value},        {key4.Value, value4.Value},        {key5.Value, value5.Value},        {key6.Value, value6.Value},        {key7.Value, value7.Value},        {key8.Value, value8.Value},        {key9.Value, value9.Value},        {key10.Value, value10.Value},        {key11.Value, value11.Value},        {key12.Value, value12.Value},        {key13.Value, value13.Value},        {key14.Value, value14.Value},        {key15.Value, value15.Value},        {key16.Value, value16.Value},        {key17.Value, value17.Value},        {key18.Value, value18.Value},        {key19.Value, value19.Value},        {key20.Value, value20.Value}            };

		    foreach (var appender in _appenders)
		    {
		    	appender.Write(LoggerNamespace, LogLevel.Fatal, template.Value, parameters);
            }
        }     }}