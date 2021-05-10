using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBlazro.Data
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name is too long.")]
            
        public string Name { get; set; }
        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public bool Active { get; set; }
        public int Persons { get; set; }
        public List<Supplement> Supplements { get; set; } = new List<Supplement>();

        protected bool Equals(Room other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Room) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
    
    
}