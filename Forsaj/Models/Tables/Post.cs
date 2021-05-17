using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_POST")]
    public class Post
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(150)]

        public string Name { get; set; }
        [Column("KREDIT")]
        public bool Kredit { get; set; }
         
        [Column("BARTER")]
        public bool Barter   { get; set; }
        [Column("VIP")]
        public bool VIP { get; set; }
        [Column("COUNT")]
        public int Count { get; set; }
        [Column("PROBEG")]
        public int Probeg { get; set; }
        [Column("PRICE")]
        public int Price { get; set; }
        [Column("STATUS")]
        public int Status { get; set; }
        [Column("NOTE")]
        public string Note { get; set; }
        [Column("TELEFON")]
        public string Telefon { get; set; }
        [Column("CREATE_DATE")]

        public DateTime CreateDate { get; set; }
        [Column("UPDATE_DATE")]

        public DateTime UpdateDate { get; set; }

        [ForeignKey("UserId")]
        [Column("USER_ID")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("PowerId")]
        [Column("POWER_ID")]
        public int? PowerId { get; set; }
        public virtual Power Power { get; set; }
        [ForeignKey("YearId")]
        [Column("YEAR_ID")]
        public int? YearId { get; set; }
        public virtual Year Year { get; set; }

        [ForeignKey("Speed_Type_Id")]
        [Column("SPEED_TYPE_ID")]
        public int? Speed_Type_Id { get; set; }
        public virtual Speed_Type Speed_Type { get; set; }

        [ForeignKey("Transmission_Id")]
        [Column("TRANMISSION_ID")]
        public int? Transmission_Id { get; set; }
        public virtual Transmission Transmission { get; set; }

        [ForeignKey("Fuel_Type_Id")]
        [Column("FUEL_TYPE_ID")]
        public int? Fuel_Type_Id { get; set; }
        public virtual Fuel_Type Fuel_Type { get; set; }

        [ForeignKey("Currency_Id")]
        [Column("CURRENCY_ID")]
        public int? Currency_Id { get; set; }
        public virtual Currency Currency { get; set; }

        [ForeignKey("Color_Id")]
        [Column("COLOR_ID")]
        public int? Color_Id { get; set; }
        public virtual Color Color { get; set; }

        [ForeignKey("Country_Id")]
        [Column("COUNTRY_ID")]
        public int? Country_Id { get; set; }
        public virtual Country Country { get; set; }

        [ForeignKey("City_Id")]
        [Column("CITY_ID")]
        public int? City_Id { get; set; }
        public virtual City City { get; set; }

        [ForeignKey("Ban_Type_Id")]
        [Column("BAN_TYPE_ID")]
        public int? Ban_Type_Id { get; set; }
        public virtual Ban_Type Ban_Type { get; set; }


        [ForeignKey("Company_Id")]
        [Column("COMPANY_ID")]
        public int? Company_Id { get; set; }
        public virtual Company Company { get; set; }

        [ForeignKey("Model_Cars_Id")]
        [Column("MODEL_CARS_ID")]
        public int? Model_Cars_Id { get; set; }
        public virtual Model_Cars Model_Cars { get; set; }

        [ForeignKey("Details_Id")]
        [Column("DETAIL_ID")]
        public int? Details_Id { get; set; }
        public virtual Details Details { get; set; }

        public virtual List<Post_Images> Post_Images { get; set; }
    }
}
