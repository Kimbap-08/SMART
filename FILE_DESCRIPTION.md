# SMART Project File Description

This document describes the source and support files that make up the S.M.A.R.T. (Student Management and Academic Records Tracking) Windows desktop application. Build output and temporary files under bin/, obj/, and output/ are generated and are not source files.

## Application entry point and model

- Program.cs – Starts the Windows Forms application and opens the login form.
- Models/User.cs – Defines user roles, the signed-in user model, and the shared current-session user.
- Properties/Resources.Designer.cs – Generated resource accessor used to load images and other embedded resources. It is generated from Properties/Resources.resx.

## Data access

- Data/DatabaseConnection.cs – Creates and manages the SQL Server LocalDB connection, including connection recovery.
- Data/InstructorAccountSchema.cs – Creates and migrates the instructor account table and its login-related columns.
- Data/CourseRepository.cs – Reads and writes course, instructor-assignment, and enrollment data.
- Data/ExamRepository.cs – Reads and writes exam and term-related records used by instructor course tools.

## Services

- Services/AuthService.cs – Authenticates administrator and instructor accounts and checks whether an instructor account is enabled.
- Services/Passwordhasher.cs – Hashes and verifies account passwords.
- Services/PhotoHelper.cs – Loads, prepares, and saves profile-photo images.

## Authentication UI

- UI/Authentication/Login.cs – Implements the login form behavior and presentation.
- UI/Authentication/Login.auth.cs – Handles login submission, credential checks, and navigation to the appropriate application panel.
- UI/Authentication/Login.Designer.cs – Generated Windows Forms control declarations and layout for the login form.

## Administrator UI

- UI/Admin/AdminUI.cs – Main administrator window and navigation between administrative screens.
- UI/Admin/AdminUI.Designer.cs – Generated layout and controls for the administrator window.
- UI/Admin/AdminDashboard.cs – Displays administrator dashboard summaries and statistics.
- UI/Admin/AdminDashboard.Designer.cs – Generated dashboard layout and controls.
- UI/Admin/AdminStudents.cs – Manages student records.
- UI/Admin/AdminStudents.Designer.cs – Generated layout and controls for student management.
- UI/Admin/AdminInstructors.cs – Manages instructor records and account status.
- UI/Admin/AdminInstructors.Designer.cs – Generated layout and controls for instructor management.
- UI/Admin/AdminCourses.cs – Manages courses and their assigned instructors, schedule, room, and term.
- UI/Admin/AdminCourses.Designer.cs – Generated layout and controls for course management.
- UI/Admin/AdminEnrollment.cs – Manages student course enrollment.
- UI/Admin/AdminEnrollment.Designer.cs – Generated layout and controls for enrollment management.
- UI/Admin/AdminPanelLayout.cs – Shared helpers for laying out administrator panels and toolbars.
- UI/Admin/AnnouncementsAdmin.cs – Lets administrators create and manage announcements.
- UI/Admin/InboxControl.cs – Displays and manages messages or help requests sent through Assist.
- UI/Admin/InstructorCredentialsDialog.cs – Dialog for viewing or managing instructor login credentials.

## Instructor UI

- UI/Instructor/InstructorUI.cs – Main instructor window, dashboard, and navigation among instructor features.
- UI/Instructor/InstructorUI.Designer.cs – Generated layout and controls for the instructor window.
- UI/Instructor/InstructorTheme.cs – Stores and applies instructor display-theme preferences.
- UI/Instructor/InstructorSettingsDestination.cs – Defines the settings destinations used by instructor navigation.
- UI/Instructor/InstructorSettings.cs – Settings screen and navigation to its subpages.
- UI/Instructor/InstructorSettings.Designer.cs – Generated settings-screen layout and controls.
- UI/Instructor/InstructorProfileSettings.cs – Updates instructor profile details, password, and profile photo.
- UI/Instructor/InstructorProfileSettings.Designer.cs – Generated profile-settings layout and controls.
- UI/Instructor/InstructorDisplaySettings.cs – Manages display preferences such as theme settings.
- UI/Instructor/InstructorDisplaySettings.Designer.cs – Generated display-settings layout and controls.
- UI/Instructor/InstructorSchedule.cs – Shows the signed-in instructor’s courses in a weekly schedule, filtered by selected term and days.
- UI/Instructor/InstructorCalendar.cs – Displays calendar dates and course or academic events.
- UI/Instructor/InstructorCalendar.Designer.cs – Generated calendar layout and controls.
- UI/Instructor/InstructorCourses.cs – Instructor course workspace, including course-related attendance, quiz, exam, and report tools.
- UI/Instructor/InstructorNotes.cs – Provides instructor notes and note-management features.
- UI/Instructor/InstructorAssist.cs – Provides the instructor messaging/help-request interface.
- UI/Instructor/InstructorAnnouncements.cs – Displays announcements to instructors.
- UI/Instructor/InstructorAnnouncements.Designer.cs – Generated announcements layout and controls.
- UI/Instructor/InstructorAnnouncementCard.cs – User control for presenting one announcement as a card.
- UI/Instructor/InstructorAnnouncementCard.Designer.cs – Generated announcement-card layout and controls.
- UI/Instructor/InstructorAnnouncementDetailsDialog.cs – Shows the full details of a selected announcement.
- UI/Instructor/InstructorAnnouncementDetailsDialog.Designer.cs – Generated announcement-details dialog layout and controls.

