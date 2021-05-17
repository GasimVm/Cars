using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_MARKA")]
    public class Marka
    {
        public Marka()
        {
            Model_Cars = new HashSet<Model_Cars>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Model_Cars>  Model_Cars { get; set; }
    }
}
