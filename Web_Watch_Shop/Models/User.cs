namespace Web_Watch_Shop.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }
        public string sex {  get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }
        public virtual ICollection<Cart>? Carts{ get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
