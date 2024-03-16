using ExaminationSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExaminationSys.Controllers
{
    internal class AnswerController
    {
        private readonly QuestionController _questionController = new();

 

        /// <summary>
        /// Checks if the provided answers are correct for the specified question.
        /// </summary>
        /// <param name="questionId">The ID of the question.</param>
        /// <param name="answerIds">The list of answer IDs to check.</param>
        /// <returns>True if all answers are correct for the question; otherwise, false.</returns>
        public bool AreAnswersCorrectForQuestion(int questionId, List<int> answerIds)
        {
            try
            {
                var correctAnswersIds = _questionController.GetCorrectAnswer(questionId)
                                                           .Select(a => a.AnswerId)
                                                           .ToList();

                correctAnswersIds.Sort();
                answerIds.Sort();

                return correctAnswersIds.SequenceEqual(answerIds);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while checking answer correctness for question: {ex.Message}");
                return false;
            }
        }
    }
}
