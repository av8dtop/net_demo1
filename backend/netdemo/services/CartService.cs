using System.Collections.Generic;

namespace netdemo.services
{
    public class CartService : ICartService
    {
        private List<Product> _cartItems;

        public CartService()
        {
            _cartItems = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            _cartItems.Add(product);
        }

        public void DeleteFromCart(int productId)
        {
            var product = _cartItems.Find(p => p.Id == productId);
            if (product != null)
            {
                _cartItems.Remove(product);
            }
        }

        public List<Product> GetCartItems()
        {
            return _cartItems;
        }
    }
}