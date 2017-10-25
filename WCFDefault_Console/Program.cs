using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDefault_Console.WCF_Default;
using System.ServiceModel;

namespace WCFDefault_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClient client = new UserClient();
            Console.WriteLine(DateTime.Now);
            client.DoSomething();
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
