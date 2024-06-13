using RazorCountry.Models;
using System.Linq;
using System;

namespace RazorCountry.Data
{
    public class DbInitializer
    {
        public static void Initialize(CountryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Continents.
            if (context.ContinentsDbSet.Any())
            {
                return;   // DB has been seeded
            }

            var Continents = new Continent[]
            {
        new Continent{ContinentID="NA",Name="North America"},
        new Continent{ContinentID="SA",Name="South America"},
        new Continent{ContinentID="EU",Name="Europe"},
        new Continent{ContinentID="AS",Name="Asia"},
        new Continent{ContinentID="AF",Name="Africa"},
        new Continent{ContinentID="AN",Name="Antartica"},
        new Continent{ContinentID="PH", Name="Philippines"}
            };

            foreach (Continent s in Continents)
            {
                context.ContinentsDbSet.Add(s);
            }

            context.SaveChanges();

            var Countries = new Country[]
            {
        new Country{CountryID="USA",Name="United States",ContinentID="NA",Population=330529481,UnitedNationsDate=new DateTime(1945,10,24)},
        new Country{CountryID="BRA",Name="Brazil",ContinentID="SA",Population=210938214,UnitedNationsDate=new DateTime(1945,10,24)},
        new Country{CountryID="FRA",Name="France",ContinentID="EU",Population=67081000,UnitedNationsDate=new DateTime(1945,10,24)},
        new Country{CountryID="CHN",Name="China",ContinentID="AS",Population=1400737880,UnitedNationsDate=new DateTime(1945,10,24)},
        new Country{CountryID="SDN",Name="Sudan",ContinentID="AF",Population=42158625,UnitedNationsDate=new DateTime(1956,12,11)},
        new Country{CountryID="PH",Name="Philippines",ContinentID="PH",Population=2,UnitedNationsDate=new DateTime(2024,6,4)}
            };

            foreach (Country c in Countries)
            {
                context.CountriesDbSet.Add(c);
            }

            context.SaveChanges();
        }
    }
}
