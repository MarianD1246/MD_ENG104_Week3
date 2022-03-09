using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person :iMovalbe
    {
        //Propetries a

        protected string _firstName;
        protected string _lastName;

        //propfull + tab tab
        // _age is a backing field
        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can not have age below 0.");
                }
                else
                    _age = value; 
            }
        }

        //prop + tab tab //Short hand for above code
        //public int Age { get; set; } // propretry


        //public string FirstName { get; }
        //public string LastName { get; private set; }
        //in these cases the values are private and have to be set in these class

        //ctor + tab tab 

        //Constructor overloading
        //public Person(string firstName)
        //{
        //    _firstName = firstName;
        //}

        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Person() { }

        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(int age)
        {
            Age = age;
        }
        public string GetFullName() => $"{FirstName} {LastName}";
        public string FullName => $"{_firstName} {_lastName}";
        // similar to public string GetFullName() { get {return $"{_firstName} {_lastName}"; } }
        // cannot use setters because we are assigning a value and thus can't set 2 values

        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
