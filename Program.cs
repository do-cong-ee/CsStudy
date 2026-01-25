using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace GetType
{
    class MainApp
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("--------------Interfaces---------------");

            Type[] interfaces = type.GetInterfaces();
            foreach(Type i in interfaces)
            {
                Console.WriteLine("Name :{0}", i.Name);
            }

            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("--------------Fields---------------");

            FieldInfo[] fieldinfos = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance);
        }
    }
}