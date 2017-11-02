using System;
using Microsoft.Practices.Unity;
using test.Common.Interfaces;
using test.Forms.Droid.PlatformServices;
using test.Forms.Droid.Utils;
using test.Droid.Providers;
using test.Droid.Helpers;

namespace test.Forms.Droid
{
	public class AndroidBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<IAppConfig, AndroidAppConfig>(new TransientLifetimeManager());
			container.RegisterType<INetworkStatusService, AndroidNetworkStatusServices>(new HierarchicalLifetimeManager());
			container.RegisterType<IThreadExecutionProvider, ThreadExecutionProvider>(new TransientLifetimeManager());
			container.RegisterType<IStackFrameHelper, StackFrameHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<IPlatformService, PlatformServiceAndroid>(new ContainerControlledLifetimeManager());
			container.RegisterType<IDialogService, AndroidDialogService>(new TransientLifetimeManager());
			container.RegisterType<IAppAnalyticsProvider, RaygunAppAnalyticsProvider>(new TransientLifetimeManager());
			container.RegisterType<IFileSystemHelper, FileSystemHelper>(new TransientLifetimeManager());
			container.RegisterType<IEncryptionProvider, EncryptionProvider>(new TransientLifetimeManager());
		}
	}
}
