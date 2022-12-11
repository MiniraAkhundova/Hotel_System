using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Entity.Entities
{
  public  class Administrators
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Wrong entered data")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Wrong entered data")]
        public string AdminSurname { get; set; }

        [EmailAddress]
        public string UserEmail { get; set; }

        [Range(18, 69)]
        public int UserAge { get; set; }

        [Required(ErrorMessage = "Wrong entered data")]
        public int AdminPassword { get; set; }

        public string AdminGender { get; set; }

        public DateTime AdminDOB { get; set; }

        public bool IsDeleted { get; set; }
    }
}
