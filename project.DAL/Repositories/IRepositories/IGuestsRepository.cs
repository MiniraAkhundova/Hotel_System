using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Repositories.IRepositories
{
   public interface IGuestsRepository
    {
        Task<List<Guests>> Get();
        Task<List<Guests>> GetGuestsWithRooms();
        Task Add(Guests guests);
        Task Delete(int guestId);
    }
}
