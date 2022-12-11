using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DTO.FloorDTOs
{
   public class FloorToListDTO
    {
        [Required]
        public int FloorNumber { get; set; }

    }
}
