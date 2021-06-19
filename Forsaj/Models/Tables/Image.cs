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
        public Image()
        {
            Posts = new HashSet<Post>();
        }

        [Column("ID")]
        public int Id { get; set; }

        [Column("URL")]
        [StringLength(250)]
        public string URL { get; set; }

        [Column("TYPE")]
        public int Type { get; set; }

        [Column("POST_ID")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
