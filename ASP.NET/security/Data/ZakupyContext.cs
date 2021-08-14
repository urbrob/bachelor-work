using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZakupyOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace ZakupyOnline.Data
{
    public class ZakupyContext : DbContext
    {
        public ZakupyContext(DbContextOptions<ZakupyContext> options)
            : base(options)
        {
        }

        public DbSet<Zakupy> Zakupy { get; set; }
        public DbSet<Przedmioty> Przedmioty { get; set; }
        public DbSet<PrzedmiotyWZakupy> PrzedmiotyWZakupy { get; set; }
    }
}
