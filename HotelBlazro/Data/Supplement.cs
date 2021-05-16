using System.ComponentModel.DataAnnotations;

namespace HotelBlazro.Data
{
    public class Supplement
    {
        public int Id { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).",MinimumLength = 5)]
        public string Description { get; set; }
        [Required]
        [MinLength(0)]
        public int Price { get; set; }
        public bool Selected { get; set; }
    }
}