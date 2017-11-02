using System;
using SQLite.Net.Interop;

namespace test.Common.Interfaces
{
	public interface IAppConfig
	{
		string ApiBaseUrl { get; }

		string ApplicationDatabaseFileName { get; }

		string LogsDatabaseFilename { get; }

		string AppDatabaseConnectionString { get; }

		string LogDatabaseConnectionString { get; }

		string StoreAppRaygunKey { get; }

		string BetaAppRaygunKey { get; }

		string TestAppRaygunKey { get; }

		ISQLitePlatform SqLitePlatform { get; }
	}
}
