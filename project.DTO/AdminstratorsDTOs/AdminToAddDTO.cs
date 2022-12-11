using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DTO.AdminstratorsDTOs
{
 public  class AdminToAddDTO

    { 
        public int AdminId { get; set; }
     
        public string AdminName { get; set; }

        public string AdminSurname { get; set; }
        public string UserEmail { get; set; }

        public int UserAge { get; set; }

        public int AdminPassword { get; set; }

        public string AdminGender { get; set; }

        public DateTime AdminDOB { get; set; }

    }
}
