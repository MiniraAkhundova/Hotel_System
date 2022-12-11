using AutoMapper;
using project.BLL.Services.IService;
using project.DAL.UnitOfWorks;
using project.DTO.FloorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services
{
    public class FloorService : IFloorService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public FloorService(IUnitOfWorks unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<FloorToListDTO>> Get()
        {
            List<FloorToListDTO> floors = _mapper.Map<List<FloorToListDTO>>(await _unitOfWork.FloorRepository.Get());
            return floors;
        }
    }
}
