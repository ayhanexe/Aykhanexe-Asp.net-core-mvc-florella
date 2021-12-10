using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_core_empty_task.Models
{
    public class Header
    {
        public int Id { get; set; }
        
        [Column("LogoUrl")]
        [MaxLength(300)]
        public string Logo { get; set; }
    }
}
