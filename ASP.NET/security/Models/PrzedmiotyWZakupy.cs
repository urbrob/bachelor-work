using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZakupyOnline.Models
{
    public class PrzedmiotyWZakupy
    {
        public int item_id { get; set; }
        public int shopping_id { get; set; }
        public bool in_cart { get; set; }
        [Key]
        public int ID { get; set; }

    }
}
