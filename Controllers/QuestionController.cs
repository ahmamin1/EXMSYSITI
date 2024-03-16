using ExaminationSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExaminationSys.Controllers
{
    internal class QuestionController
    {
        private readonly ExamDbContext dbContext = new();

        /// <summary>
        /// Adds a new question to the database.
        /// </summary>
        /// <param name="question">The question to add.</param>
        /// <returns>True if the question is added successfully; otherwise, false.</returns>
        public bool AddQuestion(Questions question)
        {
            try
            {
                dbContext.Questions.Add(question);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while adding question: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Retrieves all questions from the database.
        /// </summary>
        /// <returns>A collection of all questions.</returns>
        public ICollection<Questions> GetAllQuestions()
        {
            return dbContext.Questions.ToList();
        }

        /// <summary>
        /// Retrieves questions associated with a specific exam from the database.
        /// </summary>
        /// <param name="examId">The ID of the exam.</param>
        /// <returns>A collection of questions associated with the specified exam.</returns>
        public ICollection<Questions> GetQuestionsByExam(int examId)
        {
            return dbContext.Questions.Where(q => q.ExamId == examId).ToList();
        }

        /// <summary>
        /// Retrieves answers associated with a specific question from the database.
        /// </summary>
        /// <param name="questionId">The ID of the question.</param>
        /// <returns>A collection of answers associated with the specified question.</returns>
        public ICollection<Answer>? GetAnswersByQuestion(int questionId)
        {
            try
            {
                var answers = dbContext.Answers.Where(a => a.QuestionId == questionId).ToList();
                return answers;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while retrieving answers by question: {ex.Message}");
                return null;
            }
        }


        /// <summary>
        /// Deletes a question from the database.
        /// </summary>
        /// <param name="questionId">The ID of the question to delete.</param>
        /// <returns>True if the question is deleted successfully; otherwise, false.</returns>
        public bool DeleteQuestion(int questionId)
        {
            try
            {
                var questionToDelete = dbContext.Questions.Find(questionId);

                if (questionToDelete != null)
                {
                    dbContext.Questions.Remove(questionToDelete);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while deleting question: {ex.Message}");
                return false;
            }
        }
    }
}
