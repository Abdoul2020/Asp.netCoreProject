using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace oyabi.Models
{
    public class Personel
    {
        [Key]
        public int ID { get; set; }
        public string personelad { get; set; }
        public string personelsoyad { get; set; }
        public string personelsehir { get; set; }
        public int DepartmalarID { get; set; }
        public Departmalar depar { get; set; }
    }
}
