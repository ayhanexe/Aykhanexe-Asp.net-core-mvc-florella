using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_empty_task.Models
{
    public class Footer
    {
        public int id { get; set; }

        [Column("LinkedinUrl")]
        [MaxLength(200)]
        public string Linkedin { get; set; }

        [Column("FacebookUrl")]
        [MaxLength(200)]
        public string Facebook { get; set; }

        [Column("LogoUrl")]
        [MaxLength(200)]
        public string Logo { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
