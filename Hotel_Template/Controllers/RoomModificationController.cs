using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.BLL.Services.IService;
using project.DTO.RoomDTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Template.Controllers
{
    public class RoomModificationController : Controller
    {
        private readonly IRoomService _roomService;

        private readonly IHostingEnvironment _enviroment;

        public RoomModificationController(IHostingEnvironment enviroment, IRoomService roomService)
        {
            _enviroment = enviroment;
            _roomService = roomService;
        }
     
        public async Task<IActionResult> Index(int roomId)
        {
            var result = await _roomService.Get();

            var finalResult = result.FirstOrDefault(r => r.RoomNumber == roomId);

            RoomToUpdateDTO model = new() 
            {
                ImagePath = finalResult.RoomPictureFilePath,
                RoomNumber = finalResult.RoomNumber,
                RoomName = finalResult.RoomName,
                FloorNumber = finalResult.Floor.FloorNumber,
                RoomMax = finalResult.RoomMax,
                RoomCost = finalResult.RoomCost
            };

          

            //RoomToUpdateDTO
            return View(model);
         
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(/*[FromForm]*/ RoomToUpdateDTO roomToUpdateDTO)
        {
            string fileName = "";
            if (roomToUpdateDTO.RoomPictureFile != null)
            {
                Guid guid = Guid.NewGuid();
                var folder = Path.Combine(_enviroment.WebRootPath, "pages_images");
                fileName = guid.ToString() + roomToUpdateDTO.RoomPictureFile.FileName;
                string filePath = folder + "/" + fileName;


                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await roomToUpdateDTO.RoomPictureFile.CopyToAsync(stream);
                }
            }
            else
                fileName = roomToUpdateDTO.ImagePath;
           
            await _roomService.Update(roomToUpdateDTO, fileName);
            return RedirectToAction("RoomsList", "Pages");
        

        }
        // GET: RoomModificationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomModificationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomModificationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RoomModificationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomModificationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RoomModificationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomModificationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
