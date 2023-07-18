using System.ComponentModel.DataAnnotations;

namespace WEBMVC.Models
{
    public class Book
    {
        public Book()
        {
            this.CategoryBooks = new HashSet<CategoryBook>();
        }
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DatePublic { get; set; }
        public virtual ICollection<CategoryBook> CategoryBooks { get; set; }
    }
}
