using System;
using ArrayList;
namespace Collections
{
    class Test  
    {
        public static void Main()
        {
            var list = new ArrayList();
            list.Add(44);
            int i1=(int)list[0];

            foreach (int i2 in list)
            {
                Console.WriteLine(i2);
            }
        }
    }
}