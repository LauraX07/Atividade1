using System.ComponentModel.DataAnnotations;

namespace Atividade1.Models
{
    public class Login
    {
        [Display(Name = "Usuário")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Usuário Invalido")]
        public string? Usuario { get; set; }

        [Display(Name = "Senha")]

        public string? Password { get; set; }


    }
}
