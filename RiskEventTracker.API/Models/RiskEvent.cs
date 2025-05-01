using System.ComponentModel.DataAnnotations;

namespace RiskEventTracker.API.Models
{
    public class RiskEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(20)]
        public string Severity { get; set; }

        public DateTime DateLogged { get; set; } = DateTime.UtcNow;
    }
}