## Shared controls

- UI/Controls/CenteredLoginControls.cs – Helpers for centering and positioning login controls.
- UI/Controls/CustomButton.cs – Custom styled button controls used by the interface.
- UI/Controls/CustomFlowLayoutPanel.cs – Custom flow-layout panel used to arrange controls.
- UI/Controls/CustomPanel.cs – Custom panel drawing and styling helpers.
- UI/Controls/CustomTextbox.cs – Custom styled text-box control.
- UI/Controls/StableScrollPanels.cs – Panel helpers for more stable scrolling and flow-layout behavior.
- UI/Controls/ThemeUpdateScope.cs – Groups theme updates to reduce intermediate redraws.
- UI/Controls/TranslucentBackgroundPanel.cs – Panel that paints a translucent background image.
- UI/Controls/TranslucentSidebarPanel.cs – Sidebar panel with translucent background rendering.

## Legacy UI

- UI/Legacy/Courses.cs – Retained older course user-control implementation; it is not the current instructor course screen.
- UI/Legacy/Form1.cs – Retained older application form. The project file excludes this form from the active build.
- UI/Legacy/Form1.Designer.cs – Generated layout for the legacy form; excluded from the active build with Form1.cs.

## Resource files

Windows Forms .resx files hold form/control resources such as images, icons, and localized or serialized UI values. Designer-associated resources are embedded in the application by the project.

- Properties/Resources.resx – Shared application resources used by Properties/Resources.Designer.cs.
- UI/Admin/AdminCourses.resx, UI/Admin/AdminDashboard.resx, UI/Admin/AdminEnrollment.resx, UI/Admin/AdminInstructors.resx, UI/Admin/AdminStudents.resx, and UI/Admin/AdminUI.resx – Resources for the corresponding administrator forms.
- UI/Admin/AnnouncementsAdmin.resx and UI/Admin/InboxControl.resx – Resources for the administrator announcements and inbox controls.
- UI/Authentication/Login.resx – Resources for the login form.
- UI/Controls/CustomTextbox.resx – Resources for the custom text box.
- UI/Instructor/InstructorAnnouncementCard.resx, UI/Instructor/InstructorAnnouncementDetailsDialog.resx, UI/Instructor/InstructorAnnouncements.resx, and UI/Instructor/InstructorUI.resx – Resources for the instructor announcement and main-window UI.
- UI/Instructor/InstructorAssist.resx, UI/Instructor/InstructorCalendar.resx, and UI/Instructor/InstructorCourses.resx – Resources for the instructor Assist, calendar, and course screens.
- UI/Instructor/InstructorDisplaySettings.resx, UI/Instructor/InstructorProfileSettings.resx, and UI/Instructor/InstructorSettings.resx – Resources for instructor settings screens.
- UI/Legacy/Courses.resx and UI/Legacy/Form1.resx – Resources for legacy UI; the legacy form resource is excluded from the active build.
- Root-level AssistControl.resx, InstructorAnnouncementDetailsDialog.resx, InstructorCredentialsDialog.resx, and ScheduleControl.resx – Standalone resource files currently present at the repository root. They are not mapped as active UI resources in SMART.csproj; similarly named UI resources are located in their respective folders.
- UI/Admin/InstructorCredentialsDialog.resx – Resource file alongside the administrator instructor-credentials dialog.

## Database scripts and project setup

- SQLQuery1.sql – SQL Server script for setting up the SMART database tables used by the application. Review its statements before running it against an existing database.
- SQLQuery2.sql – SQL Server script for creating or updating SMART database structures and related records.
- SMARTdb_Setup.sql – Repeatable SQL Server LocalDB setup and migration script for the SMART database, including student, instructor, course, enrollment, attendance, assessment, and related tables.
- DATABASE_SETUP.md – Database prerequisites and instructions for configuring the local database.
- COLLABORATOR_SETUP.md – Setup notes for collaborators opening and building the project.
- SMART.sln – Visual Studio solution that groups the application project.
- SMART.csproj – .NET Windows Forms project settings, source/resource inclusion rules, and package references.

Designer files are generated by Visual Studio’s Windows Forms designer. The application logic is generally in the matching .cs file without the .Designer suffix.
