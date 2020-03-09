using System;
using System.Collections.Generic;

namespace StudentExercises
{
    // The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
    public class Cohort
    {

        public string Name { get; set; }

        // The collection of students in the cohort.
        public List<Student> Students = new List<Student>();

        public void addStudent(Student student)
        {
            Students.Add(student);
        }

        // The collection of instructors in the cohort.       
        public List<Instructor> Instructors = new List<Instructor>();

        public void addInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
        }
        /// Constructor is particular type of Method, doesnt have a return type
        /// name of method is same as the name of the class
        /// this is the method that will run when ever I say "new" Cohort and actually make a cohort
        public Cohort(string name)
        {
            Name = name;
        }
    }

}