using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DTO.RoomDTOs
{
  public  class RoomToAddDTO
    {

        public IFormFile RoomPictureFile { get; set; }

        public int RoomNumber { get; set; }

        public string RoomName { get; set; }
 
        public int FloorNumber { get; set; }
     
        public int RoomMax { get; set; }
  
        public int RoomCost { get; set; }

     
    }
}
