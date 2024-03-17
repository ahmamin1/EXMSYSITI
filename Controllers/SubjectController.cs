using ExaminationSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExaminationSys.Controllers
{
    internal class SubjectController
    {
        private readonly ExamDbContext dbContext = new();

        /// <summary>
        /// Adds a new subject to the database.
        /// </summary>
        /// <param name="subject">The subject to add.</param>
        /// <returns>True if the subject is added successfully; otherwise, false.</returns>
        public bool AddSubject(Subject subject)
        {
            try
            {
                dbContext.Subjects.Add(subject);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while adding subject: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Retrieves all subjects from the database.
        /// </summary>
        /// <returns>A collection of all subjects.</returns>
        public ICollection<Subject> GetAllSubjects()
        {
            return dbContext.Subjects.ToList();
        }

        /// <summary>
        /// Retrieves a subject by its ID from the database.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <returns>The subject with the specified ID, or null if not found.</returns>
        public Subject GetSubjectById(int subjectId)
        {
            try
            {
                var subject = dbContext.Subjects.Find(subjectId);
                return subject;
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., database connection issues
                Console.WriteLine($"Error occurred while retrieving subject by ID: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Retrieves exams associated with a specific subject from the database.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <returns>A collection of exams associated with the specified subject.</returns>
        public ICollection<Exam> GetExamsOfSubject(int subjectId)
        {
            try
            {
                var exams = dbContext.Exams.Where(e => e.SubjectId == subjectId).ToList();
                return exams;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while retrieving exams for subject: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Deletes a subject from the database.
        /// </summary>
        /// <param name="subjectId">The ID of the subject to delete.</param>
        /// <returns>True if the subject is deleted successfully; otherwise, false.</returns>
        public bool DeleteSubject(int subjectId)
        {
            try
            {
                var subjectToDelete = dbContext.Subjects.Find(subjectId);

                if (subjectToDelete != null)
                {
                    dbContext.Subjects.Remove(subjectToDelete);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while deleting subject: {ex.Message}");
                return false;
            }
        }

       
    }
}

