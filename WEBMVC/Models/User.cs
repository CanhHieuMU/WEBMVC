using System.ComponentModel.DataAnnotations;

namespace WEBMVC.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual Account Account { get; set; }
        
    }
}
