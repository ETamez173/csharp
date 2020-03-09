using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // create Exercise instances 
            Exercise Glassdale = new Exercise("Glassdale", "JavaScript");
            Exercise KandyKorner = new Exercise("KandyKorner", "React");
            Exercise Nutshell = new Exercise("Nutshell", "React.js");
            Exercise MartinsAquarium = new Exercise("Martin's Aquarium", "HTML");

            // create Cohort instances 
            Cohort Cohort36 = new Cohort("Evening Cohort 36");
            Cohort Cohort37 = new Cohort("Day Cohort 37");
            Cohort Cohort38 = new Cohort("Day Cohort 38");
            Cohort Cohort39 = new Cohort("Day Cohort 39");

            // create student intances 
            Student JohnGilliam = new Student("John", "Gilliam", "John Gilliam", Cohort37);
            Student HoldenParker = new Student("Holden", "Parker", "Holden Parker", Cohort37);
            Student WillyMetcalf = new Student("Willy", "Metcalf", "Willy Metcalf", Cohort37);
            Student JansenVanDerSpuy = new Student("Jansen", "van der Spuy", "Jansen van der Spuy", Cohort37);
            Student SpencerTruett = new Student("Spencer", "Truett", "Spencer Truett", Cohort37);
            Student JohnLong = new Student("John", "Long", "John Long", Cohort36);
            // add students to list of students
            Cohort37.addStudent(JohnGilliam);
            Cohort37.addStudent(HoldenParker);
            Cohort37.addStudent(WillyMetcalf);
            Cohort37.addStudent(JansenVanDerSpuy);
            Cohort37.addStudent(SpencerTruett);
            Cohort36.addStudent(JohnLong);
            // create instructor instances 
            Instructor SteveBrownlee = new Instructor("Steve", "Brownlee", "coach", Cohort37, "Dad Jokes");

            // assign exercises to student
            SteveBrownlee.assignExercise(Nutshell, JohnGilliam);
            SteveBrownlee.assignExercise(KandyKorner, HoldenParker);
            SteveBrownlee.assignExercise(MartinsAquarium, SpencerTruett);
            SteveBrownlee.assignExercise(Glassdale, JohnLong);
            SteveBrownlee.assignExercise(Glassdale, WillyMetcalf);
            SteveBrownlee.assignExercise(Nutshell, WillyMetcalf);

            Console.Clear();

            foreach (Student student in Cohort37.Students)
            {
                student.Description();
            }

            foreach (Student student in Cohort36.Students)
            {
                student.Description();
            }

        }
    }
}