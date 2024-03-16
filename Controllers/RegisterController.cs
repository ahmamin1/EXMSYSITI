using ExaminationSys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Controllers
{
    public class RegisterController
    {
        private readonly ExamDbContext _context = new();
        /// <summary>
        /// Registers a new user in the system.
        /// </summary>
        /// <typeparam name="T">The type of user to register.</typeparam>
        /// <param name="newUser">The user object to register.</param>
        /// <returns>True if registration is successful; otherwise, false.</returns>
        public bool RegisterUser<T>(T newUser) where T : User
        {
            try
            {
                _context.Set<T>().Add(newUser);
                _context.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred during registration: {ex.Message}");
                return false;
            }
        }
    }
}
