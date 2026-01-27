using System;
using System.Linq;
using System.IO;

namespace Touch
{
    class MainApp
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong");
            return;
        }

        static void Main(string[] args)
        {
            if(args.Length==0)
            {
                Console.WriteLine(
                    "Useage : Touch.exe <path> [Type:File/Diretory]"
                    );
            }

            string path = args[0];
            string type = "File";
            if(args.Length>1)
            {
                type = args[1];
            }

            if(File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated {path} : {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Creat {path} : {type}");
            }
        }
    }
}