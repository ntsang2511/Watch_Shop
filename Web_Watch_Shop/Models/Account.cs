using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Watch_Shop.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
