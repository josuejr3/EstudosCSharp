using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string original = "abcde FGHIJ ABC abc DEF    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();


            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");


            string s4 = original.Substring(3);


            Console.WriteLine("Original:  " + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("ToLower: " + s2);
            Console.WriteLine("Trim: " + s3);
            Console.WriteLine("n1: " + n1);
            Console.WriteLine("n2: " + n2);
            Console.WriteLine("s4: " + s4);




        }
    }
}