# Running SMART with a separate local database

Each collaborator runs SMART against their own database on their own Windows PC. Student records and user accounts do not sync between computers.

## Prerequisites

- Windows with the .NET 9 Windows Desktop Runtime (or the .NET 9 SDK to build from source).
- SQL Server LocalDB, installed with Visual Studio or the SQL Server Express LocalDB installer.
- SQL Server Data Tools for Visual Studio, for SQL Server Object Explorer. If it is missing, open Visual Studio Installer, choose Modify, and select SQL Server Data Tools and SQL Server Express LocalDB under Individual components.
- The SMART source repository.

## Create the local database using Visual Studio

1. Open `SMART.sln` in Visual Studio.
2. Open **View > SQL Server Object Explorer**.
3. Expand **SQL Server** and connect to `(localdb)\MSSQLLocalDB`. If it is not listed, use **Add SQL Server**, enter that server name, and use Windows Authentication.
4. Right-click the connected server and choose **New Query**.
5. Copy the entire contents of `SQLQuery2.sql` into the query window and click **Execute**. The script creates `SMARTdb`, `dbo.Students`, and `dbo.Instructors` if they do not already exist. There is no need to create the database manually.
6. Refresh **Databases** and expand **SMARTdb > Tables** to check that both tables exist.
7. Run the application from Visual Studio.

Each collaborator performs these steps on their own PC. Everyone uses the same database name, but each database starts empty and stores that person's own records. SSMS and a copy of another collaborator's database files are not required.

The application uses this LocalDB connection on each PC:

```text
Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;
```

## Accounts

SMART creates its account database separately on first run under `%LOCALAPPDATA%\SMART\smart.db`. That SQLite file is private to the Windows user and is not shared or synchronized. The first run creates the default admin account `admin` with password `admin12345`; sign in and change that password before using the account. Instructor accounts are created through the app's sign-up screen.

## If you want collaborators to start with the same records

The checked-in SQL script creates the schema, not a copy of your current data. To share sample records, provide a seed script containing INSERT statements with fictional student and instructor data. Collaborators can run it through Visual Studio's query window against their own `SMARTdb`. Do not put real student information or passwords in the source repository. Each person's later edits remain local to their own PC.

## Troubleshooting

- If connecting to `(localdb)\MSSQLLocalDB` fails, install SQL Server LocalDB and retry.
- If the app reports that `Students` does not exist, run `SQLQuery2.sql` against `(localdb)\MSSQLLocalDB`.
- Do not copy a live `.mdf` or `.ldf` file while SQL Server has it open. Use a SQL Server backup/restore or export/import instead.
