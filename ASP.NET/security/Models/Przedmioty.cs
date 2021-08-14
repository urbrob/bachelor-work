using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZakupyOnline.Models
{
    public class Przedmioty
    {
        public int Price { get; set; }
        public string Name { get; set; }
        [Key]
        public int ID { get; set; }
    }
}
