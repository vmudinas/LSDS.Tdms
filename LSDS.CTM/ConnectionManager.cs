using System.Collections;
using System.Collections.Generic;
using Amib.Threading;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class ConnectionManager
    {
        private readonly string _protocoldName;
        private readonly string _host;
        private readonly string _port;
        private readonly string _loginPath;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _sslProxyHost;
        private readonly string _sslProxyPort;
        private readonly string _sslProxyUserName;
        private readonly string _sslProxyPassword;
        private readonly int _circuitTimeout;
        private readonly int _idleTimeout;
        private readonly bool _trace;
        private DCIWebSession _webSession;
        private readonly static CtmProcessor _instance;
        public static SmartThreadPool SmartThreadPool;
        protected IDictionary<string, ArrayList> CtmWebSessionMap = new Dictionary<string, ArrayList>();
        protected int NoOfWebSession;
       
        public ConnectionManager(string protocoldName, string host, string port, string loginPath,
            string userName, string password, string sslProxyHost, string sslProxyPort, string sslProxyUserName,
            string sslProxyPassword, int circuitTimeout, int idleTimeout, bool trace)
        {
            _protocoldName = protocoldName;
            _host = host;
            _port = port;
            _loginPath = loginPath;
            _userName = userName;
            _password = password;
            _sslProxyHost = sslProxyHost;
            _sslProxyPort = sslProxyPort;
            _sslProxyUserName = sslProxyUserName;
            _sslProxyPassword = sslProxyPassword;
            _circuitTimeout = circuitTimeout;
            _idleTimeout = idleTimeout;
            _trace = trace;
            NoOfWebSession = 5;
          
        }
        public DCIWebSession GetSession()
        {
            _webSession = new DCIWebSession(
                      _protocoldName, // protocol
                      _host, // host
                      _port, // port
                      _loginPath, // login url
                      _userName,// User name
                      _password, // password
                      _sslProxyHost, // sslProxyHost 
                      _sslProxyPort, //sslProxyport
                      _sslProxyUserName, //sslProxusername
                      _sslProxyPassword, //sslProxypassword
                                         //(proxyHost != null && !"".equals(proxyHost)) ? proxyHost : null, // sslProxyHost
                                         //(proxyPort != null && !"".equals(proxyPort)) ? int.Parse(proxyPort):int.MinValue;
                                         // sslProxyPort
                       _circuitTimeout, // As per example
                       _idleTimeout, //As per example
                       _trace /* As per example */ );
            return _webSession;
        }

     
        public CTM_Message SendMsg(ICtmProcess sendMsg)
        {
            return sendMsg.SendMsg(GetSession());
        }

    }
}
