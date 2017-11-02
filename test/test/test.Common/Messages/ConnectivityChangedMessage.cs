using System;
using test.Common.Interfaces;

namespace test.Common.Messages
{
	public class ConnectivityChangedMessage : IMessage
	{
		public ConnectivityChangedMessage(bool isConnected)
		{
			IsConnected = isConnected;
		}

		public bool IsConnected { get; private set; }
	}
}
