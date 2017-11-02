using System;
using SQLite.Net;

namespace test.Common.Interfaces
{
	public interface ISqLiteConnectionFactory
	{
		SQLiteConnectionWithLock GetLogsConnection();

		SQLiteConnectionWithLock GetAppDBConnection();
	}
}
