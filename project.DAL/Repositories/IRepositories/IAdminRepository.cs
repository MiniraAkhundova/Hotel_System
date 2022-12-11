using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Repositories.IRepositories
{
  public  interface IAdminRepository
    {
        Task<List<Administrators>> Get();

        Task Add(Administrators administrators);

        string AdminChecking(string adminName, int adminPassword);

    }
}
