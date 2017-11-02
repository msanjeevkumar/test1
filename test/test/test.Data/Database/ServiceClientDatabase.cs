using System;
using test.Common.DB;
using test.Data.Interfaces;

namespace test.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
