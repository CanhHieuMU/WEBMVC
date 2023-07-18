using System.ComponentModel.DataAnnotations;

namespace WEBMVC.Models
{
    public class CategoryRole
    {
        [Key]
        public int CategoryRoleId { get; set; }
        [Required]
        public string RoleName { get; set; }

    }
}
