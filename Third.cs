using System;
namespace Wrox.ProCSharp.Basics
{
    public class ScopeTest
    {
        public static int Main()
        {
            int j=20;
            for(int i= 0; i < 10; i++)
            {
                int j = 30;
                Console.WriteLine(j+i);
            }

            // for(int i=0;i<10;i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for(int i=9;i>=0;i--)
            // {
            //     Console.WriteLine(i);
            // }

            return 0;
        }
    }
}