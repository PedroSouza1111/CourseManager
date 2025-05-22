namespace CourseManager.Core.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected string Email { get; set; }
        private string Password { get; set; }

        public void SetEmail(string email) => Email = email;
        public void SetPassword(string password) => Password = password;

        public abstract string GetRole();
    }

    public class Student : User
    {
        public string RegistrationNumber { get; set; }
        public override string GetRole() => "Student";
    }

    public class Instructor : User
    {
        public string Specialty { get; set; }
        public override string GetRole() => "Instructor";
    }
}