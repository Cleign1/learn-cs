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
                2),
                new Question("Berapa 10 + 6",
                new string[] {"16", "17", "Nyenyenyenye"},
                1),
                new Question("Saya akan....",
                new string[] {"Lawan", "Uehh kaget!", "YNKTS"},
                0)
            };

            Quiz myQuiz = new Quiz(question);
            myQuiz.StartQuiz();
        }
    }
}
