using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace LoggingLibrary
{
    public class NetworkContentWriter : BaseContentWriter
    {
        private static string domain = "127.0.0.1";
        private static int port = 4500;
        public NetworkContentWriter() { }
        public override bool WriteToMedia(string content)
        {
            TcpClient _client = new TcpClient();
            if (_client == null) { return false; }

            try
            {
                _client.Connect(domain, port);
            }
            catch (Exception) { return false; }

            StreamWriter _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sWriter.WriteLine(content);
            _sWriter.Flush();
            _sWriter.Close();
            _client.Close();
            return true;
        }
    }
}
