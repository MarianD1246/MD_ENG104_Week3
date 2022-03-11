using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using AdvancedNUnit;

//unit test need to be isolated as they don't run in any particular order
//test methods should not depend in other test methods
namespace AdvancedNUnit
{
    //[TestFixture(1,3)]
    //can create an object and use it to set particular values for multiple test 
    public class CalculatorTests
    {

        ///e.g
        //private int _num1;
        //private int _num2;

        //[Test]
        //public void CalcTextFictureTests(int num1, int num2)
        //{
        //    num1 = _num1;
        //    num2 = _num2;
        //}
        ///This is not very common

        //[SetUp] // run before every other test methods
        //public void Setup() { }
        /// use [OneTimeSetUp] // runs once before running all the test methods
        //Used to initialised stuff, oppening connections/files/databased

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void SomeConstraints()
        {
            var subject = new Calculator { Num1 = 6 };
            Assert.That(subject.DivisibleBy3());
            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3(), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var strResult = subject.ToString();
            Assert.That(strResult, Does.Contain("Calculator"));
            Assert.That(strResult, Does.Not.Contain("Potato"));
            Assert.That(strResult, Is.Not.Empty);
            Assert.That(strResult, expression: Is.EqualTo("advancednunit.calculator").IgnoreCase);
        }

        [Test]
        public void TestListOfStrings()
        {
            var fruits = new List<string>()
            {
                "apple", "pear", "banana","peach"
            };
            Assert.That(fruits, Does.Contain("pear"));
            Assert.That(fruits, Has.Count.EqualTo(4));
            Assert.That(fruits, Has.Exactly(2).StartsWith("pea"));
        }

        [Ignore("Will Fail")]
        [Test]
        public void TestList_Classic()
        {
            var myList = new List<int>()
            {
                1, 2, 3
            };
            //old way to check if a int in list is 4
            Assert.AreEqual(1, myList.Where(x => x == 4).Count());
            //the code above fials, and it's hard to tell where it fails
        }

        [Ignore("Will Fail")]
        [Test]
        public void TestList_ConstraintModel()
        {
            var myList = new List<int>()
            {
                1, 2, 3
            };
            Assert.That(myList, Has.Exactly(1).EqualTo(4));
            //the code above fials,  but fail code is discriptive
            
        }

        [Test]
        public void TestRange()
        {
            Assert.That(3, Is.InRange(1, 10));
            var myList = new List<int>()
            {
                4, 2, 7, 5, 9
            };
            Assert.That(myList, Is.All.InRange(1, 10));
            Assert.That(myList, Has.Exactly(3).InRange(1, 5));
        }

        [TestCase(2,4,6)]
        [TestCase(-2, 3, 1)]
        public void Add_Always_Return_ExpectedResult(int x, int y, int expected)
        {
            var subject = new Calculator { Num1 = x, Num2 = y };
            Assert.That(subject.Add(), Is.EqualTo(expected));
        }

        private static object[] AddCases =
        {
            new int[] {2,4,6},
            new int[] {-2,3,1}
        };
        [TestCaseSource("AddCases")]
        public void UsingAddCases_Add_Always_Return_ExpectedResult(int x, int y, int expected)
        {
            var subject = new Calculator { Num1 = x, Num2 = y };
            Assert.That(subject.Add(), Is.EqualTo(expected));
        }

        //[TearDown] runs after each test done
        //[OneTimeTearDown] runts after everything is executed
        //- usefull for clearning data  & closing files/databaes/Connections
    }

}