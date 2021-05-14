using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace s4lab4
{
    public class tph : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }

    }

}
