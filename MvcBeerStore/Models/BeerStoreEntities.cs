using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBeerStore.Models
{
    public class BeerStoreEntities : DbContext
    {
        public DbSet<Beer>        Beers        { get; set; }
        public DbSet<Style>       Styles       { get; set; }
        public DbSet<Brewery>     Breweries    { get; set; }
        public DbSet<Cart>        Carts        { get; set; }
        public DbSet<Order>       Orders       { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}