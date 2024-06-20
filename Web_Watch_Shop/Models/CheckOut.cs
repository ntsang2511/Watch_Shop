using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class CheckOut
    {
        public int CheckoutID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int ZipCode { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string DeliveryMethod { get; set; }
        [ForeignKey("Order_DetailID")]
        public int Order_DetailID { get; set; }
        public Order_Detail Order_Detail { get; set; }

    }
}
