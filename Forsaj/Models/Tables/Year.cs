using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_YEAR")]
    public class Year
    {
        public Year()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("CREATE_YEAR")]
        public int Create_Year { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
