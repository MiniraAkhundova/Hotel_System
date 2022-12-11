using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entity.Entities
{
   public class Guests
    {
        [Key]
        public int GuestNumber { get; set; }

        [Required(ErrorMessage = "Wrong entered data")]
        public string GuestName { get; set; }

        public virtual Room Room { get; set; }

        [ForeignKey("Room")]
        public int RoomNumber { get; set; }

        [Range(1, 10)]
        public int RoomMax { get; set; }

        [Required]
        public DateTime GuestStayFrom { get; set; }

        [Required]
        public DateTime GuestStayTo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
