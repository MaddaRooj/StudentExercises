using StudentExercises.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace StudentExercises.Data
{
    class Repository
    {
        public SqlConnection Connection
        {
            get
            {
                // This is "address" of the database
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentExercises;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }

        public List<Students> GetAllStudents()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // Here we setup the command with the SQL we want to execute before we execute it.
                    cmd.CommandText = @"SELECT Id, FirstName, LastName 
                                        FROM Students";

                    // Execute the SQL in the database and get a "reader" that will give us access to the data.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // A list to hold the students we retrieve from the database.
                    List<Students> students = new List<Students>();

                    // Read() will return true if there's more data to read
                    while (reader.Read())
                    {
                        // The "ordinal" is the numeric position of the column in the query results.
                        //  For our query, "Id" has an ordinal value of 0 and "FirstName" is 1.
                        int idColumnPosition = reader.GetOrdinal("Id");

                        // We user the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(idColumnPosition);

                        int firstNameColumnPosition = reader.GetOrdinal("FirstName");
                        string firstNameValue = reader.GetString(firstNameColumnPosition);

                        int lastNameColumnPosition = reader.GetOrdinal("LastName");
                        string lastNameValue = reader.GetString(lastNameColumnPosition);

                        // Now let's create a new student object using the data from the database.
                        Students student = new Students
                        {
                            Id = idValue,
                            FirstName = firstNameValue,
                            LastName = lastNameValue
                        };

                        // ...and add that student object to our list.
                        students.Add(student);
                    }

                    // We should Close() the reader. Unfortunately, a "using" block won't work here.
                    reader.Close();

                    // Return the list of students to who whomever called this method.
                    return students;
                }
            }
        }

        public List<Exercises> GetAllExercises()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, Exercise_Name, Exercise_Language
                                        FROM Exercises";

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Exercises> exercises = new List<Exercises>();

                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");

                        int idValue = reader.GetInt32(idColumnPosition);

                        int exerciseNameColumnPosition = reader.GetOrdinal("Exercise_Name");
                        string exerciseNameValue = reader.GetString(exerciseNameColumnPosition);

                        int exerciseLanguageNameColumnPosition = reader.GetOrdinal("Exercise_Language");
                        string exerciseLanguageValue = reader.GetString(exerciseLanguageNameColumnPosition);

                        Exercises exercise = new Exercises
                        {
                            Id = idValue,
                            ExerciseName = exerciseNameValue,
                            ExerciseLanguage = exerciseLanguageValue
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();

                    return exercises;
                }
            }
        }

        public List<Exercises> GetAllJSExercises()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, Exercise_Name, Exercise_Language
                                        FROM Exercises
                                        WHERE Exercise_Language = 'Javascript'";

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Exercises> exercises = new List<Exercises>();

                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");

                        int idValue = reader.GetInt32(idColumnPosition);

                        int exerciseNameColumnPosition = reader.GetOrdinal("Exercise_Name");
                        string exerciseNameValue = reader.GetString(exerciseNameColumnPosition);

                        int exerciseLanguageNameColumnPosition = reader.GetOrdinal("Exercise_Language");
                        string exerciseLanguageValue = reader.GetString(exerciseLanguageNameColumnPosition);

                        Exercises exercise = new Exercises
                        {
                            Id = idValue,
                            ExerciseName = exerciseNameValue,
                            ExerciseLanguage = exerciseLanguageValue
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();

                    return exercises;
                }
            }
        }

        public List<Instructors> GetAllInstructors()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, FirstName, LastName, SpecialAttack
                                        FROM Instructors";

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Instructors> instructors = new List<Instructors>();

                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");

                        int idValue = reader.GetInt32(idColumnPosition);

                        int firstNameColumnPosition = reader.GetOrdinal("FirstName");
                        string firstNameValue = reader.GetString(firstNameColumnPosition);

                        int lastNameColumnPosition = reader.GetOrdinal("LastName");
                        string lastNameValue = reader.GetString(lastNameColumnPosition);

                        int specialAttackColumnPosition = reader.GetOrdinal("SpecialAttack");
                        string specialAttackNameValue = reader.GetString(specialAttackColumnPosition);

                        Instructors instructor = new Instructors
                        {
                            Id = idValue,
                            FirstName = firstNameValue,
                            LastName = lastNameValue,
                            SpecialAttack = specialAttackNameValue
                        };
                        instructors.Add(instructor);
                    }
                    reader.Close();

                    return instructors;
                }
            }
        }
    }
}
