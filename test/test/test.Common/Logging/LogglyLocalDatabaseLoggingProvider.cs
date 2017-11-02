using System;
using System.Threading.Tasks;
using test.Common.Entities;
using test.Common.Enums;
using test.Common.Interfaces;

namespace test.Common.Logging
{
	public class LogglyLocalDatabaseLoggingProvider : BaseLogginProvider, ILoggingProvider
	{
		private readonly ILogsDatabase _database;

		public LogglyLocalDatabaseLoggingProvider(ILogsDatabase logsDatabase, IApplicationContext applicationContext, IPlatformService platformServices) : base(applicationContext, platformServices)
		{
			_database = logsDatabase;
		}

		public async Task ClearLogsAsync()
		{
			await _database.DeleteAllAsync<LogEntry>();
		}

		public void Log(string message, LogLevel level, object data, string[] tags, string callerFullTypeName, string callerMemberName, long? timeInMilliseconds = default(long?))
		{			
			LogEntry report = CreateLogEntry(message, level, data, tags, callerFullTypeName, callerMemberName,
				timeInMilliseconds);

			_database.Insert(report);
		}
	}
}
