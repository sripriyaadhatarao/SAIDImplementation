using System;
using System.Net;
using Common;

namespace Publisher
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			args = new string[] {
//				"192.168.50.51",
//				"9698",
//				"192.168.50.51",
//				"9696",
//				"2",
//				"2",
//				"Publisher",
//				"/test",
//				"10000"
//			};

			IPEndPoint localEP = new IPEndPoint (IPAddress.Parse (args [0]), Convert.ToInt32 (args [1]));
			IPEndPoint router = new IPEndPoint (IPAddress.Parse (args [2]), Convert.ToInt32 (args [3]));
			int bandwidthInBitsPerSecond = Convert.ToInt32 (args [4]) * Link.KB;
			int linkBandwidthInBitsPerSecond = 1000000000;
			long delayInMS = Convert.ToInt64(args[5]);

			new Publisher (args[6], localEP, args[7], Convert.ToInt32(args[8]), router, new FIFOQueue<Packet> (Int32.MaxValue), bandwidthInBitsPerSecond, linkBandwidthInBitsPerSecond, delayInMS);
		}
	}
}
