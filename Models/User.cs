namespace SMART
{
    public enum UserRole
    {
        Admin,
        Instructor
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }

    /// <summary>
    /// Remembers who is signed in. Set to null to sign out.
    /// </summary>
    public static class Session
    {
        public static User CurrentUser { get; set; }
    }
}