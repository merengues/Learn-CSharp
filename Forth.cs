using System;
namespace Wrox
{
    class ScopeTest2
    {
        static int j=20;
        public static void Main()
        {
            int j =30;
            Console.WriteLine(j);
            Console.WriteLine(ScopeTest2.j);
            return;
        }
    }
}