using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "NVARCHAR")]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [Column("Email", TypeName = "VARCHAR")]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [Column("PasswordHash", TypeName = "VARCHAR")]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        [Column("Bio", TypeName = "TEXT")]
        [MaxLength(16)]
        public string Bio { get; set; }

        [Required]
        [Column("Image", TypeName = "VARCHAR")]
        [MaxLength(2000)]
        public string Image { get; set; }

        [Required]
        [Column("Slug", TypeName = "VARCHAR")]
        [MaxLength(80)]
        public string Slug { get; set; }
    }

}