using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace MvcBeerStore.Models
{
    // Try without this bind later
    [Bind(Exclude = "BeerId")]
    public class Beer
    {
        [ScaffoldColumn(false)]
        public int     BeerId     { get; set; }
        [DisplayName("Style")]
        public int     StyleId    { get; set; }
        [DisplayName("Brewery")]
        public int     BreweryId  { get; set; }
        [Required(ErrorMessage = "A Beer Name is Required")]
        [StringLength(160)]
        public string  Name       { get; set; }
        [Required(ErrorMessage = "A Price is Rerquired")]
        [Range(0.01, 100.00, ErrorMessage = "Price Must be Between 0.01 and 100.00")]
        public decimal Price      { get; set; }
        [DisplayName("Beer Art Url")]
        [StringLength(1024)]
        public string  BeerArtUrl { get; set; }

        public virtual Style   Style   { get; set; }
        public virtual Brewery Brewery { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}