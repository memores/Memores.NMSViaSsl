using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Transport;
using Apache.NMS.ActiveMQ.Transport.Tcp;

namespace Memores.NMSViaSsl {
    [ActiveMQTransportFactory("essl")]
    public class ExtendedSslTransportFactory : SslTransportFactory {

        public ExtendedSslTransportFactory() {
            ClientCertSubject = HttpUtility.UrlDecode(ConfigurationManager.AppSettings["ClientCertSubject"]);
            ClientCertFilename = ConfigurationManager.AppSettings["ClientCertFilename"];
            ClientCertPassword = ConfigurationManager.AppSettings["ClientCertPassword"];
            BrokerCertFilename = ConfigurationManager.AppSettings["BrokerCertFilename"];
            ServerName = ConfigurationManager.AppSettings["ServerName"];
            KeyStoreLocation = ConfigurationManager.AppSettings["KeyStoreLocation"];
            KeyStoreName = ConfigurationManager.AppSettings["KeyStoreName"];
            AcceptInvalidBrokerCert = ConfigurationManager.AppSettings["AcceptInvalidBrokerCert"] == "true";
            SslProtocol = ConfigurationManager.AppSettings["SslProtocol"];
        }
    }
}
