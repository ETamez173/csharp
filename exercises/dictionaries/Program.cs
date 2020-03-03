using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {

            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();

            // Add several more words and their definitions
            wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add ("Groovy", "The favorite word of students when their code compiles without hitches");
            wordsAndDefinitions.Add ("Neat", "The look of NSS students when they are on an interview");
            wordsAndDefinitions.Add ("Amazing", "The feeling when and NSS students gets a job offer");
            wordsAndDefinitions.Add ("Releaved", "The feeling of students when they finish their Capstone");
            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {

            //     Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Awesome"]);
            //     Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Groovy"]);
            //     Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Neat"]);
            //     Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Amazing"]);
            //     Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Releaved"]);

            // }
            // Console.WriteLine ();

            Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Awesome"]);
            Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Groovy"]);
            Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Neat"]);
            Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Amazing"]);
            Console.WriteLine ("Value is==>:{0}", wordsAndDefinitions["Releaved"]);

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
                Console.WriteLine ("{0} = {1}",
                    word.Key, word.Value);
            }
            Console.WriteLine ();

            // Console.WriteLine (wordsAndDefinitions[0])

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
                Console.WriteLine ($"The definition of {word.Value} is {word.Key}");
            }
            // Console.WriteLine ("Hello World!");

        }
    }
}