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
   public class AdminRepository:IAdminRepository
    {
        private readonly AppDbContext _appContext;
        public AdminRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task Add(Administrators administrators)
        {
            await _appContext.Administrators.AddAsync(administrators);
        }

        public string AdminChecking(string adminName, int adminPassword)
        {
            Administrators admins =  _appContext.Administrators.FirstOrDefault(a=>a.AdminName== adminName && a.AdminPassword== adminPassword);

            if (admins == null)
            {
                return "notexsists";
            }

            else
            {
                return "exsists";
            }
            
        }

        public async Task<List<Administrators>> Get()
        {
            return await _appContext.Administrators.ToListAsync();
        }

    }
}
