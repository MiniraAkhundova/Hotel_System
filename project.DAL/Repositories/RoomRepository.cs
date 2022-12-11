using Microsoft.EntityFrameworkCore;
using project.DAL.DataContext;
using project.DAL.Repositories.IRepositories;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Repositories
{
  public  class RoomRepository: IRoomRepository
    {
        private readonly AppDbContext _appContext;
        public RoomRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task Add(Room room)
        {
            await _appContext.Room.AddAsync(room);
        }

        public async Task<List<Room>> Get()
        {
         return await _appContext.Room.Include(m => m.Floor).ToListAsync();
            
        }

        public async Task Delete(int roomId)
        {
         
            Room room = await _appContext.Room.FindAsync(roomId);
            room.IsDeleted = true;
            _appContext.Room.Remove(room);
            _appContext.SaveChanges();
        }



        public async Task<List<Room>> GetUnorderedRooms()
        {
            return await _appContext.Room.Except(_appContext.Guests.Select(g => g.Room)).Include(r=>r.Floor).ToListAsync();
        }

        public async Task Update(Room room)
        {
             _appContext.Room.Update(room);
        }
    }
}

