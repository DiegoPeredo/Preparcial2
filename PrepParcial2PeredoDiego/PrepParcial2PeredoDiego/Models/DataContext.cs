using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrepParcial2PeredoDiego.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<PrepParcial2PeredoDiego.Models.Person> People { get; set; }
    }
}