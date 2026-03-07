using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if(args.Length<1)
            {
                Console.WriteLine("사용법 : {0} <Bind IP>", Process.GetCurrentProcess().ProcessName);
                return;
            }

            string bindIP = args[0];
            const int bindPort = 5425;
            TcpListener server = null;

            try
            {
                IPEndPoint localAddress =
                    new IPEndPoint(IPAddress.Parse(bindIP), bindPort);

                server = new TcpListener(localAddress);
                //TcpListener 은 서버에서 만 쓴다..

                server.Start();
                Console.WriteLine("메아리 서버 시작...");

                while(true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("클라이언트 접속 : {0}", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];
                
                    while((length = stream.Read(bytes,0,bytes.Length))!=0)
                    {
                        data = Encoding.Default.GetString(bytes, 0, length); 
                        //송신된 데이터를 byte -> string 
                        Console.WriteLine(String.Format("수신 : {0}", data));
                        // 수신된 데이터 출력..


                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        
                        Console.WriteLine(String.Format("송신 : {0}", data));
                    }

                    stream.Close();
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop();
            }

            Console.WriteLine("서버를 종료합니다")
        }
    }
}