﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    
         [Table("TBL_TRANSMISSION")]
    public class Transmission
    {
        public Transmission()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
