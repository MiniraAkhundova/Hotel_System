using AutoMapper;
using project.BLL.Services.IService;
using project.DAL.UnitOfWorks;
using project.DTO.AdminstratorsDTOs;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public AdminService(IUnitOfWorks unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(AdminToAddDTO adminToAddTO)
        {
            Administrators admin = _mapper.Map<Administrators>(adminToAddTO);
            await _unitOfWork.AdminRepository.Add(admin);
            await _unitOfWork.Commit();
        }

        public async Task<List<AdminToListDTO>> Get()
        {
            List<AdminToListDTO> admins = _mapper.Map<List<AdminToListDTO>>(await _unitOfWork.AdminRepository.Get());
            return admins;
        }

        public string LogInChecking(string adminName, int adminpassword)
        {

            return _unitOfWork.AdminRepository.AdminChecking(adminName, adminpassword);
        }

            
 
    }
}
