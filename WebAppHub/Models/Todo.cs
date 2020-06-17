using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHub.Models
{
    [Table("todos")]
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required()]
        [MaxLength(150)]
        public string Description { get; set; }

        [Required()]
        public bool Done { get; set; }
    }
}
