using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swscbasic
{
    // such class declared using abstractkeyword and cannot be instantiated 
    //object of abstract class cannot created..
    // abstract class can have instance variable , constructor, normal method, abstract method: 
    //such methos that doesnot have implementation part and are declared only.
    // it is used to provide abstract: hide details.
    // abstract class must be inherited by normal class and  such normal class should provide implementation
    // of abstract method.
    abstract class Solution1
    {
        // can have instance variable.
        int x1;
        int y1;

        // can have onstructor
        public Solution1(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public void calcSum()
        {
            Console.WriteLine("sum is " + (this.x1 + this.y1));
        }

        // abstract method
        public abstract void calcDiff(int x, int y);
    }

    class Solution2 : Solution1
    {
        int x2;
        int y2;
        
        public Solution2(int x2, int y2, int x1, int y1):base( x1,y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public void calcMulti()
        {
            Console.WriteLine("Multiply is " + (this.x2 + this.y2));
        }

        // providing details of abstract method

        public override void calcDiff(int x, int y)
        {
            Console.WriteLine("differnece is " + (x - y));
        }
    }
}
