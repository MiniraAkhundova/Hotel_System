using project.DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.UnitOfWorks
{
 public   interface IUnitOfWorks
    {
        public IAdminRepository AdminRepository { get; set; }

        public IFloorRepository FloorRepository { get; set; }

        public IRoomRepository RoomRepository { get; set; }

        public IGuestsRepository GuestRepository { get; set; }

        public Task Commit();
    }
}
