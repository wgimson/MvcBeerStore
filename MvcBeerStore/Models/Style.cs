using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBeerStore.Models
{
    public partial class Style
    {
        public int    StyleId     { get; set; }
        public string Name        { get; set; }
        public string Description { get; set; }

        public List<Beer> Beers { get; set; } 
    }
}