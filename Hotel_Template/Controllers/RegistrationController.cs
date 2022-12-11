using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project.BLL.Services.IService;
using project.DTO.AdminstratorsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Template.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IAdminService _adminService;

        public RegistrationController(IAdminService adminService)
        {
            _adminService = adminService;
        }
    
        public IActionResult Index()
        {
            return View();
        }
        //Create Admin
        [HttpPost]
        public async Task<IActionResult> CreateAdmin(AdminToAddDTO adminToAddDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();

                }
                await _adminService.Add(adminToAddDTO);
                return RedirectToAction("RoomsList", "Pages");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
       
        }
     
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistrationController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistrationController/Create
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

        // GET: RegistrationController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistrationController/Edit/5
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

        // GET: RegistrationController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistrationController/Delete/5
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
