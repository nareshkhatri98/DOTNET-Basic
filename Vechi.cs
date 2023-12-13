using System;

namespace swscbasic
{
    // Base class
    class Vechi
    {
        private int reg;
        private string model;
        private string name;

        public void setVehicle(int reg, string model, string name)
        {
            this.reg = reg;
            this.model = model;
            this.name = name;
        }

        public void displayVehicle()
        {
            Console.WriteLine("registration is " + reg);
            Console.WriteLine("model is " + model);
            Console.WriteLine("name is " + name);
        }
    }

    // Derived class
    class car : Vechi
    {
        private string drivemode;
        private string speed;

        public void setCar(string drivemode, string speed)
        {
            this.drivemode = drivemode;
            this.speed = speed;
        }

        public void displayCar()
        {
            Console.WriteLine("Drive mode is " + drivemode);
            Console.WriteLine("speed is " + speed);
        }
    }

    // Further derived class
    class ElectricCar : car
    {
        private string range;

        public void setElectricCar(string range)
        {
            this.range = range;
        }

        public void DisplayElectricCar()
        {
            Console.WriteLine("range is " + range);
        }
    }
}
