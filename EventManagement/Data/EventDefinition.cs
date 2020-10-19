using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.Data
{
    public class EventDefinition
    {
        public EventDefinition()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(5000)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [Range(1, 100)]
        public int NumberOfParticipants { get; set; }

        public bool RegistrationRequired { get; set; }
    }
}
