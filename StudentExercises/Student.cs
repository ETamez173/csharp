// You must define a type for representing a student in code.
// A student can only be in one cohort at a time.
// A student can be working on many exercises at a time.

using System;
using System.Collections.Generic;

namespace StudentExcercises {

    // Properties
    // First name
    public class Student {
        public string FirstName { get; set; }
        // Last name
        public string LastName { get; set; }
        // Slack handle
        public string SlackHandle { get; set; }
        // The student's cohort
        public int Cohort { get; set; }
        // The collection of exercises that the student is currently working on
        // public string StudentCollectionOfExcercises { get; set; }
        public List<Excercise> StudentCollectionOfExcercises = new List<Excercise> ();

        public void AddExcerciseToStudent (Excercise excercise)

        {

            StudentCollectionOfExcercises.Add (excercise);
        }

        // public string

    }
}