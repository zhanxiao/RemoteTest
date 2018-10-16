using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteSample;

namespace RemoteSampleServer
{
    public class RemoteServer 
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(6666);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject), "RemoteObject", WellKnownObjectMode.SingleCall);
            Console.WriteLine("Press Any Key");
            Console.ReadLine();
        }
    }
}
