# S.M.A.R.T. database setup

Include this file and `SMARTdb_Setup.sql` in the source-code ZIP.

## Requirements

- Windows with SQL Server Express LocalDB installed.
- SQL Server Management Studio (SSMS) or the `sqlcmd` command-line utility.
- Visual Studio with .NET desktop development and the .NET 9 SDK to run the app.

## Create the application database

1. Open SSMS and connect to `(localdb)\MSSQLLocalDB` using Windows Authentication.
2. Open `SMARTdb_Setup.sql` from this project.
3. Execute the entire script. It creates `SMARTdb`, its tables, and required indexes, and adds missing columns supported by the app.
4. Confirm that the final result says **SMARTdb is ready.**
5. Open the solution/project in Visual Studio, restore NuGet packages, and run it.

Alternatively, run this command from the project directory:

```powershell
sqlcmd -S "(localdb)\MSSQLLocalDB" -E -b -i "SMARTdb_Setup.sql"
```

The app uses `Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;`, defined in `Data/DatabaseConnection.cs`. If you use a different SQL Server instance, update that setting.

## Accounts and sample data

The project also uses a separate SQLite database for administrator authentication. `AuthService.Initialize()` creates it automatically at `%LOCALAPPDATA%\SMART\smart.db` when the app starts.

On a fresh account database, the app creates its existing demonstration administrator account: username `admin`, password `admin12345`. Change the demonstration credentials before any real deployment. Existing accounts are retained.

Use the Admin interface to add instructors, set their login credentials, add courses and students, and enroll students. Instructor accounts are stored in SQL Server. The SQL script does not copy your current records or account passwords. The app creates its configured exam templates and calendar holiday entries during normal initialization.

## Tables included

Students, Instructors, Courses, Enrollments, Attendance, Quizzes, QuizScores, Exams, ExamScores, Announcements, InstructorAnnouncementReads, Events, Notes, and AssistMessages.

## Existing databases

The script checks for existing tables and supported missing columns; it does not drop tables or delete records. It includes the app's existing normalization of older course terms and exam metadata. It is not a general migration tool for unrelated or incompatible table layouts. Back up an existing database before applying it.

For a submission containing your actual demonstration records, include a separate database backup or reviewed sample-data script in addition to this setup script.
