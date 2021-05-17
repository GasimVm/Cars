using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("POST_IMAGES")]
    public class Post_Images
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("POST_ID")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        [Column("IMAGE_ID")]
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

    }
}
