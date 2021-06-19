using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forsaj.Extensions;
using Forsaj.Models;
using Forsaj.Models.Tables;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forsaj.Controllers
{
    public class FormController : Controller
    {
        private readonly ForsajContext _context;
        private readonly IHostingEnvironment _env;
        public FormController(ForsajContext context,IHostingEnvironment env )
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create( int modelId, int currencyId,int fuelTypeId, int banTypeId, int transmissionsId, int colorCarId, int yearId, int price,int powerId,
            string note,bool abs,bool disk,bool salon,bool centralSistem,bool parkRadar,bool ksenon, bool conditioner,bool lyuk,string username,string email,
             string telefonNumber,int cityId, IFormFile[] file,bool postType,int probeg,int speedTypeId,bool kredit,bool barter,int hpower)
        {

            try
            {
                List<string> attacList = new List<string>();
                var user = new User();
                user.First_Name = username;
                user.Email = email;
                user.PASSWORD = "12345";
                _context.Users.Add(user).GetDatabaseValues();
                _context.SaveChanges();
                var newTelefon = new Telefon();
                newTelefon.Number = telefonNumber;
                _context.Telefons.Add(newTelefon).GetDatabaseValues();
                _context.SaveChanges();

                _context.UserAndRoles.Add(new UserAndRole()
                {
                    UserId = user.Id,
                    RoleId = 3
                });
                _context.SaveChanges();

                _context.UserAndTelefons.Add(new UserAndTelefon()
                {
                    UserId = user.Id,
                    TelefonId = newTelefon.Id
                });
                _context.SaveChanges();

                var details = new Details();
                details.Ksenon = ksenon;
                details.Lyuk = lyuk;
                details.Model_Cars_Id = modelId;
                details.Park_Radar = parkRadar;
                details.Salon = salon;
                details.ABS = abs;
                details.Central_Sistem = centralSistem;
                details.Conditioner = conditioner;
                details.Disk = disk;

                _context.Details.Add(details).GetDatabaseValues();
                _context.SaveChanges();

                foreach (IFormFile document in file)
                {
                    if (!document.IsFile())
                    {


                        return Json(new { status = "error", message = "Faylın formatı düzgün seçilməmişdir. " });
                    }
                    string attachUrl = await document.SaveImagesAsync(_env.WebRootPath, "Files2021");

                    if (attachUrl == null)
                    {
                        return Json(new { status = "error", message = "Faylın formatı düzgün seçilməmişdir. " });
                    }

                    attacList.Add(attachUrl);

                }


                var form = new Post();
                form.Ban_TypeId = banTypeId;
                form.CountryId = 1;
                form.CityId = cityId;
                form.ColorId = colorCarId;
                form.CurrencyId = currencyId;
                form.Fuel_TypeId = fuelTypeId;
                form.Model_CarsId = modelId;
                form.PowerId = powerId;
                form.Price = price;
                form.Probeg = probeg;
                form.Speed_TypeId = speedTypeId;
                form.Status = 1;
                form.Telefon = telefonNumber;
                form.TransmissionId = transmissionsId;
                form.VIP = postType;
                form.YearId = yearId;
                form.Email = email;
                form.Kredit = kredit;
                form.Barter = barter;
                form.Note = note;
                form.DetailsId = details.Id;
                form.UserId = user.Id;
                form.Name = username;
                form.HPower = hpower;
                


                _context.Posts.Add(form).GetDatabaseValues();
                _context.SaveChanges();

                foreach (string item in attacList)
                {
                    Image attachment = new Image()
                    {
                        CreateDate = DateTime.Now,
                        PostId = form.Id,
                        URL = item,
                        Type = 1
                    };
                    _context.Add(attachment);
                    _context.SaveChanges();
                }

                return Json(new { status = "success", message = "Elan uğurla yerinə yetirildi,qisa müddət erzində saytda yerləşdiriləcəkdir!" });

            }
            catch (Exception ex)
            {

                return Json(new { status = "error", message = ex.Message });

            }



        }
    }
}
