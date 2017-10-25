using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFLibrary
{
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        string ShowName(string name);
    }
}
