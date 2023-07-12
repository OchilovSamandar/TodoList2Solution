using System.ComponentModel.DataAnnotations;

namespace TodoList2.Dto.UserDtos
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
