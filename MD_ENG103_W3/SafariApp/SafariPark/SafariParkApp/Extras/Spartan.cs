using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Spartan
    {
        //public int FirstName { get; set; }
        //public int LastName { get; set; }
        //public int Stream { get; set; }
        //public int Degree { get; set; }

        // into


        //public int FirstName { get; }
        //public int LastName { get; }
        //public int Stream { get; }
        //public int Degree { get;  }

        //public Spartan(string fName, string lName, string stream, string degree)
        //{
        //  FirstName = fName;
        //  LastName = lName;
        //  Stream = stream;
        //  Degree = degree;
        //}
        //var spartan = new Spartan ("Ned", "Tomilson", "c# dev", "Neuroscience");

        // into c#9 init makes a property read only, and can be initialized when called
        public int FirstName { get; init; }
        public int LastName { get; init; }
        public int Stream { get; init; }
        public int Degree { get; init; }
        //var spartan = new Spartan() {FirstName = "Ned", LastName = "Tomilson", Stream = "c# dev", Degree = "Neuroscience"};
    }
}
