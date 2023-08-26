using System.Collections.Generic;

namespace netdemo.services
{
    public interface ICartService
    {
        void AddToCart(Product product)
        {
            // Add the product to the cart
        }

        void DeleteFromCart(int productId)
        {
            // Delete the product from the cart based on the productId
        }

        List<Product> GetCartItems()
        {
            // Retrieve and return the list of products in the cart
            return new List<Product>();
        }
    }
}
