using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0302._1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string name { get; set; }
    }
}
