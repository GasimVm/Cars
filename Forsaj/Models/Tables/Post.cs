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

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("FIRST_IMAGE")]
        public string First_Image { get; set; }

        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }
        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }


        public int HPower { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        
        
        public int? PowerId { get; set; }
        public virtual Power Power { get; set; }
      
        
        public int? YearId { get; set; }
        public virtual Year Year { get; set; }

       
        
        public int? Speed_TypeId { get; set; }
        public virtual Speed_Type Speed_Type { get; set; }

        
        
        public int? TransmissionId { get; set; }
        public virtual Transmission Transmission { get; set; }

        
         
        public int? Fuel_TypeId { get; set; }
        public virtual Fuel_Type Fuel_Type { get; set; }

         
        
        public int? CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

         
        public int? ColorId { get; set; }
        public virtual Color Color { get; set; }

        
        
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }

        
         
        public int? CityId { get; set; }
        public virtual City City { get; set; }

        
        
        public int? Ban_TypeId { get; set; }
        public virtual Ban_Type Ban_Type { get; set; }


         
        
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        
         
        public int? Model_CarsId { get; set; }
        public virtual Model_Cars Model_Cars { get; set; }

        
        
        public int? DetailsId { get; set; }
        public virtual Details Details { get; set; }

    }
}
