using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Repositories.IRepositories
{
  public  interface IFloorRepository
    {

        Task<List<Floor>> Get();

    }
}
