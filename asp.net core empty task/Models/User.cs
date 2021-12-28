using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace asp.net_core_empty_task.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}
