using System;


namespace swscbasic
{
    
    /*
      Accessing supper class constructor from subclass.
      sub class cannot access constructor  of superclass directly.
      becuase constructor is called when object of particular class is  created  i.e  to call supper class.
      Constructor its object should be created sp tp call constructor of parent class "base" keyword is used
      to call constructor of supper class base keyword should used in constructor of sub class.
    */
     class Vechiles
    {
        private int reg;
        private string model;
        private string name;
        /*
         default constructor.
        // default construtor of supperclass is autmatically called when object of subclass is created.
        first default constructor of supper class is executed then of subclass constructor.
        */


        public Vechiles()
        {
            Console.WriteLine("This is default of supper-class(vechiles..)");
        }
        public Vechiles(int reg, string model, string name)
        {
            this.reg = reg;
            this.model = model;
            this.name = name;
        }
        public void DisplayVechiles()
        {
            Console.WriteLine("registration is " + this.reg);
            Console.WriteLine("model is " + this.model);
            Console.WriteLine("name is " + this.name);
        }

    }
    class Bike : Vechiles

    {
        private string milege;
        private string speed;
        public Bike()
        {
            Console.WriteLine("Default constructor of subclass(Bike)...");
        }

        public Bike(string milege, string speed, int reg, string model, string name) : base( reg, model, name )

        {
            this.milege = milege;
            this.speed = speed;
        }

        public void DisplayBike()
        {
            Console.WriteLine("Milege is " + this.milege);
            Console.WriteLine("Speed is " + this.speed);

        }
    }
}
