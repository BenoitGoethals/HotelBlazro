using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBlazro.Data
{
    public interface IHotelService
    {
        void AddUpdateRoom(Room room);
        Task<List<Room>> Rooms();

        Task<Room> GetRoom(int Id);
    }

    public class HotelService : IHotelService
    {
        private readonly List<Room> _rooms = new List<Room>();
        private readonly List<Supplement> _supplements = new List<Supplement>();

        public void AddUpdateRoom(Room room)
        {
            if (room.Id == 0)
            {
                room.Id = _rooms.Max(t => t.Id) + 1;
                _rooms.Add(room);
            }
            else
            {
                
            }
            
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
                Supplements = new List<Supplement>()
                {
                    new Supplement()
                    {
                        Description = "bsdar",
                        Id = 3,
                        Price = 10,
                        Selected = true
                    },
                    new Supplement()
                    {
                        Description = "wddwbar",
                        Id = 4,
                        Price = 10,
                        Selected = false
                    }
                }
              
            });
            _rooms.Add(new Room()
            {
                Id = 2, Name = "sun", Active = true, Price = 10, Persons = 10, RoomNumber = "1",
                Supplements = _supplements
              
            });
        }

        public async Task<List<Room>> Rooms()
        {
            return await Task.FromResult<List<Room>>(_rooms);
        }

        public Task<Room> GetRoom(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}