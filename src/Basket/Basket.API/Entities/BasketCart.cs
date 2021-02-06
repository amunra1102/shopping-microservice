using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class BasketCart
    {
        public string UserName { get; set; }
        public List<BasketCartItem> Items { get; set; } = new List<BasketCartItem>();
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (BasketCartItem item in Items)
                {
                    totalPrice += item.Price + item.Quantity;
                }
                return totalPrice;
            }
        }

        public BasketCart()
        {
        }

        public BasketCart(string userName)
        {
            UserName = userName;
        }
    }
}
