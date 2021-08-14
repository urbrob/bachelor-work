using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZakupyOnline.Models
{
    public class Zakupy
    {
        public string Date { get; set; }
        public bool Done { get; set; }
        [Key]
        public int ID { get; set; }

    }
}
