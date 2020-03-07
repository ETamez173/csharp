using System;

namespace StudentExcercises {

    // Properties

    public class Intructor {
        // First name
        public string FirstName { get; set; }
        // Last name
        public string LastName { get; set; }
        // Slack handle
        public string SlackHandle { get; set; }
        // The instructor's cohort
        public Cohort Cohort {
            get;
            set;
        }
        //The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
        public string IntructorSpecialty { get; set; }
        // A method to assign an exercise to a student
        // this method takes an argument/parameter

        // create a lsit taht will hold the assigned exercises and the student
        // pass the student name and the exercise 
        public List<Excercise> StudentCollectionOfExcercises = new List<Excercise> ();

        public void AddExcerciseToStudent (Student student, Excercise excercise) {

            Student.StudentCollectionOfExcercises.Add (student, excercise, );
        }
        // public void AssignExercise (Student student, Excercise excercise) {
        //     Student = student;
        //     AssignedExcercise = excercise;

    }
}
// }