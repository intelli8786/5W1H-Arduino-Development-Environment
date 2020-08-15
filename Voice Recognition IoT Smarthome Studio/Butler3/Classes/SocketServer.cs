using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butler3
{
    public class SocketServer
    {
        byte[] m_bBuffer = new byte[2048];
        List<CallBackContainer> m_CBCList;
        Socket m_sockServer;
        bool m_bIsRunning;

        EndPoint m_epServer; //서버
        EndPoint m_epClient; //클라이언트

        public SocketServer(int port)
        {
            m_sockServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            m_epServer = new IPEndPoint(IPAddress.Any, port);
            m_epClient = new IPEndPoint(IPAddress.None, port);

            m_sockServer.Bind(m_epServer);
            m_CBCList = new List<CallBackContainer>();
        }

        public void Start()
        {
            m_bIsRunning = true;

            new Thread(new ThreadStart(() =>
            {
                while (m_bIsRunning)
                {
                    int receivedSize = m_sockServer.ReceiveFrom(m_bBuffer, ref m_epClient);
                    String Packet = Encoding.UTF8.GetString(m_bBuffer, 0, receivedSize);

                    //AES256 암복호화
                    AES256Cipher aes = new AES256Cipher();
                    Packet = aes.AES_decrypt(Packet, "1234567890123456");
                    /*
                    if(!(Packet.Contains("SPEECH") || Packet.Contains("MOUSE") || Packet.Contains("KEYBOARD")))
                    {
                        AES256Cipher aes = new AES256Cipher();
                        Packet = aes.AES_decrypt(Packet, "1234567890123456");
                    }*/
                    //MessageBox.Show(Packet);

                    String m_strType = Packet.Split(':')[0];
                    String m_strOperation = Packet.Split(':')[1];
                    String m_strValue = Packet.Split(':')[2];


                    foreach (CallBackContainer m_CBCTemp in m_CBCList)
                    {
                        if (m_CBCTemp.type.Equals(m_strType) && m_CBCTemp.operation.Equals(m_strOperation))
                            m_CBCTemp.action(m_strValue);
                    }
                }
            })).Start();
        }

        public void Stop()
        {
            m_bIsRunning = false;
            m_sockServer.Close();
        }

        public void AddCommand(String type, String operation, Action<String> m_fAction)
        {
            //람다식 콜백 등록
            m_CBCList.Add(new CallBackContainer(type, operation, m_fAction));
        }

        class CallBackContainer
        {
            public String type;
            public String operation;
            public Action<String> action;

            public CallBackContainer(String type, String operation, Action<String> action)
            {
                this.type = type;
                this.operation = operation;
                this.action = action;
            }
        }
    }
}
