namespace Web_Watch_Shop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product>? Products { get; set; }


    }
}
