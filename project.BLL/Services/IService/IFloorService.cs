using project.DTO.FloorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BLL.Services.IService
{
   public interface IFloorService
    {
        Task<List<FloorToListDTO>> Get();

       
        
    }
}
