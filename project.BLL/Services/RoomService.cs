using AutoMapper;
using project.BLL.Services.IService;
using project.DAL.UnitOfWorks;
using project.DTO.RoomDTOs;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services
{
  public  class RoomService: IRoomService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public RoomService(IUnitOfWorks unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(RoomToAddDTO roomToAddTO, string roomPictureFilePath)
        {
            Room room = _mapper.Map<Room>(roomToAddTO);
            room.RoomPictureFilePath= roomPictureFilePath;
            await _unitOfWork.RoomRepository.Add(room);
            await _unitOfWork.Commit();         
        }

        public async Task Delete(int roomId)
        {
            await _unitOfWork.RoomRepository.Delete(roomId);
        }

        public async Task<List<RoomToListDTO>> Get()
        {
            List<RoomToListDTO> rooms = _mapper.Map<List<RoomToListDTO>>(await _unitOfWork.RoomRepository.Get());
            return rooms;
        }

        public async Task<List<RoomToListDTO>> GetUnorderedRooms()
        {
            List<RoomToListDTO> rooms = _mapper.Map<List<RoomToListDTO>>(await _unitOfWork.RoomRepository.GetUnorderedRooms());
            return rooms;
        }

        public async Task Update(RoomToUpdateDTO roomToUpdateDTO, string roomPictureFilePath)
        {
            Room room = _mapper.Map<Room>(roomToUpdateDTO);
            room.RoomPictureFilePath = roomPictureFilePath;
            await _unitOfWork.RoomRepository.Update(room);
            await _unitOfWork.Commit();
        }
    }
}
