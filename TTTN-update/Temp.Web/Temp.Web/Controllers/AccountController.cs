﻿using Microsoft.AspNetCore.Mvc;
using Temp.Service.Service;
using Temp.Service.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Temp.Common.Infrastructure;
using Temp.Common.Resources;
using Serilog;

namespace Temp.Web.Controllers
{   
    /// <summary>
    /// Account controller
    /// </summary>
    public class AccountController : Controller
    {
        private readonly IAccountService _account;
        

        public AccountController(IAccountService account)
        {
            _account = account;
            
        }
        
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult LogIn(string returnUrl = null)
        {
            var login = new LogInDto { ReturnUrl = returnUrl };
            return View(login);
        }
        
        [HttpPost]  
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LogInDto logInDto)
        {
            if (ModelState.IsValid)
            {
                var user = _account.LogIn(logInDto);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, MessageResource.UserLoginFailed);
                    Log.Error(MessageResource.UserLoginFailed);
                    return View(logInDto);
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.Role.Name),
                    new Claim(Constants.ClaimName.AccountId, user.Id.ToString())
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);                
                if (user.RoleId == (int)Role.Admin || user.RoleId == (int)Role.Manager || user.RoleId == (int)Role.Shipper)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Home", "Home");
                }

            }
            return View(logInDto);          
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.Remove("cart");
            Response.Cookies.Delete(ClaimTypes.Name);
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Home","Home");
        }
        
        /// <summary>
        /// register
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateAccDto accDto)
        {
            if (ModelState.IsValid)
            {
                if (!_account.CheckAccount(accDto))
                {
                    ModelState.AddModelError(string.Empty, MessageResource.AccountValid);
                    return View(accDto);
                }

                if (!accDto.Password.Equals(accDto.ConfirmPass))
                {
                    ModelState.AddModelError(string.Empty, MessageResource.Compare);
                    return View(accDto);
                }
                _account.CreateAccount(accDto);
                return RedirectToAction("LogIn", "Account");
            }
            else
            {
                ModelState.AddModelError(string.Empty, MessageResource.SignupFail);
                Log.Error(MessageResource.SignupFail);
            }

            return View(accDto);
        }
        
        /// <summary>
        /// Change password
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ChangePass()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePass(ChangePassDto passDto)
        {
            if (!_account.CheckPass(passDto))
            {
                ModelState.AddModelError("",MessageResource.InvalidCredentials);
            } else if (passDto.Password != passDto.ConfirmPass)
            {
                ModelState.AddModelError("",MessageResource.Compare);
            }
            else                                    
            if (_account.ChangePass(passDto))
            {
                return RedirectToAction("LogIn","Account");
            }
            else
            {
                ModelState.AddModelError("",MessageResource.ChangePassFailed);
            }

            return View(passDto);
        }
        
        /// <summary>
        /// user request expired date
        /// </summary>
        /// <returns></returns>
        public IActionResult RequestExpiredDate()
        {
            string name = HttpContext.User.Identity.Name;
            var user = _account.GetAccount(name);           
            _account.RequestExpired(user);                                 
            return RedirectToAction("Index","Admin");
        }               
    }
}