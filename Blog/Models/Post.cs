using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }


        [Required]
        [Column("Title", TypeName = "VARCHAR")]
        [MaxLength(160)]
        public string Title { get; set; }


        [Required]
        [Column("Summary", TypeName = "VARCHAR")]
        [MaxLength(255)]
        public string Summary { get; set; }


        [Required]
        [Column("Body", TypeName = "TEXT")]
        [MaxLength(16)]
        public string Body { get; set; }


        [Required]
        [Column("Slug", TypeName = "VARCHAR")]
        [MaxLength(80)]
        public string Slug { get; set; }


        [Required]
        [Column("CreateDate", TypeName = "DATETIME")]
        [MaxLength(8)]
        public DateTime CreateDate { get; set; }


        [Required]
        [Column("LastUpdateDate", TypeName = "DATETIME")]
        [MaxLength(8)]
        public DateTime LastUpdateDate { get; set; }
    }
}