using DbModels;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Examination
{
    public enum UserType
    {
        Student,
        Teacher,
        Admin
    }
    public partial class registerform : Form
    {

        private UserType userType;
        private ExamDbContext dbContext;

        public registerform(UserType userType)
        {
            InitializeComponent();
            this.userType = userType;

            this.dbContext = new ExamDbContext();



        }

        public registerform()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerform_Load(object sender, EventArgs e)
        {

        }


            private void submit_Click(object sender, EventArgs e)
            {
                string name = frmuname.Text;
                string password = Password.Text;
                string confirmPassword = ConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate that password and confirm password match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hash the password before saving to the database 
                string hashedPassword = HashPassword(password);

                // Save user registration data to the database using the DbContext
                SaveUserData(name, hashedPassword);

                MessageBox.Show($"{userType} {name} registered successfully.");

                // Close the registration form
                this.Close();
            }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // Generate a random salt
                byte[] salt = new byte[16];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }

                // Combine password and salt, and hash using PBKDF2
                byte[] hashedPassword = KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 10000, 
                    numBytesRequested: 32); 

                // Combine salt and hashed password
                byte[] hashBytes = new byte[salt.Length + hashedPassword.Length];
                Array.Copy(salt, 0, hashBytes, 0, salt.Length);
                Array.Copy(hashedPassword, 0, hashBytes, salt.Length, hashedPassword.Length);

                // Convert the combined byte array to a base64 string
                string hashedPasswordBase64 = Convert.ToBase64String(hashBytes);

                return hashedPasswordBase64;
            }
        }
            private void SaveUserData(string username, string password)
            {
                switch (userType)
                {
                    case UserType.Student:
                        // Save student registration data
                        var student = new Student
                        {
                            Username = username,
                            Password = password,
                            Level = "Freshman"
                        };
                        dbContext.Students.Add(student);
                        break;

                    case UserType.Teacher:
                        // Save teacher registration data
                        var teacher = new Teacher
                        {
                            Username = username,
                            Password = password
                            // Add additional properties specific to Teacher if needed
                        };
                        dbContext.Teachers.Add(teacher);
                        break;

                    case UserType.Admin:
                        // Save admin registration data
                        var admin = new Admin
                        {
                            Username = username,
                            Password = password
                            // Add additional properties specific to Admin if needed
                        };
                        dbContext.Admins.Add(admin);
                        break;
                }

                // Save changes to the database
                dbContext.SaveChanges();
            }


        

        private void BtoLogin_Click(object sender, EventArgs e) { 
        Login loginForm = new Login();
        loginForm.Show();
            this.Hide();
    }
        private void GotoMain_Click(object sender, EventArgs e)
        {
            EntryForm entry = new EntryForm();
            entry.Show();
            this.Hide();
        }
       
    }
}