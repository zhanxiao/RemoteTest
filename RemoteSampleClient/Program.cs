using RemoteSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemoteSampleClient
{
    public class RemoteClient
    {
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpClientChannel(), false);
            RemoteObject remoteobj = (RemoteObject)Activator.GetObject(typeof(RemoteObject), "tcp://localhost:6666/RemoteObject");
            Console.WriteLine($"1 + 2 = {remoteobj.Sum(1, 2)}");
            Console.ReadLine();
        }
    }
}
