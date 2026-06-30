namespace QuizTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] question = new Question[]
            {
                new Question("Siapa Gweh?",
                new string[] {"Gweh", "Lu", "Awas ada suleee"},
                2)
            };

            Quiz myQuiz = new Quiz(question);
            myQuiz.DisplayQuestion(question[0]);


        }
    }
}
