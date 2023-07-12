using System.ComponentModel.DataAnnotations;

namespace TodoList2.Dto
{
    public class TodoReadDto 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
