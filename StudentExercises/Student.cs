// You must define a type for representing a student in code.
// A student can only be in one cohort at a time.
// A student can be working on many exercises at a time.

using System;
using System.Collections.Generic;

namespace StudentExercises
{

    // Properties

    public class Student
    {
        public string FirstName { get; set; }
        // Last name
        public string LastName { get; set; }
        // Slack handle
        public string SlackHandle { get; set; }
        // The student's cohort
        public Cohort Cohort { get; set; }

        // The collection of exercises that the student is currently working on
        // public string StudentCollectionOfExcercises { get; set; }
        public List<Exercise> StudentCollectionOfExercises = new List<Exercise>();

        public void AddExerciseToStudent(Exercise exercise)

        {

            StudentCollectionOfExercises.Add(exercise);
        }

        ///////

        // Constructor
        /// Constructor is particular type of Method, doesnt have a return type
        /// name of method is same as the name of the class
        /// this is the method that will run when ever I say "new" Student and actually make a student
        public Student(string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        public void Description()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
            Console.WriteLine($"Slack Handle: {this.SlackHandle}");
            Console.WriteLine($"Cohort: {this.Cohort.Name}");
            foreach (Exercise exercise in this.StudentCollectionOfExercises)
            {
                Console.WriteLine($"Currently working on {exercise.ExerciseName}");
            }
            Console.WriteLine($"-------------------");
        }

    }
}