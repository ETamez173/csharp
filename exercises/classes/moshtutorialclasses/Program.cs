using System;

namespace moshtutorialclasses {

    // Create a class here 
    public class Person {

        // define a field for the the class
        public string Name;
        // create a Method called introduce
        // pass a parameter that is the name of the person they are being introduced to
        public void Introduce (string to) {
            // The 0 and the 1 are parameters and the Name is the name stored in the class
            // the 0 relates to the "to" and the 1 relates to the Name
            // this is a format string that is like a template
            Console.WriteLine ("Hi {0}, I am {1}", to, Name);

        }

        // a Parse method should take string and retrun an obect for the new person
        // the parse method is an instance method which means 

        ///
        public static Person Parse (string str) {
            var person = new Person ();
            person.Name = str;

            return person;

        }

    }
    class Program {
        static void Main (string[] args)

        {
            // create an object here
            // Person person = new Person();

            // this was first approach that created a new object 
            // var person = new Person ();
            // person.Name = "John";

            // this is using static memebr vs creating and new object then running the logic
            var person = Person.Parse ("John");
            person.Introduce ("Mosh");

        }

    }
}