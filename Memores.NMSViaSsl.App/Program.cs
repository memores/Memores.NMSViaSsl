using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Transport;
using Apache.NMS.ActiveMQ.Util;

namespace Memores.NMSViaSsl.App
{
    class Program
    {
        static void Main(string[] args) {
            AppDomain.CurrentDomain.Load("Memores.NMSViaSsl");
            var cf = new ConnectionFactory("essl://localhost:61617");
            cf.CreateConnection("smx", "smx");
        }
    }
}
