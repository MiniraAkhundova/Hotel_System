using project.DTO.RoomDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services.IService
{
  public  interface IRoomService
    {
        Task<List<RoomToListDTO>> Get();
        Task<List<RoomToListDTO>> GetUnorderedRooms();
        Task Add(RoomToAddDTO roomToAddTO, string roomPictureFilePath);

        Task Update(RoomToUpdateDTO roomToUpdateDTO, string roomPictureFilePath);
        Task Delete(int roomId);
    }
}
