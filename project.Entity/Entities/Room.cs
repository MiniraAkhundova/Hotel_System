using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entity.Entities
{
  public  class Room
    {
        [Required(ErrorMessage = "Wrong entered data")]
        public string RoomPictureFilePath { get; set; }

        [Key]
        public int RoomNumber { get; set; }

        [Required(ErrorMessage = "Wrong entered data")]
        public string RoomName { get; set; }

        public virtual Floor Floor { get; set; }

        [ForeignKey("Floor")]
        public int FloorNumber { get; set; }

        [Range(1, 10)]
        public int RoomMax { get; set; }

        [Required]
        public int RoomCost { get; set; }

    
        public bool IsDeleted { get; set; }
    }
}
