using System;
using System.Collections;

namespace MyProgram
{

    class MainApp
    {
        static int Recursion(string str, int l,int r,ref int num_of_recursion)
        {
            if (l >= r) return 1;
            else if (str[l] != str[r]) return 0;
            else{
                num_of_recursion++;
                return  Recursion(str, l + 1, r - 1, ref num_of_recursion);
            }
        }
        static int Palindrom(string str, ref int num_of_recursion)
        {
            num_of_recursion++;
            return Recursion(str, 0, str.Length - 1, ref num_of_recursion);
        }
        static void Main(string[] args)
        {
            Int32 num;
            num = int.Parse(Console.ReadLine());
            string str="";
            int num_of_recursion=0;
            for(int i=0;i<num;i++)
            {
                str = Console.ReadLine();
                num_of_recursion = 0;
                Console.Write("{0} ",Palindrom(str, ref num_of_recursion));
                Console.WriteLine("{0}", num_of_recursion);
                //레퍼런스 전달할때는 함수의 호출에서도 ref 키워드 써줘야..
                
            }
            
        }
    }
}