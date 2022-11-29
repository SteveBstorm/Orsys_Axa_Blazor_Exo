using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Orsys_Axa_Blazor_Exo.Models;

namespace Orsys_Axa_Blazor_Exo.Pages
{
    public partial class ExoForm
    {
        [Inject]
        public IJSRuntime _js { get; set; }
        public UserForm MyForm { get; set; }
        public ExoForm()
        {
            MyForm = new UserForm();
        }

        public void ValidSubmit()
        {
            _js.InvokeVoidAsync("alert", "SUCCESS");
            _js.InvokeVoidAsync("localStorage.setItem","etat", "Formulaire Ok");
            //string etat = _js.InvokeAsync<string>("localStorage.getItem", "etat").Result;

            //_js.InvokeVoidAsync("maFonction", MyForm);
        }

        public void InvalidSubmit()
        {
            _js.InvokeVoidAsync("alert", "Ca marche pas");
        }
    }
}
