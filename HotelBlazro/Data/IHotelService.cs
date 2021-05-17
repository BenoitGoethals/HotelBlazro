using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBlazro.Data
{
    public interface IHotelService
    {
        void AddUpdateRoom(Room room);
        Task<List<Room>> Rooms();

        Task<Room> GetRoom(int Id);
        Task<List<Supplement>> Supplements();
        Task<Supplement> GetSupplement(int id);
        void AddUpdateSupplements(Supplement supplement);
        void Delete(Supplement supplement);
    }
}