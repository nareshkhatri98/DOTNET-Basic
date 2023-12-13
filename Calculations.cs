using System;

namespace swscbasic
{
    // in inheritance  superclass and subclass contains same method i.e. same return type, same name
    // same parameter then such conditions is known as method overriding
    // it is used to achieve dynamic polymorphism , it means that polymerphisim is recognize at run time.
    // in c#to create method overriding two keywod used.
    // virtula keyword: used in overriding method of superclass.
    // override keyword: used in overriding method od subclass.
    // to call overriden method of superclass we used base keyword.
     class Calculations
    {
        // creatuing method to show method overriding conditions.
        public virtual void calcs1( int x, int y)
        {
            Console.WriteLine("sum is " + (x + y));
        }
        public virtual void calcs2( int x, int y, int z)
        {
            Console.WriteLine("Multiplication is " + (x * y * z));
        }
    }
    class Solution :Calculations
    {
        public override void calcs1(int x, int y)

        {
            base.calcs1(x, y);// calls calcs1 of supperclass(parent class).
            Console.WriteLine("difference is " + (x - y));
        }
        public override void calcs2(int x, int y, int z)
        {
            base.calcs2(x, y, z); // calls calcs2 of supperclass.
            Console.WriteLine("simplify is " + (x + y *z));
        }

    }
}
