using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temp.Common.Infrastructure;
using Temp.Service.Service;

namespace Temp.Web.Controllers
{
    [Authorize(Policy = Constants.Role.Admin)]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService1;

        public MenuController(IMenuService menuService)
        {
            _menuService1 = menuService;
        }
        public IActionResult Index()
        {
            var menu = _menuService1.GetAll();
            return View(menu);
        }
    }
}
