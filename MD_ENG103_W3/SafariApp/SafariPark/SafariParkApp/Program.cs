using System;
using SafariParkApp;

public class Program
{
    public static void Main()
    {
        //Person Marian = new Person("Marian","Dumitriu", 23);
        //Console.WriteLine(Marian.GetFullName());
        //Person Bob = new Person("Bob", "Cull", 21);
        //Console.WriteLine(Bob.GetFullName());
        #region creating objects
        //Bob's full name and age are acessable
        //Bob.GetFullName();
        //Bob.Age = 20;
        //Person Steven = new Person("Steven");
        //Steven.Age = 3; // Calls the setter of Age
        //var stevenAge = Steven.Age; // Calls the getter of age
        //Console.WriteLine(Steven.GetFullName());

        //Person Negatron = new Person("Negatron");
        //try
        //{
        //    Negatron.Age = -3;
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //object initaliser
        //var arr = new int[] { 1, 2, 3 };
        //object initialiser also using the setter
        //var nish = new Person("Nishant", "Mandal", 31);
        // or
        //var nish = new Person("Nishant", "Mandal") {Age = 31};

        //var basket = new ShoppingBasket() { Bread = 2, Potato = 6, Milk = 2};

        //var nish = new Person() { FirstName = "Nish", LastName = "Mandal", Age = 32 };
        //nish.Age = 33;
        ////nish.FirstName = "nishy"; //error cuz init makes the variable private
        //var person = new Person() { FirstName = "Jay", LastName = "Z", Age = 51 };
        //var pt3d = new Stuct3D(1, 2, 3);
        //DemoMethod(person, pt3d);
        //Console.WriteLine($"Y coord: {pt3d.y}. Jay Z's age: {person.Age}.");

        #endregion

        #region inheretance
        //Hunter h = new Hunter("Guarav", "Dogra", "Nikon") { Age = 32 };
        //Hunter h2 = new Hunter("Concalo", "Nunies", "Leica") { Age = 26 };
        //Console.WriteLine(h.Age);
        //Console.WriteLine(h.Shoot());

        //Console.WriteLine(h2.GetHashCode());
        //Console.WriteLine(h2.GetType());
        //Console.WriteLine(h2.Equals(h));
        //Console.WriteLine(h2.ToString());

        //var rec1 = new Rectangle(10, 10);
        //Rectangle rec2 = new Rectangle(11, 2);
        //Shape rec3 = new Rectangle(7, 4);
        //Object rect4 = new Rectangle(9, 2);

        //Console.WriteLine(rec3.CalculateArea());
        //Console.WriteLine(rec2.CalculateArea());

        //var arrRect = new Shape[] {rec1,rec2, rec3};
        //var arrRect = new Object[] { rec1, rec2, rec3, rect4 };
        // rect4 is object and don't have shape stuff, runtime polymorphisma
        //foreach (Shape shape in arrRect)
        //{
        //    Console.WriteLine(shape.CalculateArea());
        //}
        //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        //a.Ascend(500);
        //Console.WriteLine(a.Move(3));
        //Console.WriteLine(a.Position + " pos");
        //Console.WriteLine(a);
        //a.Descend(200);
        //Console.WriteLine(a.Move());
        //a.Move();
        //Console.WriteLine(a);

        //Airplane b = new Airplane(120);
        //b.Ascend(100);
        //Console.WriteLine(b.ToString());
        //b.Move();
        //Console.WriteLine(b.ToString());
        #endregion

        #region Polymorphism 
        //List<Object> gameOBJ = new List<Object>()
        //{
        //    new Person("Nish", "Mandal"){Age = 32},
        //    new Airplane(400,200, "Boeing"),
        //    new Vehicle(12,20),
        //    new Hunter("Hunter", "McHunty", "Pentax")
        //};

        //foreach (var obj in gameOBJ)
        //{
        //    Console.WriteLine(obj);
        //}

        //Run-time polymorphism (override). Method overloading is a type of complie time polymorphism
        //Person yolanda = new("Yolanda", "Young");
        //SpartaWrite(yolanda);

        //var a = new Person("Nish", "Mandal") { Age = 32 };
        //var b = new Hunter("Hunter", "McHunty", "Pentax");
        //SpartaWrite(a);
        //upcasting from hunter(derived) to Person(base)
        //var c = (Person)b;
        //SpartaWrite(c);
        //downcasting // cannot cast the base class(Person) to it's derived class (Hunter) 
        //var d is null becasue we can't downcast
        //var d = a as Hunter;
        //SpartaWrite(d);

        List<iMovalbe> gameOBJ = new List<iMovalbe>()
        {
            new Person("Nish", "Mandal"){Age = 32},
            new Vehicle(12,20),
            new Hunter("Hunter", "McHunty", "Pentax")
        };
        foreach (iMovalbe obj in gameOBJ)
        {
            Console.WriteLine(obj.Move());
            Random rand = new Random();
            int x = rand.Next(2, 9);
            Console.WriteLine(obj.Move(x));
        } 

        #endregion

    }

    public static void SpartaWrite(Object obj)
    {
        //if (obj is Person)
        //{
            Console.WriteLine("Per: " +obj.ToString());
        //}
        if (obj is Hunter)
        {
            var hunterObj = (Hunter)obj;
            Console.WriteLine("Hun: " + hunterObj.Shoot());
        }
    
    }

    static void DemoMethod(Person p, Stuct3D pt)
    {
        pt.y = 1000;
        p.Age = 92;
    }
}
