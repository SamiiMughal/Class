using System.ComponentModel.DataAnnotations;

namespace Category.Models.Model
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
