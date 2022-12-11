using project.DTO.AdminstratorsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services.IService
{
   public interface IAdminService
    {
        Task<List<AdminToListDTO>> Get();

        Task Add(AdminToAddDTO adminToAddTO);

        string LogInChecking(string adminName,int adminpassword);
    }
}
