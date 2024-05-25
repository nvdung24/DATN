using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CoV.Common.Infrastructure;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class StatisticalController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IProductService _productService;
        private readonly IProductDetailsService  _productDetailsService;

        public StatisticalController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
        }
        /// <summary>
        ///  get bieu do doanh thu
        /// </summary>
        /// <returns></returns>
        [Authorize (Policy = Constants.RolePolice.Accountant)]
        public IActionResult Index()
        {
            var order = _orderDetailsService.GetAll().Where(x => x.StatusId == 3 && 
            x.EndDate.Value.ToString("MM") == DateTime.Now.ToString("MM") && 
            x.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy"));
            ViewBag.orderCount = order.Count();
            List<OrderDetailsViewModel> model = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                model.Add(item);
            }
            //so san pham 
            var numberProduct = 0;
            //so tiem
            var totalMoney = 0;
            foreach (var item in model)
            {
                numberProduct += item.NumberProduct;
                totalMoney += item.TotalMoney;
                
            }
            ViewBag.numberProduct = numberProduct;
            ViewBag.TotalMoney = totalMoney;
            //phi ship
            ViewBag.salary = order.Count() * 30000;


            var order2 = _orderDetailsService.GetAll().Where(x => x.StatusId == 3);

            //January
            List<OrderDetailsViewModel> january = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "01" 
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {  
                    january.Add(item);  
            }

            var numberProductM1 = 0;
            var totalMoneyM1 = 0;
            foreach (var item in january)
            {
                numberProductM1 += item.NumberProduct;
                totalMoneyM1 += item.TotalMoney;
            }
            ViewBag.january = numberProductM1; // so san pham
            ViewBag.januaryTotal = totalMoneyM1; // doanh thu thang 1
            
            //February
            List<OrderDetailsViewModel> february = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "02"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                february.Add(item);
            }

            var numberProductM2 = 0;
            var totalMoneyM2 = 0;
            foreach (var item in february)
            {
                numberProductM2 += item.NumberProduct;
                totalMoneyM2 += item.TotalMoney;
            }
            ViewBag.february = numberProductM2;
            ViewBag.februaryTotal = totalMoneyM2;
            
            //March
            List<OrderDetailsViewModel> march = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "03"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                march.Add(item);
            }

            var numberProductM3 = 0;
            var totalMoneyM3 = 0;
            foreach (var item in march)
            {
                numberProductM3 += item.NumberProduct;
                totalMoneyM3 += item.TotalMoney;
            }
            ViewBag.march = numberProductM3;
            ViewBag.marchTotal = totalMoneyM3;
            
            
            //April
            List<OrderDetailsViewModel> april = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "04"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                april.Add(item);
            }

            var numberProductM4 = 0;
            var totalMoneyM4 = 0;
            foreach (var item in april)
            {
                numberProductM4 += item.NumberProduct;
                totalMoneyM4 += item.TotalMoney;
            }
            ViewBag.april = numberProductM4;
            ViewBag.aprilTotal = totalMoneyM4;
            
            //May
            List<OrderDetailsViewModel> may = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "05"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                may.Add(item);
            }

            var numberProductM5 = 0;
            var totalMoneyM5 = 0;
            foreach (var item in may)
            {
                numberProductM5 += item.NumberProduct;
                totalMoneyM5 += item.TotalMoney;
            }
            ViewBag.may = numberProductM5;
            ViewBag.mayTotal = totalMoneyM5;
            
            //June
            List<OrderDetailsViewModel> june = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "06"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                june.Add(item);
            }

            var numberProductM6 = 0;
            var totalMoneyM6 = 0;
            foreach (var item in june)
            {
                numberProductM6 += item.NumberProduct;
                totalMoneyM6 += item.TotalMoney;
            }
            ViewBag.June = numberProductM6;
            ViewBag.JuneTotal = totalMoneyM6;
            
            //July
            List<OrderDetailsViewModel> july = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "07"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                july.Add(item);
            }

            var numberProductM7 = 0;
            var totalMoneyM7 = 0;
            foreach (var item in july)
            {
                numberProductM7 += item.NumberProduct;
                totalMoneyM7 += item.TotalMoney;
            }
            ViewBag.July = numberProductM7;
            ViewBag.JulyTotal = totalMoneyM7;
            
            //August
            List<OrderDetailsViewModel> august = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "08"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                august.Add(item);
            }

            var numberProductM8 = 0;
            var totalMoneyM8 = 0;
            foreach (var item in august)
            {
                numberProductM8 += item.NumberProduct;
                totalMoneyM8 += item.TotalMoney;
            }
            ViewBag.august = numberProductM8;
            ViewBag.augustTotal = totalMoneyM8;
            
            //September
            List<OrderDetailsViewModel> september = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "09"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                september.Add(item);
            }

            var numberProductM9 = 0;
            var totalMoneyM9 = 0;
            foreach (var item in september)
            {
                numberProductM9 += item.NumberProduct;
                totalMoneyM9 += item.TotalMoney;
            }
            ViewBag.september = numberProductM9;
            ViewBag.septemberTotal = totalMoneyM9;
            
            //October
            List<OrderDetailsViewModel> october = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "10"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                october.Add(item);
            }

            var numberProductM10 = 0;
            var totalMoneyM10 = 0;
            foreach (var item in october)
            {
                numberProductM10 += item.NumberProduct;
                totalMoneyM10 += item.TotalMoney;
            }
            ViewBag.october = numberProductM10; 
            ViewBag.octoberTotal = totalMoneyM10; 
            
            //november
            List<OrderDetailsViewModel> november = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "11"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                november.Add(item);
            }

            var numberProductM11 = 0;
            var totalMoneyM11 = 0;
            foreach (var item in november)
            {
                numberProductM11 += item.NumberProduct;
                totalMoneyM11 += item.TotalMoney;
            }
            ViewBag.november = numberProductM11;
            ViewBag.novemberTotal = totalMoneyM11;
            
            //December
            List<OrderDetailsViewModel> december = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "12"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.ToString("yyyy")))
            {
                december.Add(item);
            }

            var numberProductM12 = 0;
            var totalMoneyM12 = 0;
            foreach (var item in december)
            {
                numberProductM12 += item.NumberProduct;
                totalMoneyM12 += item.TotalMoney;
            }
            ViewBag.december = numberProductM12;
            ViewBag.decemberTotal = totalMoneyM12;

            //January nam truoc
            List<OrderDetailsViewModel> january1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "01"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                january1.Add(item);
            }
            var totalMoneyNN1 = 0;
            foreach (var item in january1)
            {
                totalMoneyNN1 += item.TotalMoney;
            }
            ViewBag.januaryTotal1 = totalMoneyNN1; // doanh thu thang 1

            //t2 nam truoc
            List<OrderDetailsViewModel> february1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "02"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                february1.Add(item);
            }
            var totalMoneyNN2 = 0;
            foreach (var item in february1)
            {
                totalMoneyNN2 += item.TotalMoney;
            }
            ViewBag.februaryTotal1 = totalMoneyNN2; // doanh thu thang 2

            //t3
            List<OrderDetailsViewModel> march1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "03"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                march1.Add(item);
            }
            var totalMoneyNN3 = 0;
            foreach (var item in march1)
            {
                totalMoneyNN3 += item.TotalMoney;
            }
            ViewBag.marchTotal1 = totalMoneyNN3; // doanh thu thang 2

            //t4
            List<OrderDetailsViewModel> april1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "04"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                april1.Add(item);
            }
            var totalMoneyNN4 = 0;
            foreach (var item in april1)
            {
                totalMoneyNN4 += item.TotalMoney;
            }
            ViewBag.aprilTotal1 = totalMoneyNN4; // doanh thu thang 2


            //t5
            List<OrderDetailsViewModel> may1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "05"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                may1.Add(item);
            }
            var totalMoneyNN5 = 0;
            foreach (var item in may1)
            {
                totalMoneyNN5 += item.TotalMoney;
            }
            ViewBag.mayTotal1 = totalMoneyNN5;

            //t6
            List<OrderDetailsViewModel> june1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "06"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                june1.Add(item);
            }
            var totalMoneyNN6 = 0;
            foreach (var item in june1)
            {
                totalMoneyNN6 += item.TotalMoney;
            }
            ViewBag.juneTotal1 = totalMoneyNN6;

            //t7
            List<OrderDetailsViewModel> july1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "07"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                july1.Add(item);
            }
            var totalMoneyNN7 = 0;
            foreach (var item in july1)
            {
                totalMoneyNN7 += item.TotalMoney;
            }
            ViewBag.julyTotal1 = totalMoneyNN7;

            //t8
            List<OrderDetailsViewModel> august1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "08"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                august1.Add(item);
            }
            var totalMoneyNN8 = 0;
            foreach (var item in august1)
            {
                totalMoneyNN8 += item.TotalMoney;
            }
            ViewBag.augustTotal1 = totalMoneyNN8;

            //t9
            List<OrderDetailsViewModel> september1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "09"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                september1.Add(item);
            }
            var totalMoneyNN9 = 0;
            foreach (var item in september1)
            {
                totalMoneyNN9 += item.TotalMoney;
            }
            ViewBag.septemberTotal1 = totalMoneyNN9;

            //t10
            List<OrderDetailsViewModel> october1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "10"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                october1.Add(item);
            }
            var totalMoneyNN10 = 0;
            foreach (var item in october1)
            {
                totalMoneyNN10 += item.TotalMoney;
            }
            ViewBag.octoberTotal1 = totalMoneyNN10;

            //t11
            List<OrderDetailsViewModel> november1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "11"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                november1.Add(item);
            }
            var totalMoneyNN11 = 0;
            foreach (var item in november1)
            {
                totalMoneyNN11 += item.TotalMoney;
            }
            ViewBag.novemberTotal1 = totalMoneyNN11;

            //t12
            List<OrderDetailsViewModel> december1 = new List<OrderDetailsViewModel>();
            foreach (var item in order2.Where(s => s.EndDate.Value.ToString("MM") == "12"
            && s.EndDate.Value.ToString("yyyy") == DateTime.Now.AddYears(-1).ToString("yyyy")))
            {
                december1.Add(item);
            }
            var totalMoneyNN12 = 0;
            foreach (var item in december1)
            {
                totalMoneyNN12 += item.TotalMoney;
            }
            ViewBag.decemberTotal1 = totalMoneyNN12;
            return
            View();
        }
    }
}