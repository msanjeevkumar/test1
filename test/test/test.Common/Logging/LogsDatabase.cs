using System;
using test.Common.Interfaces;
using test.Common.DB;

namespace test.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
