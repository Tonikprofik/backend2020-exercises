using System.Collections.Generic;
using System.Linq;

namespace Lesson05.Models {
    public class CountryRepository {


        private List<Country> countries = new List<Country> {
            new Country { Name  = "China", CountryCode = "CN" },
            new Country { Name  = "Denmark", CountryCode = "DK" },
            new Country { Name  = "France", CountryCode = "FR" },
            new Country { Name  = "USA", CountryCode = "US" }
        };

        public List<Country> Countries { get { return countries; } }

        public List<Country> CountriesSorted { get { return countries.OrderBy(x => x.Name).ToList();  } }

        // Or alternatively you could use an expression-bodied get statement
        // public IEnumerable<Country> Countries => countries;

        public void AddCountry(Country newCountry) {

            // test for duplicates
            Country country = (from c in countries where c.Name == newCountry.Name select c).FirstOrDefault();

            if (country == null)
            { 
                countries.Add(newCountry);
            }
        }
    }
}
