using System;

//operrator overloading : it the way to all operator to perform seprate operation i.e  + sign perform addition when
// inputs are integer and it also perform concatenation(join) if inputs are string 
// operator tha can be overloaded are arithmetic operator like +,-,*,/%, comparison operator >,< ==, conditonal operator
// &&, || 
//other operator cannot be overloaded like assignment " +=, -=
// =,?, new . -> "
namespace swscbasic
{
     class Boxes
    {
        private int length;
        private int breadth;
        private int height;

        public  void SetBoxes(int lenght , int breadth, int height)
        {
            this.length = lenght;
            this.breadth = breadth;
            this.height = height;
        }
        // method that calcualte volume
        public void CalcVol()
        {
            Console.WriteLine("The volume  is " + (length * breadth * height));
        }
        //overloading
        public static Boxes operator + (Boxes b1, Boxes b2)
        {
            Boxes b3 = new Boxes();
            b3.length = b1.length + b2.length;
            b3.breadth = b1.breadth + b2.breadth;
            b3.height = b1.height + b2.height;
            return b3; // return type is class, so object should be return
        }

        // overloading  "==" operator (compreison operator)
        public static bool operator ==(Boxes b1, Boxes b2)
        {
            bool temp = false;
            if (b1.length == b2.length && b1.breadth == b2.breadth && b1.height == b2.height)
            {

                temp = true;
                return true;

            }
            else
            {
                return temp;
            }
        }
             public static bool operator !=(Boxes b1, Boxes b2)
        {
            bool temp = false;
            if (b1.length != b2.length && b1.breadth != b2.breadth && b1.height != b2.height)
            {

                temp = true;
                return true;

            }

           else
               {
                return temp;
            }


             }

        }
}
