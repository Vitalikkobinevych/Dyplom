using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Petition
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [ForeignKey("User")]
        public string Author { get; set; } // FK to Username of User

        public string Image { get; set; }

        public bool IsPublished { get; set; }

        public bool IsSigned { get; set; }

        public int VoteCount { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
