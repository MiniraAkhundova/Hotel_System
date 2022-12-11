using AutoMapper;

using project.DTO.AdminstratorsDTOs;
using project.DTO.FloorDTOs;
using project.DTO.GuestsDTOs;
using project.DTO.RoomDTOs;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson.Core.Automapper
{
   public class AutomapperProfiles: Profile
    {
        public AutomapperProfiles()
        {

            CreateMap<AdminToAddDTO, Administrators > ();
            CreateMap<Administrators, AdminToListDTO>();


            CreateMap<Floor, FloorToListDTO>();

            CreateMap<GuestToAddDTO, Guests>();
            CreateMap<Guests, GuestToListDTO>();
            CreateMap<Guests, RoomToListDTO>();

            CreateMap<RoomToAddDTO, Room>();
            CreateMap<Room, RoomToListDTO>();
            CreateMap<RoomToUpdateDTO, Room>();
        }
    }
}
