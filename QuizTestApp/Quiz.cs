using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTestApp
{
    internal class Quiz
    {
        private Question[] question;
        public Quiz(Question[] questions)
        {
            this.question = questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz!!");
            int questionNumber = 1;

            foreach (Question pertanyaan in question)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(pertanyaan);
                int userChoice = GetUserChoice();
                if (pertanyaan.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"Salah, yang bener adalah {pertanyaan.Answers[pertanyaan.CorrectionAnswer]}");
                }
            }
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.Write($"{i+1}");
                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your Answer is (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid Choice. Please Enter the number between 1 & 4: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("\n");
            return choice -1;
        }
    }
}
