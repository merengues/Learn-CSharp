using System;
namespace Wrox
{
    class Client
    {
        public static void Main()
        {
            MathLib mathObj = new MathLib();
            Console.WriteLine(mathObj.Add(7,8));

            string s = Console.ReadLine();
            Console.WriteLine(s);

            int i=10,j=20;
            Console.WriteLine("{0} plus {1} equals {2} ",i,j,i+j);

            PhoneCustomer myCustomer = new PhoneCustomer();
            PhoneCustomerStruct myCustomer2 = new PhoneCustomerStruct();

            Console.WriteLine(myCustomer.DayOfSendingBill);
        }
    }

    class PhoneCustomer
    {
        public const string DayOfSendingBill="Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }

    struct PhoneCustomerStruct
    {
        public const string DayOfSendingBill="Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }

    
}