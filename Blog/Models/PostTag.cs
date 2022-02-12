using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("PostTag")]
    public class PostTag
    {
        [ForeignKey("PostId")]
        public int PostId { get; set; }
        public Post Post { get; set; }


        [ForeignKey("TagId")]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}