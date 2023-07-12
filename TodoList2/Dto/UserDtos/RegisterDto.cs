using System.ComponentModel.DataAnnotations;

namespace TodoList2.Dto.UserDtos
{
    public class RegisterDto
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
