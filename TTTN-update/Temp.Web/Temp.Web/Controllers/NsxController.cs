using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Temp.Service.DTO;
using Temp.Service.Service;
using Temp.Common.Infrastructure;

namespace Temp.Web.Controllers
{
    [Authorize(Policy = Constants.Role.Admin)]
    public class NsxController : Controller
    {
        private readonly INsxService _nsxService;

        public NsxController(INsxService nsxService)
        {
            _nsxService = nsxService;
        }

        public IActionResult Index()
        {
            var nsx = _nsxService.GetAll();
            return View(nsx);
        }

        [HttpGet]
        public IActionResult Save(int id)
        {
            if (id <= 0)
            {
                return View();
            }
            return View(_nsxService.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(NsxDto nsxDto)
        {
            if (string.IsNullOrEmpty(nsxDto.Name))
            {
                ModelState.AddModelError(string.Empty, "Khong duoc de trong");
                return View();
            }
            else
            {
                if (_nsxService.CheckExits(nsxDto))
                {
                    _nsxService.Save(nsxDto);
                    return RedirectToAction("Index", "Nsx");
                }
                //them moi else trar message trung

                else
                {
                    ModelState.AddModelError(string.Empty, "Name da bi trung");
                    return View();
                }

            }

            
        }

        public IActionResult Delete(int id)
        {
            _nsxService.Delete(id);
            return RedirectToAction("Index", "Nsx");
        }
    }
}