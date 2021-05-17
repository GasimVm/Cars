using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    

    [Table("TBL_ROLE")]
    public class Role
    {

        [Column("ID")]
        public int RoleId { get; set; }

        [Column("NAME")]
        [StringLength(150)]
        public string Name { get; set; }

        public string Desc { get; set; }
        public virtual List<UserAndRole> UserAndRoles { get; set; }

    }
}
