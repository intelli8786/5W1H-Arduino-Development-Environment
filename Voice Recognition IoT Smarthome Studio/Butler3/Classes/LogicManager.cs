using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butler3
{
    public class LogicManager
    {
        [Serializable]
        public class Module
        {
            public String name { get; set; }
            public String port { get; set; }
            [NonSerialized]
            private SerialPort device;


            public void Open()
            {
                new Thread(new ThreadStart(() =>
                {
                    if (System.IO.Ports.SerialPort.GetPortNames().Contains(port))
                    {
                        //장치정보 초기화
                        device = new SerialPort();
                        device.PortName = port;
                        device.BaudRate = (int)9600;
                        device.ReadTimeout = 100;


                        while (device != null && Form_Main.ProcessRun)
                        {
                            try
                            {
                                if (device.IsOpen)
                                {
                                    device.Close();
                                }

                                device.Open();
                                break;
                                /*
                                if (device.IsOpen)
                                {
                                    break;
                                }
                                else
                                {
                                    Thread.Sleep(100);
                                    continue;
                                }
                                 */
                            }
                            catch
                            {
                                Thread.Sleep(100);
                            }
                        }


                        //UDP Socket 생성
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        //종점 생성
                        IPAddress ip = IPAddress.Parse("127.0.0.1");
                        IPEndPoint endPoint = new IPEndPoint(ip, 8791);
                        //바인드
                        socket.Connect(endPoint);

                        while (Form_Main.ProcessRun && device != null &&  device.IsOpen)
                        {
                            Thread.Sleep(100);
                            String Packet = ReceiveData();
                            if (Packet != null) //정상 리시브
                            {
                                socket.SendTo(Encoding.UTF8.GetBytes("DEVICE:COMMAND:" + port + "," + Packet), endPoint);
                            }
                        }

                        Close();
                    }
                    else
                    {
                        MessageBox.Show(port+"는 존재하지 않는 포트입니다!");
                    }

                })).Start();
            }

            public void Close()
            {
                if (device != null && device.IsOpen)
                {
                    device.Close();
                    device.Dispose();
                    device = null;
                }
                    
            }

            public String ReceiveData()
            {
                if (device != null && device.IsOpen)
                {
                    try
                    {
                        return device.ReadLine();
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            public void SendData(String m_strMessage)
            {
                if (device != null && device.IsOpen)
                {
                    try
                    {
                        device.WriteLine(m_strMessage);
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        //아래 조건은 프로젝트 전체 동일하다.
        [Serializable]
        public class Condition //조건 객체
        {
            public String who;     //누가
            public String when;    //언제
            public String compare; // == or > or >= or < or <=
            public String logic;   // || or &&
        }

        [Serializable]
        public class Operation      //실행 객체
        {
            public String what;
            public String how;
            public String setting;  // = or += or -= ...
        }

        [Serializable]
        public class Trigger
        {
            public String name { get; set; }
            //public List<Condition> conditionList = new List<Condition>();
            //public List<Operation> operationList = new List<Operation>();
            public Condition m_condition = new Condition();
            public Operation m_operation = new Operation();
        }

        [Serializable]
        public class Task
        {
            public List<Module> moduleList = new List<Module>();
            public List<Trigger> triggerList = new List<Trigger>();

            //프로젝트마다 다름
            public String recognitionName;  //호출명
            public int recognitionLevel;    //호출수준
            public String voiceModuleIP;    //음성이식모듈 IP

            public Task()
            {
                //비 설정시 초기값
                recognitionName = "버틀러";
                recognitionLevel = 60;
                voiceModuleIP = "192.168.0.2";
            }


            public void Load(ref Task currentTask)
            {
                try
                {
                    Stream stm = File.Open("saveData.butler", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();


                    //객체 로드
                    currentTask = (Task)bf.Deserialize(stm);

                    //빈값 초기화
                    if (currentTask.recognitionName == null || currentTask.recognitionName == "")
                        currentTask.recognitionName = "버틀러";

                    if (1 > currentTask.recognitionLevel || currentTask.recognitionLevel > 100)
                        currentTask.recognitionLevel = 60;

                    if (currentTask.voiceModuleIP == null || currentTask.voiceModuleIP == "")
                        currentTask.voiceModuleIP = "192.168.0.2";


                    //블루투스 연결
                    foreach (Module module in currentTask.moduleList)
                    {
                        try
                        {
                            module.Open();
                        }
                        catch
                        {
                            MessageBox.Show(module.name + " 장치에 연결할 수 없습니다!");
                        }
                    }

                    //로드 완료
                    stm.Close();
                }
                catch
                {
                    MessageBox.Show("객체를 로드할 수 없습니다!");
                    currentTask = new Task();
                }
            }

            public void Save()
            {
                Stream stm = File.Open("saveData.butler", FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stm, this);

                //저장완료
                stm.Close();
                stm = null;
                bf = null;
            }
        }
    }
}
