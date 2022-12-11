using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project.BLL.Services.IService;
using project.DTO.GuestsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Template.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IGuestService _guestService;

        private readonly IRoomService _roomService;

        public ReservationController( IGuestService guestService, IRoomService roomService)
        {
            _guestService = guestService;
            _roomService = roomService;
        }
        // GET: RoomReservation

        public async Task<IActionResult> Index(int roomNumber)
        {
            var result = await _roomService.Get();

            var fullResult = result.FirstOrDefault(r => r.RoomNumber == roomNumber);

            ViewBag.RoomNumber = fullResult.RoomNumber;

            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> ReserveRoom(GuestToAddDTO guestToAddDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();

                }
                await _guestService.Add(guestToAddDTO);
                return RedirectToAction("ReservedRooms", "Pages");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: RoomReservation/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomReservation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomReservation/Create
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

        // GET: RoomReservation/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomReservation/Edit/5
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

        // GET: RoomReservation/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomReservation/Delete/5
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
