using System.Collections.Generic;

namespace HotelBlazro.Data
{
    public class HotelService
    {
        private readonly List<Room> _rooms = new List<Room>();
        private readonly List<Supplement> _supplements = new List<Supplement>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public HotelService()
        {
            _supplements.Add(new Supplement()
            {
                Description = "bar",
                Id = 1,
                Price = 10,
                Selected = true
            });
            _supplements.Add(new Supplement()
            {
                Description = "bad",
                Id = 2,
                Price = 10,
                Selected = true
            });
            
            
            _rooms.Add(new Room()
            {
                Id = 1, Name = "kkk", Active = false, Price = 10, Persons = 10, RoomNumber = "1",
                Supplements = _supplements
              
            });
            _rooms.Add(new Room()
            {
                Id = 2, Name = "sun", Active = true, Price = 10, Persons = 10, RoomNumber = "1",
                Supplements = _supplements
              
            });
        }

        public List<Room> Rooms()
        {
            return _rooms;
        }
    }
}