using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace swscbasic
{
    // dynamic binding : It is the feature of c# that allow properties and mehtod to check in run time not in compile tim.
    // fot this "dynamic" keyword is used code, code check only in run tiime only( when program is executed)...
    internal class Deom
    {
        

        // creating dynamic  properties...

        public dynamic Id { get; set; }
        public dynamic Name { get; set; }
        public dynamic Department { get; set; }
        public dynamic Specialization { get; set; }

        // dynamic mehtod
        public dynamic displayName()
        {
            return this.Name;
        }

        public dynamic displayId()
        {
            return this.Id;
        }
        public dynamic dispalyDepartment()
        {
            return this.Department;
        }

        public dynamic displaySpecialization()
        {
            return this.Specialization;
        }

    }
}
