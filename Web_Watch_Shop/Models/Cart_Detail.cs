using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Cart_Detail
    {
        public int Cart_DetailID {  get; set; }
        public int CartID { get; set; }
        public Cart Cart { get; set; }

        public virtual ICollection<Product>? Product { get; set; }
    }
}
