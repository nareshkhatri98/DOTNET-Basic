using System;
//interface is like a abstract class but difference is that interface only contains list of the abstract method:
// such method that doesnot have implementation part( no body) 
// interface's object cannot be created . it doesnot have constructor
// it doesnot have normal method
// contains list of abstract method only
// normal class have to use (inherit) interface and such class
//have to provide implementation of abstract class contains in interface.

namespace swscbasic
{

    interface Calculation1
    {
        //list abstract method
         void sum(int x, int y);
        int mul(int x, int y);
    }
    // multiple inheritance is possible using interface i.e.
    // one class can inherite (use) two or more interface at once.
    interface Calculation2
    {
        void div(int x, int y);
        void findeven(int x);
    }
     class Interface1 : Calculation1, Calculation2
    {
        public void sum( int x, int y)
        {
            Console.WriteLine("sum is " +(x + y));
        }
        public int mul(int x, int y)
        {
            return (x * y);
        }
        public void div(int x, int y)
        {
            Console.WriteLine("dividion is " + (x / y));
        }
        public void findeven (int x)
        {
          if(x%2 == 0)
            {
                Console.WriteLine("number is even");
            }
          else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
