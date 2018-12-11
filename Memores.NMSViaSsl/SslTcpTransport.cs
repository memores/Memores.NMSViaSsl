using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.ActiveMQ.Transport;
using Apache.NMS.ActiveMQ.Transport.Tcp;

namespace Memores.NMSViaSsl {
    public class SslTcpTransport : TcpTransport {
        public SslTcpTransport(Uri uri, Socket socket, IWireFormat wireformat) : base(uri, socket, wireformat) { }

        protected override Stream CreateSocketStream() {
            return new SslStream(new NetworkStream(socket));
        }
    }
}
