using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_CARS_DETAILS")]
    public class Cars_Details
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("DISKI")]
        public bool Diski { get; set; }

        [Column("QAPANMA")]
        public bool Qapanma { get; set; }

        [Column("DERI_SALON")]
        public bool Dəri_Salon { get; set; }
        [Column("ABS")]
        public bool ABS { get; set; }
        [Column("PARK_RADAR")]
        public bool Park_Radar { get; set; }
        [Column("KSENON_LAMPALAR")]
        public bool Ksenon_Lampalar { get; set; }
        [Column("LYUK")]
        public bool Lyuk { get; set; }
        [Column("KONDISIONER")]
        public bool Kondisioner { get; set; }
        [Column("KAMERA")]
        public bool Kamera { get; set; }
        [Column("SENSOR")]
        public bool Sensor { get; set; }

        
    }
}
