using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("USER_AND_ROLE")]
    public class UserAndRole
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("USER_ID")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Column("ROLE_ID")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }


    }
}
