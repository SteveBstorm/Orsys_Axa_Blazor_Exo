namespace Orsys_Axa_Blazor_Exo.Pages
{
    public partial class Quizz
    {
        public string Username { get; set; }

        public List<string> Answers { get; set; }
        public bool QuizzIsFinished { get; set; }

        public Quizz()
        {
            Answers = new List<string>();
        }

        public void ReceiveAnswer(string rep)
        {
            Answers.Add(rep);
        }

        public void NotifiedEndGame()
        {
            QuizzIsFinished = true;
        }
    }
}
