using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBeerStore.Models
{
    public class SampleData : DropCreateDatabaseAlways<BeerStoreEntities>
    {
        protected override void Seed(BeerStoreEntities context)
        {
            var styles = new List<Style>
            {
                new Style { Name = "Imperial IPA" },
                new Style { Name = "IPA" },
                new Style { Name = "Russian Imperial Stout" },
                new Style { Name = "Belgian Dubbel" },
                new Style { Name = "Belgian Quadruppel" },
                new Style { Name = "American Barleywine" },
                new Style { Name = "Porter" },
                new Style { Name = "Lambic" },
                new Style { Name = "Saison" },
                new Style { Name = "Scotch Ale" }
            };

            var breweries = new List<Brewery>
            {
                new Brewery { Name = "The Alchemist" },
                new Brewery { Name = "Russian River Brewing Company" },
                new Brewery { Name = "Three Floyds Brewing Company" },
                new Brewery { Name = "Founders Brewing Company" }, 
                new Brewery { Name = "Brouwerij Westvleteren" },
                new Brewery { Name = "Goose Island Beer Company" },
                new Brewery { Name = "Firestone Walker Brewing Company" },
                new Brewery { Name = "Deschutes Brewery" },
                new Brewery { Name = "Brasserie Cantillon" },
                new Brewery { Name = "Lawson's Finest Liquids" },
                new Brewery { Name = "Bell's Brewery" }, 
                new Brewery { Name = "Cigar City Brewing" },
                new Brewery { Name = "Alpine Brewery" },
                new Brewery { Name = "Stone Brewery" },
                new Brewery { Name = "Rochefort Brewery" },
                new Brewery { Name = "Great Divide Brewing Company" },
                new Brewery { Name = "Boulevard Brewing Company" },
            };

            new List<Beer>
            {
                new Beer { Name = "Hopslam", Style = styles.Single(s => s.Name == "Imperial IPA"), Price = 8.99M, Brewery = breweries.Single(b => b.Name == "Bell's Brewery"), BeerArtUrl = "/Content/Images/hopslam.jpg" },
                new Beer { Name = "Nelson", Style = styles.Single(s => s.Name == "IPA"), Price = 10.99M, Brewery = breweries.Single(b => b.Name == "Alpine Brewery"), BeerArtUrl = "/Content/Images/nelson.jpg" },
                new Beer { Name = "Imperial Russian Stout", Style = styles.Single(s => s.Name == "Russian Imperial Stout"), Price = 12.99M, Brewery = breweries.Single(b => b.Name == "Stone Brewery"), BeerArtUrl = "/Content/Images/imperialrussianstout.jpg" },
                new Beer { Name = "Rochefort 8", Style = styles.Single(s => s.Name == "Belgian Dubbel"), Price = 8.99M, Brewery = breweries.Single(b => b.Name == "Rochefort Brewery"), BeerArtUrl = "/Content/Images/rochefort8.jpg" },
                new Beer { Name = "Westvleteren 12", Style = styles.Single(s => s.Name == "Belgian Quadruppel"), Price = 20.99m, Brewery = breweries.Single(b => b.Name == "Brouwerij Westvleteren"), BeerArtUrl = "/Content/Images/westvleteren12.jpg" },
                new Beer { Name = "Old Ruffian", Style = styles.Single(s => s.Name == "American Barleywine"), Price = 14.99M, Brewery = breweries.Single(b => b.Name == "Great Divide Brewing Company"), BeerArtUrl = "/Content/Images/oldruffian.jpg" },
                new Beer { Name = "Black Butte Porter", Style = styles.Single(s => s.Name == "Porter"), Price = 7.99M, Brewery = breweries.Single(b => b.Name == "Deschutes Brewery"), BeerArtUrl = "/Content/Images/blackbutteporter.jpg" },
                new Beer { Name = "Fou' Foune", Style = styles.Single(s => s.Name == "Lambic"), Price = 60.99M, Brewery = breweries.Single(b => b.Name == "Brasserie Cantillon"), BeerArtUrl = "/Content/Images/foufoune.jpg" },
                new Beer { Name = "Saison-Brett", Style = styles.Single(s => s.Name == "Saison"), Price = 13.99M, Brewery = breweries.Single(b => b.Name == "Boulevard Brewing Company"), BeerArtUrl = "/Content/Images/saisonbrett.jpg" },
                new Beer { Name = "Backwoods Bastard", Style = styles.Single(s => s.Name == "Scotch Ale"), Price = 11.99M, Brewery = breweries.Single(b => b.Name == "Founders Brewing Company"), BeerArtUrl = "/Content/Images/backwoodsbastard.jpg" }
            }.ForEach(b => context.Beers.Add(b));
        }
    }
}