using StudentExercises.Models;
using System;
using System.Collections.Generic;
using StudentExercises.Data;

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

            List<Instructors> instructors = repository.GetAllInstructors();
            PrintInstructorsReport("All Instructors:", instructors);
            Pause();

        }
        public static void PrintDepartmentReport(string title, List<Students> students)
        {
            Console.WriteLine(title);
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id}. {s.FirstName} {s.LastName}");
            };
        }

        public static void PrintExercisesReport(string title, List<Exercises> exercises)
        {
            Console.WriteLine(title);
            foreach (var ex in exercises)
            {
                Console.WriteLine($"{ex.Id}. {ex.ExerciseName} - {ex.ExerciseLanguage}");
            };
        }

        public static void PrintInstructorsReport(string title, List<Instructors> instructors)
        {
            Console.WriteLine(title);
            foreach (var i in instructors)
            {
                Console.WriteLine($"{i.Id}. {i.FirstName} {i.LastName} - Special Attack ({i.SpecialAttack})");
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
