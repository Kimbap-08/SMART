# Running SMART with a separate local database

Each collaborator runs SMART against their own database on their own Windows PC. Student records and user accounts do not sync between computers.

## Prerequisites

- Windows with the .NET 9 Windows Desktop Runtime (or the .NET 9 SDK to build from source).
- SQL Server LocalDB, installed with Visual Studio or the SQL Server Express LocalDB installer.
- The SMART source repository.

## Create the local student database

1. Open `SQLQuery2.sql` in SQL Server Management Studio (SSMS).
2. Connect to `(localdb)\MSSQLLocalDB` using Windows Authentication.
3. Execute the script. It creates the local `SMARTdb` database and `dbo.Students` table if they do not already exist. A new database starts with no student records.
4. Open `SMART.sln` in Visual Studio and run the application.

The application uses this LocalDB connection on each PC:

```text
Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;
```

## Accounts

SMART creates its account database separately on first run under `%LOCALAPPDATA%\SMART\smart.db`. That SQLite file is private to the Windows user and is not shared or synchronized. The first run creates the default admin account `admin` with password `admin12345`; sign in and change that password before using the account. Instructor accounts are created through the app's sign-up screen.

## If you want collaborators to start with the same records

The checked-in SQL script creates the schema, not a copy of your current student data. Export the rows you want to share from your own `SMARTdb` as INSERT statements (for example, with SSMS's **Generate Scripts** wizard) and provide that seed script privately to collaborators. They can run it against their own `SMARTdb`. Do not put real student information or passwords in the source repository. Each person's later edits remain local to their own PC.

## Troubleshooting

- If connecting to `(localdb)\MSSQLLocalDB` fails, install SQL Server LocalDB and retry.
- If the app reports that `Students` does not exist, run `SQLQuery2.sql` against `(localdb)\MSSQLLocalDB`.
- Do not copy a live `.mdf` or `.ldf` file while SQL Server has it open. Use a SQL Server backup/restore or export/import instead.
