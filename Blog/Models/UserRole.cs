using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    [Table("UserRole")]
    public class UserRole
    {
        
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}