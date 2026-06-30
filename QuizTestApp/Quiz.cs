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

        public void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.Write($"{i+1}");
                Console.WriteLine($". {question.Answers[i]}");
            }
        }
    }
}
