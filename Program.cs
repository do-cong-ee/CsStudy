using System;

namespace ExStructure
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        //구조체는 public 으로 선언.. 

        public Point3D(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format($"{this.x}, {this.y}, {this.z}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;
            p3d1.x = 10;
            p3d1.y = 20;
            p3d1.z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());

            return;
        }
    }
}