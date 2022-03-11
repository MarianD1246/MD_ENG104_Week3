using System;
using System.Collections.Generic;

namespace ObjectComparison_Collections;

class Program
{
    public static void Main(string[] args)
    {
        #region Comparing objects
        //var bobOne = new Person("Bob", "Builder") { Age = 25 };
        //var bobTwo = bobOne;
        //var areSmae = bobOne.Equals(bobTwo);
        //var bobThree = new Person("Bob", "Builder") { Age = 25 };
        //var areSameOneTree = bobOne.Equals(bobThree);

        //List<Person> personList = new List<Person>
        //{
        //    new Person("Cath", "Cookson"),
        //    new Person("Bob", "Builder") { Age = 25 },
        //    new Person("Dan", "Dare") { Age = 25},
        //    new Person("Amy", "Alison") { Age = 32 },
        //    new Person("Amy", "Builder") { Age = 35 },
        //    new Person("Bob", "Andrew") { Age = 35 }
        //};

        //var hasBob = personList.Contains(bobOne);
        //Console.WriteLine(hasBob);

        //Console.WriteLine();
        //personList.Sort();
        //personList.ForEach(x => Console.WriteLine(x));

        //Console.WriteLine();
        //personList.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x));
        #endregion

        #region Collections
        //using using System.Collections.Generic; to get access to collection 
        var helen = new Person("Helen", "Trop") { Age = 22 };
        var will = new Person("William", "Shakespeare") { Age = 422 };
        List<Person> thePeople = new List<Person> { helen, will };
        thePeople.Add(new Person("Nish", "Mandal"));
        ///using System.Collections // legacy code for collections / old code / bad to use with new code /performance issues not recomended by Microsoft
        //System.Collections.ArrayList al = new System.Collections.ArrayList() { 1, "Hello", helen };    
        //foreach (var item in al)
        //{
        //    Console.WriteLine(item);
        //}
        ///List's vast functinality
        //Person[] arr = thePeople.ToArray();
        //var numList = new List<int>() { 5,4,3,9,0 };

        //numList.Add(8);
        //numList.Sort();
        //numList.RemoveRange(1, 2);
        //numList.Insert(2, 1);
        //numList.Reverse();
        //numList.Remove(9);
        //Console.WriteLine(string.Format("({0}).", string.Join(", ", numList)));

        ///Linked Lists!
        //LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
        //thePeopleLinked.AddFirst(helen);
        //thePeopleLinked.AddFirst(will);
        //thePeopleLinked.AddLast(new Person("Nish", "Mandal"));

        //foreach (var person in thePeopleLinked)
        //{
        //    Console.WriteLine(person);
        //}

        ///Queses
        //First in first out (fifo)
        //printers use queues 

        //var myQueue = new Queue<Person>();
        //myQueue.Enqueue(helen);
        //myQueue.Enqueue(will);
        //myQueue.Enqueue(new Person("Jab", "Khan"));

        //foreach (var item in myQueue)
        //{
        //    Console.WriteLine(item);
        //}

        //var first = myQueue.Peek();
        //var serve = myQueue.Dequeue();//who has been removed in the que
        //foreach (var item in myQueue)
        //{
        //    Console.WriteLine(item);
        //}

        ///Stacks
        //Last in first out
        //the undo button uses stacks to remove the last added item

        //int[] original = new int[]{ 1, 2, 3, 4, 5 };
        //int[] reversed = new int[ original.Length ];
        //var stack = new Stack<int>();

        //foreach(var n in original)
        //{
        //    stack.Push(n); //push down 1,2,3,4 then 5
        //}
        ////pop off the stack the top chair, which will continue unitl our array if full
        //for (int i = 0; i < original.Length; i++)
        //{
        //    reversed[i] = stack.Pop();
        //}

        ///HasHSet
        //no dupicate people, you are eitehr in a has set or our of it
        //items are accessed by hascode, it is fast to access them
        //var peopleSet = new HashSet<Person>
        //{
        //    helen, 
        //    new Person("Jasmin", "Mandal"),
        //    new Person("Andrei", "Aggassi")
        //};

        //var succesMartan = peopleSet.Add(new Person("Martin", "Beard"));
        //var SuccessHelen = peopleSet.Add(new Person("Helen", "Troy") { Age = 22}); //already have item in line 40 
        //Console.WriteLine(succesMartan + "<-Martin || Helen-> " + SuccessHelen);

        //var morePPl = new HashSet<Person>()
        //{
        //    new Person("Cathy", "French"), new Person("Jasmin", "Mandal")
        //};
        //peopleSet.IntersectWith(morePPl);
        //foreach(Person person in thePeople)
        //{
        //    Console.WriteLine(person);
        //}

        ///Dictionaries
        //A Collection of key value pair, 
        //var personDict = new Dictionary<string, Person>()
        //{
        //    {"helen", helen},
        //    {"sherlock", new Person("Sherlock", "Homes"){Age = 40} }
        //};

        //Person p = personDict["sherlock"]; // insdead of index we use the key
        //Console.WriteLine(p);

        //string input = "The car in the hat comes back";
        //input = input.Trim().ToLower();
        //var countDict = new Dictionary<char, int>();
        //foreach (char c in input)
        //{
        //    if (!countDict.ContainsKey(c))
        //    {
        //        countDict.Add(c, 1);
        //    }
        //    else if (countDict.ContainsKey(c))
        //    {
        //        countDict[c]++;
        //    }
        //}
        //foreach(KeyValuePair<char,int> keyPair in countDict)
        //{
        //    Console.WriteLine(keyPair);
        //}

        //var theBeatles = new Dictionary<int, string>() { { 1, "Jhon" }, { 2, "Paul" }, { 3, "Ringo" }, { 4, "George" } };

        //var isAdded = theBeatles.TryAdd(3, "Nish"); //is false because key 3 is defined
        //var beatlesList = theBeatles.Values.ToList();
        //var c = theBeatles.Remove(1);
        //var d = theBeatles.Keys.Where(x => x % 2 == 0).Sum();
        #endregion
        //string b = "Attb";
        //Console.WriteLine(b.ToLower()[0]);
        //if (b.ToLower()[0] == 'a')
        //{
        //    Console.WriteLine(b);
        //}

        Console.WriteLine(0/6);
    }
}


