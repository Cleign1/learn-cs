using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTestApp
{
    internal class Quiz
    {
        private Question[] _question;
        private int _score;
        public Quiz(Question[] questions)
        {
            this._question = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz!!");
            int questionNumber = 1;
           
            foreach (Question question in _question)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Salah, yang bener adalah {question.Answers[question.CorrectionAnswer]}");
                }
            }
            DisplayResults();
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

        private void DisplayResults()
        {
            double hasil = ((double)_score / _question.Length) * 100;
            Console.WriteLine($"Kuis selesai, nilai anda adalah {hasil}");
        }
    }
}
