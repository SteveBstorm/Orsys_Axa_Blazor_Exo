using Microsoft.AspNetCore.Components;

namespace Orsys_Axa_Blazor_Exo.Pages
{
    public partial class Questions
    {
        [Parameter]
        public string Username { get; set; }

        [Parameter]
        public EventCallback<string> NotifyAnswer { get; set; }
        [Parameter]
        public EventCallback<bool> NotifyEndQuizz { get; set; }

        public List<string> QuestionList { get; set; }
        public int Counter { get; set; } = 0;

        public string CurrentQuestion { get; set; }

        public Questions()
        {
            QuestionList = new List<string>();
            QuestionList.Add("Aimez vous Blazor ?");
            QuestionList.Add("Utiliserez vous Blazor ?");
            QuestionList.Add("Avez vous envie d'une sieste ?");

            CurrentQuestion = QuestionList[0];
        }

        public void Answer(string rep)
        {
            Counter++;

            NotifyAnswer.InvokeAsync(rep);
            if(Counter >= QuestionList.Count)
            {
                CurrentQuestion = "";
                NotifyEndQuizz.InvokeAsync(true);
            }
            else
            {
                CurrentQuestion = QuestionList[Counter];
            }

        }

    }
}
