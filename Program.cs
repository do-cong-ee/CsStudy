using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
#pragma warning disable SYSLIB0011


namespace Serialization
    
{
    class MainApp
    {
        [Serializable]
        class NameCard
        {
            public string Name;
            public string Phone;
            public int age;
        }
        static void Main(string[] args)
        {
            using (Stream ws = new FileStream("a.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                NameCard nc = new NameCard();
                nc.Name = "대식이";
                nc.Phone = "010-0000-0000";
                nc.age = 2000;

                serializer.Serialize(ws, nc);
            }

            using Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);

            Console.WriteLine(nc2.Name);
            Console.WriteLine(nc2.Phone);
            Console.WriteLine(nc2.age);
        }
    }
}