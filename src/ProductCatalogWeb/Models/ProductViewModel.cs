using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogWeb.Models
{
    public class ProductViewModel
    {
        public string SearchProductName { get; set; }

        public List<TrainingProduct> TrainingProducts { get; set; }
    }
}
