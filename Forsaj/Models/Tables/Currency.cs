using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_CURRENCY")]
    public class Currency
    {
        public Currency()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("MONEY")]
        [StringLength(50)]
        public string Money { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
