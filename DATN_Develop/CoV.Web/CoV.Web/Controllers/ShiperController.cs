﻿using System.Linq;
using System.Linq.Dynamic;
using CoV.Common.Infrastructure;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class ShiperController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IProductService _productService;
        private readonly IProductDetailsService  _productDetailsService;

        public ShiperController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
        }
        // GET
        public IActionResult NhanHang()
        {
            var order = _orderDetailsService.GetAll().Where(x => x.StatusId == 5 );
            return
                View(order);
        }
        
        /// <summary>
        /// Dang giao san pham
        /// </summary>
        /// <returns></returns>
        public IActionResult DangGiao()
        {
            var name = HttpContext.User.Identity.Name;
            var order = _orderDetailsService.GetAll().Where(x => x.StatusId == 4 && x.Shipper.Equals(name) ); //dang giao
            return
                View(order);
        }
        
        /// <summary>
        /// giao thanh cong don hang
        /// </summary>
        /// <returns></returns>
        public IActionResult Giaothanhcong()
        {
            var name = HttpContext.User.Identity.Name;
            var order = _orderDetailsService.GetAll().Where(x => x.StatusId == 3 && x.Shipper.Equals(name) ); // giao thanh công
            return
                View(order);
        }

        
        /// <summary>
        /// salary shipper
        /// </summary>
        /// <returns></returns>
        public IActionResult ShiperSalary()
        {
            var name = HttpContext.User.Identity.Name;
            var order = _orderDetailsService.GetAll().Where(x => x.StatusId == 3 && x.Shipper.Equals(name) );
            ShipperSalaryViewModel shipperSalaryViewModel = new ShipperSalaryViewModel();
            shipperSalaryViewModel.TotalOrder = order.Count();
            shipperSalaryViewModel.Name = name;
            foreach (var item in order)
            {
                shipperSalaryViewModel.TotalMoney += item.TotalMoney;
                shipperSalaryViewModel.TotalShip += 30000;
                shipperSalaryViewModel.TotalProduct += item.NumberProduct;
            }
            ViewBag.ship = shipperSalaryViewModel;
            return View();
        }
        
    }
}