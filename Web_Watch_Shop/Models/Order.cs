using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }
        public virtual ICollection<Order_Detail>? Order_Details { get; set; }
    }
}