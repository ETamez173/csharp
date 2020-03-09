using System;
using System.Collections.Generic;

namespace StudentExercises
{
    // You must define a type for representing an exercise in code. 
    // An exercise can be assigned to many students.

    public class Exercise
    {

        // Name of exercise
        public string ExerciseName { get; set; }
        // Language of exercise (JavaScript, Python, CSharp, etc.)
        public string ExerciseLanguage { get; set; }

        // Constructor
        /// Constructor is particular type of Method, doesnt have a return type
        /// name of method is same as the name of the class
        /// this is the method that will run when ever I say "new" Exercise and actually make an Exercise
        public Exercise(string name, string language)
        {
            ExerciseName = name;
            ExerciseLanguage = language;

        }
    }
}