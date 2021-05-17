using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("USER_AND_TELEFON")]
    public class UserAndTelefon
    {

        [Column("ID")]
        public int Id { get; set; }

        [Column("USER_ID")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Column("TELEFON_ID")]
        public int TelefonId { get; set; }
        public virtual Telefon  Telefon { get; set; }

    }
}
