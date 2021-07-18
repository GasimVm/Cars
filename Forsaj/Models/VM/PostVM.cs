using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.VM
{
    public class PostVM
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }

        public string Model { get; set; }

        public string Marka { get; set; }

        public int Year { get; set; }

        public int Power { get; set; }
        public int Probeg { get; set; }

        public string CreateDate { get; set; }

        public int Count { get; set; }
    }
}
