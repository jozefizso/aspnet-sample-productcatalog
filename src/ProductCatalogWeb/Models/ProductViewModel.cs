using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogWeb.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            this.IsSearchAreaVisible = true;
            this.IsListAreaVisible = true;
            this.IsDetailAreaVisible = false;
        }

        public string EventCommand { get; set; }

        public string SearchProductName { get; set; }

        public List<TrainingProduct> TrainingProducts { get; set; }

        public bool IsDetailAreaVisible { get; set; }

        public bool IsListAreaVisible { get; set; }

        public bool IsSearchAreaVisible { get; set; }

        public void EnableDetailView()
        {
            this.IsSearchAreaVisible = false;
            this.IsListAreaVisible = false;
            this.IsDetailAreaVisible = true;
        }

        public void BindData()
        {
            var data = new TrainingProductManager();

            this.TrainingProducts = data.FilterByProductName(this.SearchProductName);
        }
    }
}
