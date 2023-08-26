using Microsoft.AspNetCore.Mvc;

namespace netdemo.services
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("add")]
        public IActionResult AddToCart([FromBody] Product product)
        {
            // Validate user identity and ensure user is logged in
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            // Add the product to the shopping cart
            _cartService.AddToCart(product);

            // Return a successful response
            return Ok();
        }

        [HttpDelete("delete/{productId}")]
        public IActionResult DeleteFromCart(int productId)
        {
            // Validate user identity and ensure user is logged in
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            // Remove the specified product from the shopping cart
            _cartService.DeleteFromCart(productId);

            // Return a successful response
            return Ok();
        }

        [HttpGet]
        public IActionResult GetCart()
        {
            // Validate user identity and ensure user is logged in
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            // Retrieve the contents of the shopping cart
            var cartItems = _cartService.GetCartItems();

            // Return the detailed information of the shopping cart in the response
            return Ok(cartItems);
        }
    }
}