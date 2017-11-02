using Microsoft.Practices.Unity;
using test.Common.DB;
using test.Common.Interfaces;
using test.Common.Logging;
using test.Common.Providers;
using test.Data.Database;
using test.Data.Interfaces;
using test.Data.Repositories;
using test.Data.Repositories.Interfaces;

namespace test.Data
{
	public class DataBootstrapper
	{		
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<ISqLiteConnectionFactory, SqLiteConnectionFactory>(new ContainerControlledLifetimeManager());
			container.RegisterType<ILogsInternalDatabase, LogsInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IAppInternalDatabase, ServiceClientInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IServiceClientInternalDatabase, ServiceClientInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IServiceClientDatabase, ServiceClientDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<ILoggingProvider, LogglyLocalDatabaseLoggingProvider>("LogglyLogger",new ContainerControlledLifetimeManager());
			container.RegisterType<ILogger, Logger>();
			container.RegisterType<IConnectivityHelper, ConnectivityHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<ILogsDatabase, LogsDatabase>(new HierarchicalLifetimeManager());

			// Repository Registration goes here.
			container.RegisterType<ITestRepository, TestRepository>(new TransientLifetimeManager());
		}
	}
}
