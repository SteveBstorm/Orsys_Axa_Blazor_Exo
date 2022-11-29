using System.ComponentModel.DataAnnotations;

namespace Orsys_Axa_Blazor_Exo.Pages
{
    public partial class Form
    {
        public User UserForm { get; set; }
        public Form()
        {
            UserForm = new User();
            UserForm.Favoris = new List<Favoris>();
            UserForm.Favoris.Add(new Favoris());
        }

        public void AddFavori()
        {
            UserForm.Favoris.Add(new Favoris());
            StateHasChanged();
        }
        public void RemoveFav(int index)
        {
            UserForm.Favoris.RemoveAt(index);
        }
        public void ValidForm()
        {
            
            Console.WriteLine(UserForm.Email);
            Console.WriteLine(UserForm.Username);
            Console.WriteLine(UserForm.Birthdate);
            Console.WriteLine(UserForm.Favoris[0].Value);
        }
    }

    public class User
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Username { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [ValidateComplexType]
        public List<Favoris> Favoris { get; set; }


    }

    public class Favoris
    {
        [Required]
        public string Value { get; set; }
        public int Id { get; set; }
    }
}
