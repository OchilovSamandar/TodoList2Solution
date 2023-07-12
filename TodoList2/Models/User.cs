using System.ComponentModel.DataAnnotations;

namespace TodoList2.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Firstname bo'sh bo'lishi mumkin emas!")]
        [StringLength(100)]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname bo'sh bo'lishi mumkin emas! ")]
        [StringLength(100,ErrorMessage ="Lastname maxLength=100 ")]
        public string Lastname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public List<Todo> Todos { get; set; } = new List<Todo>();


    }
}
