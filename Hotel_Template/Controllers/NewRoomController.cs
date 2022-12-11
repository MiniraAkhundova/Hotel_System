using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project.BLL.Services.IService;
using project.DTO.RoomDTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Template.Controllers
{
    public class NewRoomController : Controller

    {
        private readonly IHostingEnvironment _enviroment;

        private readonly IRoomService _roomService;

        public NewRoomController(IHostingEnvironment enviroment, IRoomService roomService)
        {
            _enviroment = enviroment;
            _roomService = roomService;
        }
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromForm] RoomToAddDTO roomToAddDTO)
        {
             Guid guid = Guid.NewGuid();
            var folder = Path.Combine(_enviroment.WebRootPath, "pages_images");
            string fileName = guid.ToString() + roomToAddDTO.RoomPictureFile.FileName;
            string filePath = folder + "/" + fileName;
          
            //try
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return BadRequest();

            //    }
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await roomToAddDTO.RoomPictureFile.CopyToAsync(stream);
                }
                await _roomService.Add(roomToAddDTO, fileName);            
                return RedirectToAction("RoomsList", "Pages");
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}


        }
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: NewRoomController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewRoomController/Create
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

        // GET: NewRoomController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewRoomController/Edit/5
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

        // GET: NewRoomController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewRoomController/Delete/5
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
