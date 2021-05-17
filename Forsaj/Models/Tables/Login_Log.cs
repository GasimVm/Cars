using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Models.Tables
{
    [Table("LOGIN_LOG")]
    public class Login_Log
    {


        public int Id { get; set; }
        [StringLength(1000)]
        public string Error { get; set; }
        [StringLength(150)]
        public string IP { get; set; }
        [StringLength(150)]
        public string Browser { get; set; }

        public bool Success { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Url { get; set; }


        public DateTime CreateDate { get; set; }

    }
}
