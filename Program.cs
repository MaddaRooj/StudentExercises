using StudentExercises.Models;
using System;
using System.Collections.Generic;
using StudentExercises.Data;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            List<Students> students = repository.GetAllStudents();
            PrintDepartmentReport("All Students:", students);
            Pause();

            List<Exercises> exercises = repository.GetAllExercises();
            PrintExercisesReport("All Exercises:", exercises);
            Pause();

            List<Exercises> exercisesJS = repository.GetAllJSExercises();
            PrintExercisesReport("All Exercises using Javascript:", exercisesJS);
            Pause();

            Exercises new1 = new Exercises
            {
                ExerciseName = "Ternary Traveler",
                ExerciseLanguage = "Javascript"
            };
            repository.AddExercise(new1);
            exercises = repository.GetAllExercises();
            PrintExercisesReport("All Exercises after adding Ternary Traveler", exercises);
            Pause();

            Exercises dltExercise = exercises.First(e => e.ExerciseName == "Ternary Traveler");
            repository.DeleteExercise(dltExercise.Id);
            exercises = repository.GetAllExercises();
            PrintExercisesReport("All Exercises after deleting Ternary Traveler", exercises);
            Pause();

            List<Instructors> instructors = repository.GetAllInstructors();
            PrintInstructorsReport("All Instructors:", instructors);
            Pause();

            List<Cohorts> cohorts = repository.GetAllCohorts();
            PrintCohortsReport("All Cohorts:", cohorts);
            Pause();

        }
        public static void PrintDepartmentReport(string title, List<Students> students)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id}. {s.FirstName} {s.LastName}");
            };
        }

        public static void PrintExercisesReport(string title, List<Exercises> exercises)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------");
            foreach (var ex in exercises)
            {
                Console.WriteLine($"{ex.Id}. {ex.ExerciseName} - {ex.ExerciseLanguage}");
            };
        }

        public static void PrintInstructorsReport(string title, List<Instructors> instructors)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------");
            foreach (var i in instructors)
            {
                Console.WriteLine($"{i.Id}. {i.FirstName} {i.LastName} - Special Attack ({i.SpecialAttack})");
            };
        }

        public static void PrintCohortsReport(string title, List<Cohorts> cohorts)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------");
            foreach (var c in cohorts)
            {
                Console.WriteLine($" {c.CohortName}");
            };
        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
