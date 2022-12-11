using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Repositories.IRepositories
{
  public  interface IRoomRepository
    {
        Task<List<Room>> Get();
        Task<List<Room>> GetUnorderedRooms();
        Task Add(Room room);
        Task Update(Room room);
        Task Delete(int roomId);
    }
}
