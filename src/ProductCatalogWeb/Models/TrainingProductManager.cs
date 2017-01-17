using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogWeb.Models
{
    public class TrainingProductManager
    {
        public List<TrainingProduct> Get()
        {
            var data = CreateMockData();
            return data;
        }

        private List<TrainingProduct> CreateMockData()
        {
            var data = new List<TrainingProduct>();
            data.Add(new TrainingProduct
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap",
                IntroductionDate = new DateTime(2015, 11, 6),
                Url = "https://bit.ly/lSNzc0i",
                Price = 29
            });
            data.Add(new TrainingProduct
            {
                ProductId = 2,
                ProductName = "ASP.NET MVC 5",
                IntroductionDate = new DateTime(2016, 07, 5),
                Url = "https://bit.ly/ku4mJJd",
                Price = 59
            });
            data.Add(new TrainingProduct
            {
                ProductId = 3,
                ProductName = "Angular 2",
                IntroductionDate = new DateTime(2016, 03, 18),
                Url = "https://bit.ly/arN54J",
                Price = 29
            });

            return data;
        }

        public List<TrainingProduct> FilterByProductName(string inputModelSearchProductName)
        {
            var data = this.CreateMockData();

            if (!String.IsNullOrEmpty(inputModelSearchProductName))
            {
                data = data.Where(p => p.ProductName.ToLower().StartsWith(inputModelSearchProductName.ToLower())).ToList();
            }

            return data;
        }
    }
}
