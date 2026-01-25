using System;
using System.Reflection;

namespace ExReflection
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 0;

            Type type = a.GetType();
            FieldInfo[] fields = type.GetFields();

            foreach(FieldInfo field in fields)
            {
                Console.WriteLine("type : {0}, Name :{1}", field.FieldType.Name, field.Name);
            }
        }
    }
}