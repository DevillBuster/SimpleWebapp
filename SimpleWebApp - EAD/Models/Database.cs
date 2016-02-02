using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp___EAD.Models
{
    public class MyDatabase : DbContext
    {
        public DbSet<Register> Register { get; set; }
    }
}
