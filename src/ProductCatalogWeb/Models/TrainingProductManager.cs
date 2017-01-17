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

            return data;
        }
    }
}
