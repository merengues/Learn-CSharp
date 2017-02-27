// using System;
// namespace Wrox
// {
//     class MainEntryPoint
//     {
//         static void Main(string[] args)
//         {
//             for(int i=0;i<100;i+=10)
//             {
//                 for(int j=i;j<i+10;j++)
//                 {
//                     Console.Write(" "+j);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

using System;
namespace Worx
{
    class Test
    {
        static int Main(string[] args)
        {
            for(int i=0;i<args.Length;i++)
            {
                Console.WriteLine(args[i]);
                Console.WriteLine(i);
            }

            return 0;
        }
    }
}