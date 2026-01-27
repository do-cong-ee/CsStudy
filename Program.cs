using System;
using System.ComponentModel;
using System.IO;
using FS = System.IO.FileStream;
//별칭 지시자 System.IO.FileStream 을 FS 로 줄여서 부를 수 있게 해준다.

namespace UsingDeclare
{
    class MainApp
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

            using (Stream outStream = new FS("a.dat", FileMode.Create))
            {
                byte[] wbytes = BitConverter.GetBytes(someValue);

                Console.Write("{0,-13} : ", "Byte Array");

                foreach(byte b in wbytes)
                {
                    Console.Write("{0:X2}", b);
                }
                Console.WriteLine();

                outStream.Write(wbytes, 0, wbytes.Length);
            }

            using Stream inStream = new FS("a.dat", FileMode.Open);
            byte[] rByte = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
                rByte[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rByte);
            Console.WriteLine("{0,-13} : 0x{1:X16}", "Read Data", readValue);

        }
    }
}