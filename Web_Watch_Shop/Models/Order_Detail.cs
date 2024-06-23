using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Order_Detail
    {
        public int Order_DetailID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<CheckOut>? CheckOuts { get; set; }
    }
}
