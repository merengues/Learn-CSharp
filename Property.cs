// using System;
// namespace Property
// {
//     class Name
//     {
//         public static void Main()
//         {
//             int i = 50;
//             string str = i.ToString();
//             Console.WriteLine(str);
//             Console.WriteLine(str.GetType());
//         }
        
//     }
// }

using System;
namespace Wrox
{
    class MainEnterPoint
    {
        static void Main(string[] args)
        {
            Money cash = new Money();
            cash.Amount = 40M;
            Console.WriteLine("cash.ToString() returns: "+cash.ToString());


        }
    }

    public class Money
    {
        private decimal amount;

        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public override string ToString()
        {
            return "$" + amount.ToString();
        }
    }
}