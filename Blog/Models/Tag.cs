using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "VARCHAR")]
        [MaxLength(80)]
        public string Name { get; set; }

        [Column("Slug", TypeName = "VARCHAR")]
        [MaxLength(80)]
        public string Slug { get; set; }
    }
}