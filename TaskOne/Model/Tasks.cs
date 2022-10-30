using System.ComponentModel.DataAnnotations;

namespace TaskOne.Model
{
    public class Tasks
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string SlackUsername { get; set; }
        public bool Backend { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }
    }
}
