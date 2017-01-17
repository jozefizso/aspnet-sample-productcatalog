using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogWeb.Models
{
    public class TrainingProduct
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public DateTime IntroductionDate { get; set; }

        public string Url { get; set; }

        public decimal Price { get; set; }
    }
}
