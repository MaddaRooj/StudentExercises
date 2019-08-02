-- USE THIS DATA IN ORDER TO REPLICATE MY DATABASE
------------------------------------------------------------------

-- CREATE TABLE Cohorts (
--     Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--     Cohort_Name VARCHAR(55) NOT NULL,
-- );

-- CREATE TABLE Students (
--     Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--     FirstName VARCHAR(55) NOT NULL,
--     LastName VARCHAR(55) NOT NULL,
--     SlackHandle VARCHAR(55) NOT NULL,
--     Cohort_Id INT NOT NULL,
--     CONSTRAINT Student_Cohort FOREIGN KEY(Cohort_Id) REFERENCES Cohorts(Id)
-- );

-- CREATE TABLE Instructors (
--     Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--     FirstName VARCHAR(55) NOT NULL,
--     LastName VARCHAR(55) NOT NULL,
--     SlackHandle VARCHAR(55) NOT NULL,
--     Cohort_Id INT NOT NULL,
--     CONSTRAINT Instructor_Cohort FOREIGN KEY(Cohort_Id) REFERENCES Cohorts(Id),
--     SpecialAttack VARCHAR(55) NOT NULL
-- );

-- CREATE TABLE Exercises (
--     Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--     Exercise_Name VARCHAR(55) NOT NULL,
--     Exercise_Language VARCHAR(55) NOT NULL
-- );

-- CREATE TABLE Assigned_Exercises (
--     Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--     Student_Id INT NOT NULL,
--     Exercise_Id INT NOT NULL,
--     CONSTRAINT Student_Id FOREIGN KEY(Student_Id) REFERENCES Students(Id),
--     CONSTRAINT Exercise_Id FOREIGN KEY(Exercise_Id) REFERENCES Exercises(Id)
-- );

-- INSERT INTO Cohorts (Cohort_Name) VALUES ('Cohort 31');
-- INSERT INTO Cohorts (Cohort_Name) VALUES ('Cohort 32');
-- INSERT INTO Cohorts (Cohort_Name) VALUES ('Cohort 33');
-- INSERT INTO Cohorts (Cohort_Name) VALUES ('Cohort 34');

-- INSERT INTO Students (FirstName, LastName, SlackHandle, Cohort_Id ) VALUES ('Addam', 'Joor', 'addam.joor', 2);
-- INSERT INTO Students (FirstName, LastName, SlackHandle, Cohort_Id ) VALUES ('Emily', 'Loggins', 'emily.loggins', 2);
-- INSERT INTO Students (FirstName, LastName, SlackHandle, Cohort_Id ) VALUES ('Shelley', 'Arnold', 'shelley.arnold', 2);
-- INSERT INTO Students (FirstName, LastName, SlackHandle, Cohort_Id ) VALUES ('Heather', 'Cleland', 'heather.cleland', 2);
-- INSERT INTO Students (FirstName, LastName, SlackHandle, Cohort_Id ) VALUES ('Ben', 'Parker', 'ben.parker', 3);
-- INSERT INTO Students (FirstName, LastName, SlackHandle, Cohort_Id ) VALUES ('Ellie', 'Ash', 'ellie.ash', 4);

-- INSERT INTO Instructors (FirstName, LastName, SlackHandle, Cohort_Id, SpecialAttack ) VALUES ('Adam', 'Shaefer', 'hat.adam', 2, 'Hat Heard Round the World');
-- INSERT INTO Instructors (FirstName, LastName, SlackHandle, Cohort_Id, SpecialAttack ) VALUES ('Bryan', 'Nielson', 'bryan.nielson', 4, 'High Five Hurricane');
-- INSERT INTO Instructors (FirstName, LastName, SlackHandle, Cohort_Id, SpecialAttack ) VALUES ('Brenda', 'Long', 'brenda.long', 3, 'Positivity Overload');
-- INSERT INTO Instructors (FirstName, LastName, SlackHandle, Cohort_Id, SpecialAttack ) VALUES ('Jisie', 'David', 'jisie.david', 1, 'Snarky Smash');

-- INSERT INTO Exercises (Exercise_Name, Exercise_Language) VALUES ('Nashville Itinerary' , 'Javascript');
-- INSERT INTO Exercises (Exercise_Name, Exercise_Language) VALUES ('Bangazon' , 'C#/.NET');
-- INSERT INTO Exercises (Exercise_Name, Exercise_Language) VALUES ('Ternary Traveler' , 'Python');
-- INSERT INTO Exercises (Exercise_Name, Exercise_Language) VALUES ('Nutshell' , 'React');

-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (2, 1);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (2, 3);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (1, 2);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (1, 3);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (3, 3);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (3, 1);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (4, 4);
-- INSERT INTO Assigned_Exercises (Student_Id, Exercise_Id) VALUES (4, 2);