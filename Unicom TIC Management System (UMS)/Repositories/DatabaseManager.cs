using System;
using System.Data.SQLite;
using System.IO;

namespace UnicomTICManagementSystem.Repositories
{
    public static class DatabaseManager
    {
        private static readonly string dbFile = "unicomtic.db";
        private static readonly string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();

                string createUsersTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );";

                string createCoursesTable = @"
                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );";

                string createSubjectsTable = @"
                CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER,
                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                );";

                string createStudentsTable = @"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT NOT NULL,
                    NIC TEXT NOT NULL,
                    CourseID INTEGER,
                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                );";

                string createExamsTable = @"
                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    SubjectID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                );";

                string createMarksTable = @"
                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    ExamID INTEGER,
                    Score INTEGER,
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                );";

                string createRoomsTable = @"
                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL
                );";

                string createTimetablesTable = @"
                CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    TimeSlot TEXT NOT NULL,
                    RoomID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                    FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
                );";

                SQLiteCommand[] commands = new SQLiteCommand[]
                {
                    new SQLiteCommand(createUsersTable, connection),
                    new SQLiteCommand(createCoursesTable, connection),
                    new SQLiteCommand(createSubjectsTable, connection),
                    new SQLiteCommand(createStudentsTable, connection),
                    new SQLiteCommand(createExamsTable, connection),
                    new SQLiteCommand(createMarksTable, connection),
                    new SQLiteCommand(createRoomsTable, connection),
                    new SQLiteCommand(createTimetablesTable, connection)
                };

                foreach (var cmd in commands)
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


