using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Transport;
using Apache.NMS.ActiveMQ.Transport.Tcp;

namespace Memores.NMSViaSsl {
    [ActiveMQTransportFactory("ssl")]
    public class SslTcpTransportFactory : TcpTransportFactory {
        protected override ITransport DoCreateTransport(Uri location, Socket socket, IWireFormat wireFormat) {
            return new SslTcpTransport(location, socket, wireFormat) {
                SendBufferSize = SendBufferSize,
                ReceiveBufferSize = ReceiveBufferSize
            };
        }
    }
}
