using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("TBL_TELEFON")]
    public class Telefon
    {

        [Column("ID")]
        public int Id { get; set; }

        [Column("NUMBER")]
        [StringLength(150)]
        public string Number { get; set; }

        public virtual List<UserAndTelefon> UserAndTelefons { get; set; }


    }
}
