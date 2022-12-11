using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DTO.RoomDTOs
{
   public class RoomToUpdateDTO
    {
        public IFormFile RoomPictureFile { get; set; }

        public string ImagePath { get; set; }
        public int RoomNumber { get; set; }

        public string RoomName { get; set; }

        public int FloorNumber { get; set; }

        public int RoomMax { get; set; }

        public int RoomCost { get; set; }
    }
}
