using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIfriend.Models
{
    public class DataContext:DbContext

    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIfriend.Models.Friend> Friends { get; set; }
    }
}