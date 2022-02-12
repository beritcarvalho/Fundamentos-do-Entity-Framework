using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "VARCHAR")]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [Column("Slug", TypeName = "VARCHAR")]
        [MaxLength(80)]
        public string Slug { get; set; }
    }
}