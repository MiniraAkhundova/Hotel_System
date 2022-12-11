using AutoMapper;
using project.BLL.Services.IService;
using project.DAL.UnitOfWorks;
using project.DTO.GuestsDTOs;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services
{
    public class GuestService : IGuestService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public GuestService(IUnitOfWorks unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(GuestToAddDTO guestToAddTO)
        {
            Guests guest = _mapper.Map<Guests>(guestToAddTO);
            await _unitOfWork.GuestRepository.Add(guest);
            await _unitOfWork.Commit();
        }

        public async Task Delete(int guestId)
        {
            await _unitOfWork.GuestRepository.Delete(guestId);
        }

        public async Task<List<GuestToListDTO>> Get()
        {
            List<GuestToListDTO> guests = _mapper.Map<List<GuestToListDTO>>(await _unitOfWork.GuestRepository.Get());
            return guests;
        }

        public async Task<List<GuestToListDTO>> GetGuestsWithRooms()
        {
            List<GuestToListDTO> guests = _mapper.Map<List<GuestToListDTO>>(await _unitOfWork.GuestRepository.GetGuestsWithRooms());
            return guests;
        }

     
    }
}
