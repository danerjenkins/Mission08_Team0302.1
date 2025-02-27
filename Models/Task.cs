using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0302._1.Models
{
    public class Task
    {
        [Key]
        public string TaskId { get; set; }
        [Required]
        public string task_description { get; set; }
        public string due_date { get; set; }
        [Range(1, 4)]
        [Required]
        public int quadrant { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool completed { get; set; }

    }
}
