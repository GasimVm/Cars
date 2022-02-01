using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Forsaj.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Forsaj.Models.Tables;
using System.Drawing;
using Image = System.Drawing.Image;
using ImageMagick;
using System.Drawing.Drawing2D;
using GroupDocs.Watermark.Search;
using GroupDocs.Watermark;
using GroupDocs.Watermark.Watermarks;
using System.IO;
using TinifyAPI;
using ImageProcessor;
using ImageProcessor.Plugins.WebP.Imaging.Formats;
using Microsoft.AspNetCore.Http;

namespace Forsaj.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ForsajContext _context;
        private readonly IHostingEnvironment _env;
        public HomeController(ForsajContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.City = _context.Cities.ToList();
            ViewBag.Year = _context.Years.ToList();


            var model = _context.Posts.Where(c => c.CreateDate < DateTime.Now.AddDays(30)).ToList() ;
            var images = _context.Images.Where(c => c.CreateDate < DateTime.Now.AddDays(30)).ToList();
            
            ViewBag.Images = images;
            return View(model);
        }

        public IActionResult AddPost()
        {
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.City = _context.Cities.ToList();
            ViewBag.Ban_Type = _context.Ban_Types.ToList();
            ViewBag.Transmissions = _context.Transmissions.ToList();
            ViewBag.Speed_Types = _context.Speed_Types.ToList();
            ViewBag.Currencies = _context.Currencies.ToList();
            ViewBag.Fuel_Types = _context.Fuel_Types.ToList();
            ViewBag.Powers = _context.Powers.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Years = _context.Years.ToList();

            return View();
        }
        public IActionResult Filter()
        {
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.City = _context.Cities.ToList();
            ViewBag.Ban_Type = _context.Ban_Types.ToList();
            ViewBag.Transmissions = _context.Transmissions.ToList();
            ViewBag.Speed_Types = _context.Speed_Types.ToList();
            ViewBag.Currencies = _context.Currencies.ToList();
            ViewBag.Fuel_Types = _context.Fuel_Types.ToList();
            ViewBag.Powers = _context.Powers.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Years = _context.Years.ToList();




            return View();
        }

        public IActionResult Carfax()
        {
            



            return View();
        }

        public IActionResult Details(int id)
        {
            var postCar = _context.Posts.Where(c => c.Id == id).First();
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.Post = postCar;



            var model = _context.Posts.Where(c => c.CreateDate < DateTime.Now.AddDays(30) && c.Model_CarsId== postCar.Model_CarsId && c.Id!=id).Take(8).ToList();
            var user = _context.Users.Where(c=>c.Id==5);
            var images = _context.Images.Where(c => c.CreateDate < DateTime.Now.AddDays(30)).ToList();
            ViewBag.Images = images;
            ViewBag.CarImage = _context.Images.Where(c => c.PostId == id).ToList();
            return View(model);
        }


        public IActionResult Makes(int id)
        {
            var model = _context.Posts.Where(c => c.Model_Cars.MarkaId==id ).ToList();
            ViewBag.ModelCars = _context.Model_Cars.Where(c=>c.MarkaId==id).ToList();
            return View(model);
        }

        public IActionResult ModelCars(int id)
        {


            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            var model = _context.Posts.Where(c =>c.Model_CarsId==id  ).ToList();
            var images = _context.Images.ToList();

     
            ViewBag.Images = images;
            return View(model);
        }


        #region Pulsuz 900kb salir
        //public static void resizeImage(string url, Size size)
        //{
        //    string firstText = "Kuza.az";
        //    PointF firstLocation = new PointF(10f, 10f);
        //    using (Image image = Image.FromFile(url))
        //    {
        //        using (Bitmap newImage = new Bitmap(image, size))
        //        {
        //            image.Dispose();
        //            newImage.Save(url);
        //            using (MagickImage imageCom = new MagickImage(url))
        //            {
        //                imageCom.Format = imageCom.Format; // Get or Set the format of the image.
        //                newImage.Dispose();
        //                imageCom.Resize(size.Width, size.Height);
                   
        //                imageCom.Quality = 100; // This is the Compression level.
                    
        //                imageCom.Write(url);
        //            }

        //        }
        //    }
           
        //}
        #endregion

        public   void rezizeImage(IFormFile image)
        {
            string imagesPath = Path.Combine(_env.WebRootPath, "images");
            string webPFileName = Path.GetFileNameWithoutExtension(image.FileName) + ".webp";
            string normalImagePath = Path.Combine(imagesPath, image.FileName);
            string webPImagePath = Path.Combine(imagesPath, webPFileName);

            // Save the image in its original format for fallback
            using (FileStream normalFileStream = new FileStream(normalImagePath, FileMode.Create))
            {
                image.CopyTo(normalFileStream);
            }
            // Then save in WebP format
            using (FileStream webPFileStream = new FileStream(webPImagePath, FileMode.Create))
            {
                using (ImageFactory imageFactory = new ImageFactory(preserveExifData: false))
                {
                    imageFactory.Load(image.OpenReadStream())
                                .Format(new WebPFormat())
                                .Quality(50)
                                .Save(webPFileStream);
                }
            }


        }

        #region Pullu
        //public async void CompressImage(string url)
        //{
        //    Tinify.Key = "9438wTJW3BGz79sWfGdcb6W5jhbrm1Z2"; //TinyPNG Developer API KEY
        //    string sFilePath = url;
        //    string sOptimizedFile = url;
        //    var source = Tinify.FromFile(sFilePath);
        //    await source.ToFile(sOptimizedFile);
        //}

        #endregion
        public static void AddText(string text,string url)
        {
            var bmp = Bitmap.FromFile(url);
            var newImage = new Bitmap(bmp.Width, bmp.Height + 20);

            var gr = Graphics.FromImage(newImage);
            gr.DrawImageUnscaled(bmp, 0, 0);
            gr.DrawString(text, new System.Drawing.Font("Times New Roman", 20), Brushes.Black,
                new RectangleF(40, bmp.Height-60, bmp.Width-20, 40));
            bmp.Dispose();
            newImage.Save(url);
        }
        //public   void AddText2(string text, string url)
        //{
        //    using (StreamWriter writer = new StreamWriter("hsn2.png", true))
        //    {
        //        using (StreamWriter writerImage = new StreamWriter(text, true))
        //        {
        //            using (Watermarker watermarker = new Watermarker(url))
        //            {
        //                using (ImageWatermark watermark = new ImageWatermark(_env.WebRootPath + "/Custom/images/hsn2.png"))
        //                {
        //                    // Set Watermark Properties
        //                    watermark.X = 20;
        //                    watermark.Y = 80;
        //                    // Add watermark on image file and save the output
        //                    watermarker.Add(watermark);
        //                    watermark.Dispose();
        //                    watermarker.Save(writerImage.);
        //                }
        //            }
        //        }
        //    }

          


        //}




        public bool Test(string url,string filename)
        {



            //AddText2(filename, url);

            //resizeImage(url, new Size(1024, 768));
            //AddText("Kuza.az", url);
            return true;
        }
        public IActionResult AllPost(bool isVip=false)
        {
            List<Post> model = new List<Post>();
           
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            var images = _context.Images.Where(c => c.CreateDate < DateTime.Now.AddDays(30)).ToList();
            ViewBag.Images = images;
            if (isVip)
            {
                model = _context.Posts.Where(c => c.CreateDate < DateTime.Now.AddDays(30) && c.VIP == isVip).ToList();

            }
            else
            {
                model = _context.Posts.Where(c => c.CreateDate < DateTime.Now.AddDays(30) ).ToList();

            }
            return View(model);
            
        }
    }
}
