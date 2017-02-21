using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models{
    public class Task{
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}