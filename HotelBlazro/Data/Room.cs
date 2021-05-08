using System.Collections.Generic;

namespace HotelBlazro.Data
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Price { get; set; }
        public bool Active { get; set; }
        public int Persons { get; set; }
        public List<Supplement> Supplements { get; set; } = new List<Supplement>();
    }
}