using System.Collections.Generic;

namespace studentexerciselinq
{
    public class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}