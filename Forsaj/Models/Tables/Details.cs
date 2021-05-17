using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_DETAILS")]
    public class Details
    {
        public Details()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }
        [Column("ABS")]  
        public bool ABS { get; set; }
        [Column("DISK")]
        public bool Disk { get; set; }
        [Column("SALON")]
        public bool Salon { get; set; }
        [Column("CREATE_SISTEM")]
        public bool Central_Sistem { get; set; }
        [Column("PARK_RADAR")]
        public bool Park_Radar { get; set; }
        [Column("KSENON")]
        public bool Ksenon { get; set; }
        [Column("LYUK")]
        public bool Lyuk { get; set; }

        public virtual ICollection<Post> Posts { get; set; }


    }
}
