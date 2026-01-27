using System;
using System.ComponentModel;
using System.IO;

namespace SeqNRand
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine($"Position : {outStream.Position}"); //Position 이 프로퍼티로 구현 되어있음... 

            outStream.WriteByte(0x01);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x02);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x03);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.Seek(5, SeekOrigin.Current);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x04);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.Close();

            byte[] rbyte = new byte[16];
            Stream inStream = new FileStream("a.dat", FileMode.Open);

            //inStream.Seek(0, SeekOrigin.End);
            inStream.Read(rbyte, 0, 16);
            
            int n;
            n = BitConverter.ToInt32(rbyte);

            Console.WriteLine(n);

            inStream.Close();
        }
    }
}