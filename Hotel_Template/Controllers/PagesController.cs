using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project.BLL.Services.IService;
using project.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Template.Controllers
{
    public class PagesController : Controller
    {
    
        private readonly IRoomService _roomService;

        private readonly IGuestService _guestService;

        private readonly IAdminService _adminService;

        public PagesController(IRoomService roomService, IGuestService guestService, IAdminService adminService)
        {
            _roomService = roomService;
            _guestService = guestService;
            _adminService = adminService;


        }
        //AdminExistenseChecking
        public async Task<IActionResult> AdminExistenseChecking(string adminName, int adminPassword)
        {
            var admins = _adminService.LogInChecking(adminName, adminPassword);          
            if (admins=="exsists")
            {
               
                return RedirectToAction("RoomsList");             
            }
            else
            {                       
                return RedirectToAction("Index", "Registration");
            }
        }

        //Reserved Rooms
        public async Task<IActionResult> ReservedRooms()
        {
            var result = await _guestService.GetGuestsWithRooms();

            return View(result);
        }
        //Delete reservation
        public async Task<IActionResult> DeleteReservation(int guestNumber)
        {
            await _guestService.Delete(guestNumber);

            return RedirectToAction("RoomsList");


        }

        //Unreserved Rooms
        public async Task<IActionResult> UnreservedRooms()
        {
            var result = await _roomService.GetUnorderedRooms();

            return View(result);
        }
        //Rooms List
        public async Task<IActionResult> RoomsList()
        {
            var result = await _roomService.Get();

            return View(result);
        }

        //Delete

        public async Task<IActionResult> DeleteRoom(int roomId)
        {
           await _roomService.Delete(roomId);

           return RedirectToAction("RoomsList");


        }
        //Export
        public async Task<IActionResult> Export(int guestNumber)
        {
            var result = await _guestService.GetGuestsWithRooms();

            return View(result.Where(g=>g.GuestNumber==guestNumber).ToList());
        }

        //Finish Reservation
        public async Task<IActionResult> FinishReservation(int guestNumber)
        {
            await _guestService.Delete(guestNumber);

            return RedirectToAction("RoomsList");


        }
        //Blog
        public IActionResult Blog()
        {       
            return View();
        }
        //Contact Us
        public IActionResult ContactUs()
        {
            return View();
        }


        public IActionResult Details(int id)
        {
            return View();
        }
      
        // GET: PagesController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PagesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PagesController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PagesController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: PagesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
