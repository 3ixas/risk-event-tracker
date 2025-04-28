using System;

namespace RiskEventTracker.API.Models
{
    public class RiskEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } // e.g. Cyber Risk
        public string Severity { get; set; } // e.g. Low, Medium, High, Critical
        public DateTime DateLogged { get; set; } = DateTime.UtcNow; 
    }
}