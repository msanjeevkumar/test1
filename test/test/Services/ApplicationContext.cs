using test.Common.Interfaces;
using test.Common.Logging;

namespace test.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
