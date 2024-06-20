using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Cart_Detail>? Cart_Details { get; set; }
        public virtual ICollection<Order_Detail>? Order_Details { get; set; }
        public virtual ICollection<Product_Detail>? Product_Details { get; set; }

    }
}
