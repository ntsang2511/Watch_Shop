using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Product_Detail
    {
        public int Product_DetailID { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
