using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            // No arguments given
            if(args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
            }
            else
            {
                //Change all chars ToUpper()
                for (int i = 0; i < args.Length; i++)
                {
                    args[i] = args[i].ToUpper();
                }

                Array.Sort(args);

                StringBuilder final = new StringBuilder();
                final.Append(String.Join("-", args));

                Console.WriteLine(final);
            }
        }
    }
}
