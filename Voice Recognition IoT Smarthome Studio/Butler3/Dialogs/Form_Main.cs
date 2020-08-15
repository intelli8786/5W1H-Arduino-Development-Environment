using Microsoft.Speech.Recognition;
using Microsoft.Speech.Synthesis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butler3
{
    public partial class Form_Main : Form
    {
        public static bool ProcessRun = true;
        LogicManager.Task currentTask = new LogicManager.Task();
        SocketServer m_UDPServer;
        

        public Form_Main()
        {
            InitializeComponent();

            currentTask.Load(ref currentTask);

            //음성인식
            SpeechRecognitionEngine SRE;
            SpeechSynthesizer m_ssTextToSpeech;
            //음성인식 객체 초기화
            SRE = new SpeechRecognitionEngine(new CultureInfo("ko-KR"));
            SRE.SetInputToDefaultAudioDevice();
            SRE.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(SpeechHandler);
            //명령 로드
            GrammarBuilder commandList = new GrammarBuilder();
            Choices selectCommand = new Choices();
            selectCommand.Add(currentTask.recognitionName);
            commandList.Culture = new CultureInfo("ko-KR");
            commandList.Append(selectCommand);
            SRE.LoadGrammar(new Grammar(commandList));
            SRE.RecognizeAsync(RecognizeMode.Multiple);
            //TTS
            m_ssTextToSpeech = new SpeechSynthesizer();
            m_ssTextToSpeech.SelectVoice("Microsoft Server Speech Text to Speech Voice (ko-KR, Heami)");
            m_ssTextToSpeech.SetOutputToDefaultAudioDevice();

            //소켓
            m_UDPServer = new SocketServer(8791);
            m_UDPServer.Start();

            m_UDPServer.AddCommand("SPEECH", "COMMAND", (m_strValue) =>
            {
                foreach (LogicManager.Trigger t in currentTask.triggerList)
                {
                    if (t.m_condition.who.Equals("음성인식"))
                    {
                        if (m_strValue.Contains(t.m_condition.when))
                        {
                            if (t.m_operation.what.Equals("실행"))
                            {
                                if (t.m_operation.how.Contains("www"))
                                {
                                    System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe", t.m_operation.how);
                                }
                                else
                                {
                                    System.Diagnostics.Process.Start(t.m_operation.how);
                                }
                            }
                            else
                            {
                                LogicManager.Module module = currentTask.moduleList.Find(obj => obj.name == t.m_operation.what);
                                module.SendData(t.m_operation.how);
                                //MessageBox.Show("name:"+module.name + "\nhow:" + t.m_operation.how);
                            }
                        }
                    }
                }

                if (m_strValue.Contains("유튜브"))
                {
                    if (m_strValue.Contains("재생"))
                    {
                        //이미 열린 유튜브 확인
                        String m_strSearch = StringParsing(m_strValue, "유튜브", "재생", 0);
                        String m_strURL = "https://www.youtube.com/results?search_query=" + System.Web.HttpUtility.UrlEncode(m_strSearch);
                        String m_strHTML = GetHTMLFromURL(m_strURL);
                        String m_strTarget = StringParsing(m_strHTML, "/watch?v=", "\"", 58000);

                        Process m_pYouTube = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/watch?v=" + m_strTarget);

                        //브라우저가 열리기까지 최대 10초 대기
                        for (int i = 0; i < 100; i++)
                        {
                            if (m_pYouTube.MainWindowTitle.Length == 0)
                                Thread.Sleep(100);
                            else
                                break;
                        }

                        //브라우저 최대화
                        Win32API.ShowWindow(m_pYouTube.MainWindowHandle, Win32Const.SW_MAXIMIZE);
                    }
                    else
                    {
                        if (m_strValue.Contains("틀어"))
                        {
                            //이미 열린 유튜브 확인
                            String m_strSearch = StringParsing(m_strValue, "유튜브", "틀어", 0);
                            String m_strURL = "https://www.youtube.com/results?search_query=" + System.Web.HttpUtility.UrlEncode(m_strSearch);
                            String m_strHTML = GetHTMLFromURL(m_strURL);
                            String m_strTarget = StringParsing(m_strHTML, "/watch?v=", "\"", 58000);

                            Process m_pYouTube = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/watch?v=" + m_strTarget);

                            //브라우저가 열리기까지 최대 10초 대기
                            for (int i = 0; i < 100; i++)
                            {
                                if (m_pYouTube.MainWindowTitle.Length == 0)
                                    Thread.Sleep(100);
                                else
                                    break;
                            }

                            //브라우저 최대화
                            Win32API.ShowWindow(m_pYouTube.MainWindowHandle, Win32Const.SW_MAXIMIZE);
                        }
                    }
                }

                if (m_strValue.Contains("구글"))
                {
                    String m_strSearch;
                    if (m_strValue.Contains("검색"))
                    {
                        if (m_strValue.Contains("구글에서"))
                        {
                            m_strSearch = StringParsing(m_strValue, "구글에서", "검색", 0);
                        }
                        else if (m_strValue.Contains("구글에"))
                        {
                            m_strSearch = StringParsing(m_strValue, "구글에", "검색", 0);
                        }
                        else
                        {
                            m_strSearch = StringParsing(m_strValue, "구글", "검색", 0);
                        }

                        m_strSearch = m_strSearch.Trim();

                        Process m_pGoogle = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.google.co.kr/search?q=" + System.Web.HttpUtility.UrlEncode(m_strSearch));
                    }
                }

                if (m_strValue.Contains("네이버"))
                {
                    String m_strSearch;
                    if (m_strValue.Contains("검색"))
                    {
                        if (m_strValue.Contains("네이버에서"))
                        {
                            m_strSearch = StringParsing(m_strValue, "네이버에서", "검색", 0);
                        }
                        else if (m_strValue.Contains("네이버에"))
                        {
                            m_strSearch = StringParsing(m_strValue, "네이버에", "검색", 0);
                        }
                        else
                        {
                            m_strSearch = StringParsing(m_strValue, "네이버", "검색", 0);
                        }

                        m_strSearch = m_strSearch.Trim();

                        Process m_pNaver = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://search.naver.com/search.naver?where=nexearch&query=" + System.Web.HttpUtility.UrlEncode(m_strSearch));
                    }
                }



                if (m_strValue.Contains("인터넷 꺼"))
                {
                    IntPtr Handle;
                    while ((int)(Handle = Win32API.FindWindow("Chrome_WidgetWin_1", null)) != 0)
                    {
                        Win32API.PostMessage(Handle, Win32Const.WM_CLOSE, 0, 0);
                    }
                }

                if (m_strValue.Contains("재부팅"))
                {

                    if (m_strValue.Contains("취소"))
                    {
                        m_ssTextToSpeech.Speak("재부팅 예약을 취소합니다.");
                        System.Diagnostics.Process.Start(@"shutdown.exe", "-a");
                        return;
                    }

                    m_ssTextToSpeech.Speak("1분 뒤 시스템을 재부팅 합니다.");
                    System.Diagnostics.Process.Start(@"shutdown.exe", "-r -f -t 60");
                }

                if (m_strValue.Contains("시스템 종료") || m_strValue.Contains("시스템종료"))
                {
                    if (m_strValue.Contains("취소"))
                    {
                        m_ssTextToSpeech.Speak("시스템 종료 예약을 취소합니다.");
                        System.Diagnostics.Process.Start(@"shutdown.exe", "-a");
                        return;
                    }
                    m_ssTextToSpeech.Speak("1분 뒤 시스템을 종료  합니다.");
                    System.Diagnostics.Process.Start(@"shutdown.exe", "-s -f -t 60");
                }

                if (m_strValue.Contains("몇시") || m_strValue.Contains("몇 시"))
                {
                    DateTime currTime = DateTime.Now;

                    String result = currTime.ToString("현재시각, tt hh 시 mm 분, 입니다.");
                    m_ssTextToSpeech.Speak(result);
                }

                if (m_strValue.Contains("몇일") || m_strValue.Contains("몇 일"))
                {
                    DateTime currTime = DateTime.Now;

                    String result = currTime.ToString("현재날짜, yyyy 년, M 월, d 일, dddd, 입니다.");
                    m_ssTextToSpeech.Speak(result);
                }
            });

            m_UDPServer.AddCommand("MOUSE", "MOVE", (m_strValue) =>
            {
                int X = int.Parse(m_strValue.Split(',')[0]);
                int Y = int.Parse(m_strValue.Split(',')[1]);
                Win32API.mouse_event(Win32Const.MOUSEEVENTF_MOVE, X, Y, 0, 0);
            });
            m_UDPServer.AddCommand("MOUSE", "SCROLL", (m_strValue) =>
            {
                int Y = int.Parse(m_strValue);
                Win32API.mouse_event(Win32Const.MOUSEEVENTF_WHEEL, 0, 0, Y, 0);
            });
            m_UDPServer.AddCommand("MOUSE", "CLICK", (m_strValue) =>
            {
                if (m_strValue.Equals("LEFT"))
                {
                    Win32API.mouse_event(Win32Const.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(10);
                    Win32API.mouse_event(Win32Const.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
                else
                {
                    Win32API.mouse_event(Win32Const.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(10);
                    Win32API.mouse_event(Win32Const.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                }
            });
            m_UDPServer.AddCommand("MOUSE", "DRAG", (m_strValue) =>
            {
                if (m_strValue.Equals("TRUE"))
                {
                    Win32API.mouse_event(Win32Const.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                }
                else
                {
                    Win32API.mouse_event(Win32Const.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
            });
            m_UDPServer.AddCommand("KEYBOARD", "NORMAL", (m_strValue) =>
            {

                if ('0' <= m_strValue[0] && m_strValue[0] <= 'Z' && m_strValue.Length == 1)
                {
                    Win32API.keybd_event(m_strValue[0], 0, Win32Const.KEYEVENTF_KEYDOWN, 0);
                    Win32API.keybd_event(m_strValue[0], 0, Win32Const.KEYEVENTF_KEYUP, 0);
                }
            });
            m_UDPServer.AddCommand("KEYBOARD", "SHIFT", (m_strValue) =>
            {
                Win32API.keybd_event(Win32Const.VK_SHIFT, 0, Win32Const.KEYEVENTF_KEYDOWN, 0);
                if ('0' <= m_strValue[0] && m_strValue[0] <= 'Z' && m_strValue.Length == 1)
                {
                    Win32API.keybd_event(m_strValue[0], 0, Win32Const.KEYEVENTF_KEYDOWN, 0);
                    Win32API.keybd_event(m_strValue[0], 0, Win32Const.KEYEVENTF_KEYUP, 0);
                }
                Win32API.keybd_event(Win32Const.VK_SHIFT, 0, Win32Const.KEYEVENTF_KEYUP, 0);
            });
            m_UDPServer.AddCommand("KEYBOARD", "SYMBOL", (m_strValue) =>
            {
                Thread m_tClipThread = new Thread(new ThreadStart(() =>
                {
                    Clipboard.SetText(m_strValue);
                    Win32API.keybd_event(Win32Const.VK_CONTROL, 0, 0, 0);                             //Ctrl(Down)
                    Win32API.keybd_event('V', 0, 0, 0);                                               //VKey(Down)
                    Win32API.keybd_event('V', 0, Win32Const.KEYEVENTF_KEYUP, 0);                      //VKey(UP)
                    Win32API.keybd_event(Win32Const.VK_CONTROL, 0, Win32Const.KEYEVENTF_KEYUP, 0);    //SHIFT(Up)
                }));
                m_tClipThread.SetApartmentState(ApartmentState.STA); //클립보드 사용을 위한 스레드아파트 설정
                m_tClipThread.Start();
            });
            m_UDPServer.AddCommand("KEYBOARD", "FUNC", (m_strValue) =>
            {
                if (m_strValue.Equals("SPACE"))
                {
                    Win32API.keybd_event(Win32Const.VK_SPACE, 0, 0, 0);                 //  누름
                    Win32API.keybd_event(Win32Const.VK_SPACE, 0, Win32Const.KEYEVENTF_KEYUP, 0);  //  누름 해제  
                }
                else if (m_strValue.Equals("ENTER"))
                {
                    Win32API.keybd_event(Win32Const.VK_RETURN, 0, 0, 0);                 //  누름
                    Win32API.keybd_event(Win32Const.VK_RETURN, 0, Win32Const.KEYEVENTF_KEYUP, 0);  //  누름 해제  
                }
                else if (m_strValue.Equals("BACK"))
                {
                    Win32API.keybd_event(Win32Const.VK_BACK, 0, 0, 0);                 //  누름
                    Win32API.keybd_event(Win32Const.VK_BACK, 0, Win32Const.KEYEVENTF_KEYUP, 0);  //  누름 해제  
                }
                else if (m_strValue.Equals("CHANGE"))
                {
                    Win32API.keybd_event(Win32Const.VK_HANGUL, 0, 0, 0);                 //  누름
                    Win32API.keybd_event(Win32Const.VK_HANGUL, 0, Win32Const.KEYEVENTF_KEYUP, 0);  //  누름 해제
                }
                else if (m_strValue.Equals("VUP"))
                {
                    Win32API.keybd_event(Win32Const.VK_VOLUME_UP, 0, 0, 0);                 //  누름
                    Win32API.keybd_event(Win32Const.VK_VOLUME_UP, 0, Win32Const.KEYEVENTF_KEYUP, 0);  //  누름 해제  
                }
                else if (m_strValue.Equals("VDOWN"))
                {
                    Win32API.keybd_event(Win32Const.VK_VOLUME_DOWN, 0, 0, 0);                 //  누름
                    Win32API.keybd_event(Win32Const.VK_VOLUME_DOWN, 0, Win32Const.KEYEVENTF_KEYUP, 0);  //  누름 해제  
                }
            });

            m_UDPServer.AddCommand("DEVICE", "COMMAND", (m_strValue) =>
            {
                MessageBox.Show(m_strValue);
            });

        }

        private void SpeechHandler(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence * 100 < currentTask.recognitionLevel)
                return;
            if (e.Result.Text.Equals(currentTask.recognitionName))
            {
                //소리 재생
                new SoundPlayer(Properties.Resources.dropWater).Play();

                //스마트폰에 메시지 전송
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPAddress ip = IPAddress.Parse(currentTask.voiceModuleIP);
                IPEndPoint endPoint = new IPEndPoint(ip, 8792);
                byte[] sBuffer = Encoding.UTF8.GetBytes("1");
                socket.SendTo(sBuffer, endPoint);
                socket.Close();
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setup fSetup = new Form_Setup(ref currentTask);
            fSetup.Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentTask.Save();
            ProcessRun = false;
        }

        public String GetHTMLFromURL(String m_strURL)
        {
            WebRequest m_wrSite = (HttpWebRequest)WebRequest.Create(m_strURL);
            WebResponse m_wrpResult = m_wrSite.GetResponse();
            StreamReader m_srHTMLStream = new StreamReader(m_wrpResult.GetResponseStream(), Encoding.UTF8);
            return m_srHTMLStream.ReadToEnd();
        }

        public String StringParsing(String m_strTarget, String m_strStart, String m_strEnd, int m_intStartPoint)
        {
            int m_intTargetStartPoint = m_strTarget.IndexOf(m_strStart, m_intStartPoint) + m_strStart.Length;
            int m_intTargetLength = m_strTarget.IndexOf(m_strEnd, m_intTargetStartPoint) - m_intTargetStartPoint;
            return m_strTarget.Substring(m_intTargetStartPoint, m_intTargetLength);
        }
    }
}
