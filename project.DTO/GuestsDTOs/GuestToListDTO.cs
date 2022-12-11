using project.DTO.RoomDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DTO.GuestsDTOs
{
   public class GuestToListDTO
    {
      
        public int GuestNumber { get; set; }
 
        public string GuestName { get; set; }

        public RoomToListDTO Room { get; set; }

        public int RoomMax { get; set; }

        public DateTime GuestStayFrom { get; set; }

        public DateTime GuestStayTo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
