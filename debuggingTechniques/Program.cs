
using System;


class Methods
{
    static void Main()
    {


        Method1();
        Method2();
        method3();
        method4();
       
    }

    static void Method1()
    {
        Console.WriteLine("Method1 is called");
        string empname = "john";
        int empage = 35;
        decimal empsalary = 15000.98m;
        Console.WriteLine($"showing the data before checkpoint 2 :{empname},{empage},{empsalary}");

    }


    static void Method2()
    {
        Console.WriteLine("Method2 is called");
    }


   
   static void method3()
    {
        Console.WriteLine("method3 is called");
    }


    static void method4()
    {
        Console.WriteLine("method4 is called");

    }

}