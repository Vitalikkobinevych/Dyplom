using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [ForeignKey("User")]
        public string Author { get; set; } // FK to Username of User

        public bool IsPublished { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Image { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
