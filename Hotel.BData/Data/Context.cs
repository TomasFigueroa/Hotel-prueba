using Hotel.BData.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BData.Data
{
    public class Context : DbContext
    {
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //public DbSet<Persona> Personas { get; set; }
        public DbSet<Habitacion> huespedes => Set<Habitacion>();
        public DbSet<Personas> Persona => Set<Personas>();

        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
