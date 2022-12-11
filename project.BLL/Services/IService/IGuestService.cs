using project.DTO.GuestsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services.IService
{
 public   interface IGuestService
    {
        Task<List<GuestToListDTO>> Get();
        Task<List<GuestToListDTO>> GetGuestsWithRooms();
        Task Add(GuestToAddDTO guestToAddTO);
      
        Task Delete(int guestId);
    }
}
