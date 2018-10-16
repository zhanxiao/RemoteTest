using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteSample
{
    public class RemoteObject : System.MarshalByRefObject 
    {
        public RemoteObject()
        {
            Console.WriteLine("New Referance Added!");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
