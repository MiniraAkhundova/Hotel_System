using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entity.Entities
{
    public class Floor
    {
        [Key]
        public int FloorNumber { get; set; }

        public List<Room> Rooms { get; set; }

        public bool IsDeleted { get; set; }
    }
}
