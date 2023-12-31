﻿using System.ComponentModel.DataAnnotations;

namespace TodoList2.Dto.TodoDtos
{
    public class TodoCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
