using System;

namespace StudentExercises
{

    // Properties

    public class Instructor
    {
        // First name
        public string FirstName { get; set; }
        // Last name
        public string LastName { get; set; }
        // Slack handle
        public string SlackHandle { get; set; }
        // The instructor's cohort
        public Cohort Cohort { get; set; }
        //The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
        public string IntructorSpecialty { get; set; }
        // A method to assign an exercise to a student
        // this method takes an argument/parameter

        public void assignExercise(Exercise exercise, Student student)
        {
            student.StudentCollectionOfExercises.Add(exercise);
        }

        // Constructor for the Instructor
        /// Constructor is particular type of Method, doesnt have a return type
        /// name of method is same as the name of the class
        /// this is the method that will run when ever I say "new" Instructor and actually make an Instructor
        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohort, string intructorSpecialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            IntructorSpecialty = intructorSpecialty;
        }

    }

}