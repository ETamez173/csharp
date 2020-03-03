using System;
using System.Collections.Generic;

namespace listOfDictionaries {
    class Program {
        static void Main (string[] args) {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            // You want to track the following about each word:
            // word, definition, part of speech, example sentence
            //                 Example of one dictionary in the list:
            //     {
            //         "word": "excited",
            //         "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
            //         "part of speech": "adjective",
            //         "example sentence": "I am excited to learn C#!"
            //     }
            // */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

            excitedWord.Add ("word", "Awsome");
            excitedWord.Add ("definition", "The feeling of students when they are learning C#");
            excitedWord.Add ("part of speech", "Adjective");
            excitedWord.Add ("example sentence", "Students feel awsome when they learn C#");

            Dictionary<string, string> excitedWord2 = new Dictionary<string, string> ();

            // Add each of the 4 bits of data about the word to the Dictionary
            // excitedWord.Add();

            excitedWord2.Add ("word", "Groovy");
            excitedWord2.Add ("definition", "The favorite word of students when their code compiles without hitches#");
            excitedWord2.Add ("part of speech", "Adjective");
            excitedWord2.Add ("example sentence", "Man I feel Groovy when my code runs perfectly");

            //// Console.WriteLine ("Word > {0}  ", excitedWord["word"] + ", The definition: " + excitedWord["definition"] + ", Part of speech =>  " + excitedWord["part of speech"] + ", Use in a sentence => " + excitedWord["example sentence"]);
            //// Console.WriteLine ("Word > {0}  ", excitedWord2["word"] + ", The definition: " + excitedWord2["definition"] + ", Part of speech =>  " + excitedWord2["part of speech"] + ", Use in a sentence => " + excitedWord2["example sentence"]);

            dictionaryOfWords.Add (excitedWord);
            dictionaryOfWords.Add (excitedWord2);

            // create another Dictionary and add that to the list

            Dictionary<string, string> newWord = new Dictionary<string, string> ();

            newWord.Add ("word", "Neat");
            newWord.Add ("definition", "The look of NSS students when they are on an interview");
            newWord.Add ("part of speech", "Adjective");
            newWord.Add ("example sentence", "Students look Neat when they dress in interview clothes");

            //// Console.WriteLine ("Word > {0}  ", newWord["word"] + ", The definition: " + newWord["definition"] + ", Part of speech =>  " + newWord["part of speech"] + ", Use in a sentence => " + newWord["example sentence"]);

            dictionaryOfWords.Add (newWord);

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords) {

                // Iterate the KeyValuePairs of the Dictionary
                //     foreach (word) {
                //         Console.WriteLine ($"{word.Key}: {word.Value}");

                //    }

                //// Ask Adam for the better wayt to do this 

                foreach (KeyValuePair<string, string> wordData in excitedWord) {
                    Console.WriteLine ($"{wordData.Key}:{wordData.Value}");
                }

                foreach (KeyValuePair<string, string> wordData in excitedWord2) {
                    Console.WriteLine ($"{wordData.Key}:{wordData.Value}");
                }

                foreach (KeyValuePair<string, string> wordData in newWord) {
                    Console.WriteLine ($"{wordData.Key}:{wordData.Value}");
                }
            }

        }

    }
}