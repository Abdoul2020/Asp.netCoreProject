using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace oyabi.Models
{
    public class Adminn
    {
        [Key]
        public int AdminID { get; set; }

       [Column(TypeName="varchar(20)")]
        public string kullanici { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string sifre { get; set; }
    }
}
