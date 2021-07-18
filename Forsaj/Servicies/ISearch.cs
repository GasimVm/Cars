using Forsaj.Models.Tables;
using Forsaj.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Servicies
{
     public interface ISearch
    {

        public List<PostVM> GetPostFilter(int? countryId,int? cityId,int? markaId,int? modelId,int? priceMax,int? priceMin,int? yearMax,int? yearMin);
         
    }
}
