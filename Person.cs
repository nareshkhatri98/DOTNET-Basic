using System;


namespace swscbasic
{  
    // inheritance is a process of accquring properties of one class by another class.
    //such class that inherits other class is known as sub-class (child,derived) and such class 
    // that gets inherits by other supper class(parent). subclass can use all the properties of
    //super classs i.e. mthod ,instance variable but cannot use constructor and private member.
    // inheritance is used to reuse the code and to reduce repeated code.
     class Person
    {
        private int cid;
        private string name;
        private string gender;
        private int age;

        // creating ethod to set value of instance varibale.
        public void setPerson(int cid, string name, string gender, int age)
        {
            this.cid = cid;
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public void displayPerson()
        {
            Console.WriteLine("id is " + cid + " name "
                + name + "gender is " + gender + " age is " + age);
            
        }
    }
    // single level inheriutance : one parent is inheritance by one or more child class.
     class Student : Person //to inherit colum(:) sign should used..
    {
        private string faculty;
        private string grade;
       
        public void setStudent(string faculty , string grade)
        {
            this.faculty = faculty;
            this.grade = grade; 
        }
        public void displayStudent()
        {
            Console.WriteLine("faculty is " + faculty + "grade is " + grade);
        }

    }
    class Teachers1:Person
    {
        private string department;
        private string specialization;
        
        public void setTeacher(string department, string specialization)
        {
            this.department = department;
            this.specialization = specialization;


        }
        public void displayTeacher()
        {
            Console.WriteLine("deopartment is " + department + " specialization is " + specialization);
        }
    }
}
