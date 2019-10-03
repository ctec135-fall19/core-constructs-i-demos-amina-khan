using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations

            int myInt; /* 32-bit */
            long myLong = 0;
            double myDouble = 0.0;  /* 64-bit*/
            string myStr = "Some text";

            #endregion

            #region printing p.63-67

            //build errors and warning
            //Console.WriteLine("myInt: {0}", myInt);

            Console.WriteLine("myLong:   {0}", myLong);
            Console.WriteLine("myLong:c   {0:c}", myLong);
            Console.WriteLine("myLong:d   {0:d}", myLong);
            Console.WriteLine("myLong:e   {0:d6}", myLong);
            Console.WriteLine("myLong:x   {0:X}", 31);
            Console.WriteLine();

            #endregion

            #region casting p. 88-90

            byte myByte = 255;
            byte myByte2 = (byte)(myByte + 1); //parens mean its being evaluated

            Console.WriteLine("MyByte: {0}", myByte);
            Console.WriteLine("MyByte2: {0}", myByte2);

            #endregion

            #region strings p. 79-88

            string hello = "hello";
            string world = "world";
            string str;
            Console.WriteLine("length of hello : {0}", hello.Length);
            Console.WriteLine("test ==: {0}", hello == "hello2");
            Console.WriteLine("test ==: {0}", hello == "hello");
            Console.WriteLine("test ==: {0}", hello.Equals("hello"));    //built in method

            Console.WriteLine("Compare: {0}", hello.CompareTo(world));   //world is the variable holding "world"
            Console.WriteLine("Compare: {0}", hello.CompareTo(hello));   //hello is the variable holding "hello"
            
            // concatenation
            
            str = hello + "  " + world ;
            Console.WriteLine(str);

            // verbatim
            str = @"c:\MyApp\bin\debug";
            string str2 = "c:\\MyApp\\bin\\debug";

            Console.WriteLine(str);
            Console.WriteLine(str2);

            #endregion

        }
    }
}
