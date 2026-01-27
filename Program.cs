using System;
using System.IO;

namespace BasicIO
{
    class MainApp
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue); // 원본 데이터 생성...

            Stream outStream = new FileStream("a.dat", FileMode.Create); //출력스트림 생성

            byte[] wBytes = BitConverter.GetBytes(someValue); //출력스트림에 쓸 버퍼임. 

            Console.Write("{0,-13} : ", "Byte Array");
            foreach (byte b in wBytes)
                Console.Write("{0:X2}", b);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length); 
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
                rbytes[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rbytes, 0);

            Console.Write("{0,-13} : 0x{1:X16}", "Read Data",readValue);
        }
    }
}