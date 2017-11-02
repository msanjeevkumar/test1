using System;
using AutoMapper;
using Microsoft.Practices.Unity;
using test.Data;

namespace test.Forms
{
	public class FormsAutoMapperConfig
	{
		public static void RegisterMapper(IUnityContainer container)
		{
			var config = new MapperConfiguration(configuration =>
			{
				configuration.AddProfile<DataAutoMapperProfile>();
				configuration.AddProfile<FormsAutoMapperProfile>();
			});

			container.RegisterInstance(config.CreateMapper());
		}
	}
}
