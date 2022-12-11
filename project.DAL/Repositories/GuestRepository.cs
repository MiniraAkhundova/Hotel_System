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
  public  class GuestRepository: IGuestsRepository
    {
        private readonly AppDbContext _appContext;
        public GuestRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task Add(Guests guests)
        {
            await _appContext.Guests.AddAsync(guests);
        }

        public async Task<List<Guests>> Get()
        {
            return await _appContext.Guests.ToListAsync();
        }

        public async Task Delete(int guestsId)
        {
            Guests guests = await _appContext.Guests.FindAsync(guestsId);
            guests.IsDeleted = true;
            _appContext.Guests.Remove(guests);
            _appContext.SaveChanges();
        }

        public async Task<List<Guests>> GetGuestsWithRooms()
        {
            return await _appContext.Guests.Include(g => g.Room).ThenInclude(g => g.Floor).ToListAsync();
          
        }



    }
}
