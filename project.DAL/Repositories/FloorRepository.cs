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
    public class FloorRepository : IFloorRepository
    {
        private readonly AppDbContext _appContext;
        public FloorRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<List<Floor>> Get()
        {
            return await _appContext.Floor.ToListAsync();
        }
    }
}
