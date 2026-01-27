using System;
using System.IO;

namespace BinaryFile
    
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good Morning");
                bw.Write(UInt64.MaxValue);
                bw.Write("안녕하십니꺼");
                bw.Write(double.MaxValue);
            } //bw stream 은 여기서 close 된다. 

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            Console.WriteLine($"File Size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt64()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");

            return;
        }
    }
}