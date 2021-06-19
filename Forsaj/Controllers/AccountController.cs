using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Forsaj.Models;
using Forsaj.Models.Tables;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Forsaj.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly ForsajContext _context;
        public AccountController(ForsajContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Login( string Email, string Password)
        {
           
            if(!_context.Users.Any(c=>c.Email.ToLower()==Email.ToLower() && c.PASSWORD == Password))
            {
                return Json((status: "error", message: "Email və ya şifrə yanlişdir!"));
            }
            var status = SignInUser(Email);
            if (status)
            {
                return Json(new { status = "success", message = "Əməliyyat uğurla yerinə yetirildi." });

            }
            return   Json((status: "error", message: "Email və ya şifrə yanlişdir!"));
        }

        public IActionResult Registration()
        {
            return View();
        }
            [HttpPost]
        public IActionResult Registration(string Username,string PhoneNumber, string Email,string Password)
        {

           var checkEmail= _context.Users.Any(c => c.Email.ToLower() == Email.ToLower());
            var checkPhone = _context.Telefons.Any(c => c.Number == PhoneNumber);

            if (checkEmail)
            {
                return Json(new { status = "error", message = "Bu email qeydiyyatdan keçib!" });

            }
            else if (checkPhone)
            {
                return Json(new { status = "error", message = "Bu nömrə qeydiyyatdan keçib!" });
            }
            else {

                var user = new User();
                user.First_Name = Username;
                user.PASSWORD = Password;
                user.Email = Email;
                _context.Users.Add(user).GetDatabaseValues();
                _context.SaveChanges();
                _context.UserAndRoles.Add(new UserAndRole()
                {
                     RoleId=3,
                     UserId=user.Id
                });

                var telefon = new Telefon();
                telefon.Number = PhoneNumber;
                _context.Telefons.Add(telefon).GetDatabaseValues();
                _context.SaveChanges();

                _context.UserAndTelefons.Add(new UserAndTelefon()
                {
                     TelefonId=telefon.Id,
                      UserId=user.Id
                });
                _context.SaveChanges();
                return Json(new { status = "success", message = "Əməliyyat uğurla yerinə yetirildi." });

            }

        }


        private bool SignInUser(string Email)
        {
            System.Net.IPAddress remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            string browserInfo = Request.Headers["User-Agent"].ToString();
          var user=  _context.Users.Where(c => c.Email == Email).First();
            try
            {
                List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.First_Name),
                 
            };
                foreach (var r in user.UserAndRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, r.Role.Name));
                }
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                  HttpContext.SignInAsync(principal);
                Thread.CurrentPrincipal = principal;

                _context.Login_Logs.Add(new Login_Log()
                {
                    Browser = browserInfo,
                    IP = remoteIpAddress.ToString(),
                    Email = user.Email,
                    Success = true,
                    Url = ControllerContext.ActionDescriptor.ControllerName + "/" + ControllerContext.ActionDescriptor.ActionName
                });
                return _context.SaveChanges()>0;
               // return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                _context.Login_Logs.Add(new Login_Log()
                {
                    Browser = browserInfo,
                    IP = remoteIpAddress.ToString(),
                    Error = ex.InnerException.Message,
                    Email = user.Email,
                    Success = false,
                    Url = ControllerContext.ActionDescriptor.ControllerName + "/" + ControllerContext.ActionDescriptor.ActionName
                });
                _context.SaveChanges();

                ViewBag.ErrorMessage = "İstifadəçi adı və ya şifrə yanlışdır.";
                return false;
            }
        }

        public IActionResult AccessDenied( )
        {
            return Json("access denied");
        }
        public async Task<IActionResult> LogOut()
        {
            string usermail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;
            System.Net.IPAddress remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            string browserInfo = Request.Headers["User-Agent"].ToString();
            _context.Login_Logs.Add(new Login_Log()
            {
                Browser = browserInfo,
                IP = remoteIpAddress.ToString(),
                Email = usermail,
                Success = true,
                Url = ControllerContext.ActionDescriptor.ControllerName + "/" + ControllerContext.ActionDescriptor.ActionName
            });
            _context.SaveChanges();

            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
