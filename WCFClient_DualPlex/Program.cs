using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFClient_DualPlex.WCFService_DualPlex;

namespace WCFClient_DualPlex
{
    public class CallbackHandler : IUserCallback
    {
        public void PrintSomething(string str)
        {
            Console.WriteLine(str);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            UserClient client = new UserClient(instanceContext);
            Console.WriteLine(DateTime.Now);
            string result = client.ShowName("陈海涛");
            Console.WriteLine(result);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
