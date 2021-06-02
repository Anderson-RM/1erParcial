using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Parcial1.Models; 

 

namespace Parcial1.DAL
{
    public class Contexto : DbContext
    {
        public int MyProperty { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Parcial1.db");

        }
    }
}
