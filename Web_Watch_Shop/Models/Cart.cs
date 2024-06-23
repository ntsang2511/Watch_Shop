using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public virtual ICollection<Cart_Detail>? Cart_Details { get; set; }
    }
}
