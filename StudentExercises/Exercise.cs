using System;

namespace StudentExcercises {
    // You must define a type for representing an exercise in code. 
    // An exercise can be assigned to many students.

    public class Excercise {

        // Name of exercise
        public string ExcerciseName { get; set; }
        // Language of exercise (JavaScript, Python, CSharp, etc.)
        public string ExcerciseLanguage { get; set; }
    }
}