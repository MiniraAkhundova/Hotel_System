using project.DAL.DataContext;
using project.DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.UnitOfWorks
{
   public class UnitOfWorks : IUnitOfWorks
    {
        public IAdminRepository AdminRepository { get; set; }

        public IFloorRepository FloorRepository { get; set; }

        public IRoomRepository RoomRepository { get; set; }

        public IGuestsRepository GuestRepository { get; set; }


        private readonly AppDbContext _appContext;

        public UnitOfWorks(IAdminRepository adminRepository, IFloorRepository floorRepository, IRoomRepository roomRepository, IGuestsRepository guestRepository, AppDbContext appContext)
        {
            AdminRepository = adminRepository;
            FloorRepository = floorRepository;
            RoomRepository = roomRepository;
            GuestRepository = guestRepository;
            _appContext = appContext;
        }

        public async Task Commit()
        {
            await _appContext.SaveChangesAsync();
        }
    }
}
