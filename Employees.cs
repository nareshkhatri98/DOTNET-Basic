using System;
/* struct is like a class but it is a value time only i.e. it is not a reference type like a class.
 
it only stores value not address, struct can have constructor properties*/

namespace swscbasic
{
     struct  Employees
    {

        //instance variable
        int id;
        public string name;
        string department;
        string salary;
        //constructor

        public Employees(int id, string name, string department, string salary)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public void displayEmployees()
        {

            Console.WriteLine("id is " + this.id);

            Console.WriteLine("-------------------");
            Console.WriteLine("name is " + this.name);
            Console.WriteLine("department is" + this.department);
            Console.WriteLine("salary is " + this.salary);
        }
    }
}

