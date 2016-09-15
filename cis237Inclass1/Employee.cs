using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Employee
    {
        //***************
        //Backing Fields
        //***************
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        //***************
        //Properties
        //***************
        public string FirstName
        {
            get { return _firstName;   }
            set { _firstName = value;  }
        }

        public string LastName
        {
            get { return _lastName;  }
            set { _lastName = value; }
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary;  }
            set { _weeklySalary = value; }
        }

        //***************
        //Public Methods
        //***************
        //Uses the override keyword, this will override the automatic one that comes with every object
        public override string ToString()
        {
            //the this keyword is used to reference "this" class. It allows us to reference thing that are at this class level 
            return this._firstName + " " + this._lastName;
        }

        public decimal YearlySalary()
        {
            return (_weeklySalary * 52m);
        }

        //***************
        //Constructor
        //***************
        //Constructor that takes three parameters
        public Employee(string firstName, string lastName, decimal weeklysalary)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._weeklySalary = weeklysalary;
        }

        //A empty constructor. We must add it back in because as soon as a constructor is added to a class
        //the empty default is no longer available. We are required to write it ourselves
        public Employee()
        {
            //Do Nothing
        }



    }
}
