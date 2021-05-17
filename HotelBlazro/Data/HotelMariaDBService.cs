using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBlazro.Repos;
using Microsoft.EntityFrameworkCore;

namespace HotelBlazro.Data
{
    public class HotelMariaDbService:IHotelService
    {
        private readonly HotelContext _hotelContext;
        
        public HotelMariaDbService(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }
        public void AddUpdateRoom(Room room)
        {
            _hotelContext.Rooms.Update(room);
            _hotelContext.SaveChanges();
        }

        public async Task<List<Room>> Rooms()
        {
         return await  _hotelContext.Rooms.ToListAsync();
        }

        public Task<Room> GetRoom(int Id)
        {
         
           return _hotelContext.Rooms.FirstOrDefaultAsync(t => t.Id.Equals(Id));
        }

        public async Task<List<Supplement>> Supplements()
        {
            return await _hotelContext.Supplements.ToListAsync();
        }

        public async Task<Supplement> GetSupplement(int id)
        {
            return await _hotelContext.Supplements.FirstOrDefaultAsync(t => t.Id.Equals(id));
        }

        public void AddUpdateSupplements(Supplement supplement)
        {
            _hotelContext.Supplements.Update(supplement);
            _hotelContext.SaveChanges();
        }

        public void Delete(Supplement supplement)
        {
            _hotelContext.Supplements.Remove(supplement);
            _hotelContext.SaveChanges();
        }
    }
}