using System;

namespace StatementLambda
{
    class MainApp
    {
        delegate string Concatenate(string[] str);

        static void Main(string[] args)
        {
            Concatenate cat = (string[] str) =>
                {
                    string result = "";
                    foreach(string s in str)
                    {
                        result += s;
                    }

                    return result;
                };

            Console.WriteLine(cat(args));
        }
    }
}