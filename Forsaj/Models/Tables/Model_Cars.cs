using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_MODEL_CARS")]
    public class Model_Cars
    {
        public Model_Cars()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(150)]
        public string Name { get; set; }

        [ForeignKey("MarkaId")]
        [Column("MARKA_ID")]
        public int? MarkaId { get; set; }
        public virtual Marka  Marka { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
