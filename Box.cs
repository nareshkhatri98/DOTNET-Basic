using System;
// properties in c#.
// it is like a constructor or getter and setter thai is used
//to initalize instance variable and to return value of instance variable.
// it is used  to achieve encapsulation as instance variable are hidden .
// it is a combination of private variable , get and set method.

namespace swscbasic
{
    internal class Box
    {
        private double length;
        private double breadth;
        private double height;
        // creating properties for length

        public double Length
        {
            get { return length; }// return value of instance variable.
            set { length = value; } // initialize value of instance variable.
        }
        //for breadth
        public double Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
        // for public double 
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
