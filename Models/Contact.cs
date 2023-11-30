using System.ComponentModel.DataAnnotations;

namespace testASP.Models
{
    public class Contact
    {
        [Display(Name = "Ваш Email")]
        public DateOnly JoiningDate { get; set; }

        [Display(Name = "Ваше ім'я")]
        [Required(ErrorMessage = "Ім'я має бути обов'язково")]
        public string Name { get; set; }

        [Display(Name = "Ваше прізвище")]
        [Required(ErrorMessage = "Прізвище має бути обов'язково")]
        public string SurName { get; set; }
  
        [Display(Name = "Ваш телефон")]
        [Required(ErrorMessage = "Телефон має бути обов'язково")]
        public int Telephone { get; set; }

        [Display(Name = "Ваш Email")]
        [Required(ErrorMessage = "Email має бути обов'язково")]
        [UIHint("EmailAddress")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введіть пароль")]
        [Display(Name = "Введіть пароль")]
        [StringLength(15, MinimumLength = 6)]
        [Compare("PasswordConfirm")]
        [UIHint("Password")]
        public string Password { get; set; }

        [Display(Name = "Введіть пароль повторно")]
        [StringLength(15, MinimumLength = 6)]
        [UIHint("Password")]
        public string PasswordConfirm { get; set; }

    }
}
