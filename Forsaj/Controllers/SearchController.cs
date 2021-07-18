using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forsaj.Models;
using Forsaj.Servicies;
using Microsoft.AspNetCore.Mvc;

namespace Forsaj.Controllers
{
    public class SearchController : Controller
    {
        private readonly ForsajContext _context;
        private readonly ISearch _search;
        public SearchController(ForsajContext context,ISearch search)
        {
            _context = context;
            _search = search;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FirstSearch(int? countryId, int? cityId, int? markaId, int? modelId, int? priceMax, int? priceMin, int? yearMax, int? yearMin)
        {
            try
            {
                var post = _search.GetPostFilter(countryId, cityId, markaId, modelId, priceMax, priceMin, yearMax, yearMin);
                string html = "";
                if (post.Count!=0)
                {
                    foreach (var item in post)
                    {
                        html += $@"<div class=""masinlar"">
         <a href=""../Home/Details?id={item.Id}"">
              <img src=""/Document/Files2021/{item.Url}"">
                 <div class=""cars__about_clr"">
                <div class=""cars__orders"">
                    <p>
                        {item.Price} {item.Currency}
                    </p>
                </div>
                <div class=""cars__info"">
                    <div>
                        <h5>{item.Model}</h5>
                        <h5>{item.Marka}</h5>
                    </div>
                </div>
                <ul>
                    <li>{item.Year} il</li>
                    <li>{item.Power}</li>
                    <li>{item.Probeg} km</li>
                </ul>
            </div>
        </a>
    </div>";
                    }
                }
                else
                {
                    html = "Uyğun nəticə tapilmadi";
                }
              
                return Json(new { status = "success", message = html });
            }
            catch (Exception)
            {

                return Json(new { status = "error", message = "Bağışlayın, göndərdiyiniz sorğu üzrə heç bir nəticə tapılmamışdır.Digər meyarlar üzrə axtarışa cəhd edin." });
            }
            
        }
    }
}
