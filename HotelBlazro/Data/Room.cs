using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelBlazro.Data
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Price { get; set; }
        public bool Active { get; set; }
        public int Persons { get; set; }
        public List<Supplement> Supplements { get; set; } = new List<Supplement>();
    }
}