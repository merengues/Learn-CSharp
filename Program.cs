using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class parametertest
    {
        static void someFunction(out int i)
        {
            i = 100;
        }

        //public static void somefunction(int[] ints, ref int i)
        //{
        //    ints[0] = 100;
        //    i = 100;
        //}

        public static void Main()
        {
            int i;
            someFunction(out i);
            Console.WriteLine(i);
            Console.ReadLine();
            

            //int i = 0;
            //int[] inti = { 0, 1, 2, 3 };
            //Console.WriteLine("i = " + i);
            //Console.WriteLine("inti[0] = " + inti[0]);

            //somefunction(inti, ref i);

            //Console.WriteLine("i = " + i);
            //Console.WriteLine("inti[0] is " + inti[0]);

            //Console.ReadLine();

        }
    }


    //class parameterTest
    //{
    //    static void someFunction(int[] ints, ref int i)
    //    {
    //        ints[0] = 100;
    //        i = 100;
    //    }

    //    public static int Main()
    //    {
    //        int i = 0;
    //        int[] ints = { 0, 1, 2, 4, 8 };
    //        Console.WriteLine("i = " + i);
    //        Console.WriteLine("int[0] = " + ints[0]);
    //        Console.WriteLine("Calling someFunction.");

    //        someFunction(ints, ref i);
    //        Console.WriteLine("i = " + i);
    //        Console.WriteLine("ints[0] = " + ints[0]);

    //        Console.ReadLine();
    //        return 0;

    //    }
}

    //class MainEnterPoint
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Pi is " + MathTest.GetPi());
    //        int x = MathTest.GetSquareOf(5);
    //        Console.WriteLine("Square of 5 is " + x);

    //        MathTest math = new MathTest();

    //        math.value = 30;
    //        Console.WriteLine("value filed of math vavriable contains " + math.value);
    //        Console.WriteLine("Square of 30 is " + math.getSquare());

    //        Console.ReadLine();
    //    }
    

    //class MathTest
    //{
    //    public int value;

    //    public int getSquare()
    //    {
    //        return value * value;
    //    }

    //    public static int GetSquareOf( int x)
    //    {
    //        return x * x;
    //    }

    //    public static double GetPi()
    //    {
    //        return 3.14159;
    //    }
    //}

    //class PhoneCustomer
    //{
    //    public const string DayOfSendingBill = "Monday";
    //    public int CustomerID;
    //    public string FirstName;
    //    public string LastName;
    //    public bool IsPositive(int value)
    //    {
    //        if (value < 0)
    //            return false;
    //        return true;
    //    }
    //}

    //struct PhoneCustomerStruct
    //{
    //    public const string DayOfSendingBill = "Monday";
    //    public int CustomerID;
    //    public string FirstName;
    //    public string LastName;
    //}


