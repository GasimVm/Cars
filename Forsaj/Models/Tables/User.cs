using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_USERS")]
    public class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }
        [Column("ID")]
        public int Id { get; set; }

        [Column("FIRST_NAME")]
        [StringLength(150)]
        public string First_Name { get; set; }

        [Column("EMAIL")]
        [StringLength(150)]
        public string Email { get; set; }

        [Column("PASSWORD")]
        [StringLength(150)]
        public string PASSWORD { get; set; }

        [ForeignKey("CompanyId")]
        [Column("COMPANY_ID")]
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual List<UserAndRole> UserAndRoles { get; set; }

        public virtual List<UserAndTelefon>  UserAndTelefons { get; set; }

        public virtual ICollection<Post> Posts { get; set; }


    }
}
