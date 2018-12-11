using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Apache.NMS.ActiveMQ.Transport;
using Apache.NMS.ActiveMQ.Transport.Tcp;

namespace Memores.NMSViaSsl {
    public class ExtendedSslTransport : SslTransport {
        public ExtendedSslTransport(Uri location, Socket socket, IWireFormat wireFormat) : base(location, socket, wireFormat) { }
    }
}