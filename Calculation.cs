using System;


namespace swscbasic
{
    // if two or more method that have name but different in
    // parmeter and return type is method overloading
    //it is used to achieve static polymorphism :same name different features.
     class Calculation
    {
        //creating method
        public void Calc()
        {
            Console.WriteLine("this is empty method");
        }
        //creating second method with same name
        public void Calc(int x, int y)
        {
            Console.WriteLine("sum is:" +(x + y));
        }
        // ceratin third method with same name and no of parameter but different in datatype.
        public void Calc(double x, double y)
        {
            Console.WriteLine("difference is :" + (x - y));
        }
        // creating fourth method with return type.
        public int Calc(int x, int y, int z)
        {
            return (x * y + z);
        }
    }
}
