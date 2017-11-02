using System;
using test.Common.Enums;

namespace test.Common.Interfaces
{	
	public interface INetworkStatusService
	{		
		event EventHandler NetworkStatusChanged;

		NetworkStatus NetworkStatus();
	}
}
