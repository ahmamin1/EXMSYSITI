using ExaminationSys.Models;
using System.Linq;

namespace ExaminationSys.Controllers
{
    internal class LoginController
    {
        private readonly ExamDbContext dbContext = new();

        /// <summary>
        /// Authenticates a user based on the provided credentials.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="role">The role of the user (student, teacher, or admin).</param>
        /// <returns>True if the user is authenticated; otherwise, false.</returns>
        public bool AuthenticateUser(string username, string password, string role)
        {
            switch (role.ToLower())
            {
                case "student":
                    return dbContext.Students.Any(s => s.Username == username && s.Password == password);
                case "teacher":
                    return dbContext.Teachers.Any(t => t.Username == username && t.Password == password);
                case "admin":
                    return dbContext.Admins.Any(a => a.Username == username && a.Password == password);
                default:
                    return false;
            }
        }


    }
}
