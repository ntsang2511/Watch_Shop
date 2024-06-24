using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Product_Detail
    {
        public int Product_DetailID { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }
        [Display(Name = "Name")]
        public string ProductName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Category")]
        public String CategoryName { get; set; } = string.Empty;
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

    }
}
