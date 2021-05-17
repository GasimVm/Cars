using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_IMAGE")]
    public class Image
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("URL")]
        [StringLength(250)]
        public string URL { get; set; }

        [Column("TYPE")]
        public int Type { get; set; }

        public virtual List<Post_Images> Post_Images { get; set; }

    }
}
