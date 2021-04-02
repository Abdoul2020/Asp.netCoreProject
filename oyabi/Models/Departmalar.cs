using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace oyabi.Models
{
    public class Departmalar
    {
        [Key]
        public int ID { get; set; }
        public string DepartmanAD { get; set; }
        public List<Personel> perso { get; set; }
    }
}
