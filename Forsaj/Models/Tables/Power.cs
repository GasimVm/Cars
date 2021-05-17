using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_POWER")]
    public class Power
    {
        public Power()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("CAPACITY")]
        public int Capacity { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
