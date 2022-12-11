using project.DTO.FloorDTOs;
using project.DTO.GuestsDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DTO.RoomDTOs
{
  public  class RoomToListDTO
    {
  
        public string RoomPictureFilePath { get; set; }

        public int RoomNumber { get; set; }

        public string RoomName { get; set; }

        public FloorToListDTO Floor { get; set; }

        [Range(1, 10)]
        public int RoomMax { get; set; }


        public int RoomCost { get; set; }


    }
}
