using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class RegisterLoginViewModel
    {
        [Required(ErrorMessage = "Поле Ім'я користувача є обов'язковим.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Поле Пароль є обов'язковим.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Паролі не співпадають.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
