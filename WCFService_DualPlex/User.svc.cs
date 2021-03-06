﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService_DualPlex
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“User”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 User.svc 或 User.svc.cs，然后开始调试。
    public class User : IUser
    {
        IUserCallback callback = null;

        public User()
        {
            callback = OperationContext.Current.GetCallbackChannel<IUserCallback>();
        }

        public string ShowName(string name)
        {
            //在服务器端定义字符串，调用客户端的方法向客户端打印
            string str = "服务器调用客户端...";
            callback.PrintSomething(str);
            //返回服务端方法
            return "WCF服务，显示名称：" + name;
        }
    }
}
