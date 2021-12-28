using System.ComponentModel.DataAnnotations;

namespace asp.net_core_empty_task.ViewModels
{
    public class LoginViewModel
    {
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public bool RememberMe { get; set; }

    }
}
