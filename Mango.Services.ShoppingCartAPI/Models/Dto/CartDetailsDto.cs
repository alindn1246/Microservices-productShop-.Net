using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDetailsDto
    {
       
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }

       
        public CartHeaderDto? CartHeader { get; set; }

        public int productId { get; set; }
      
        public ProductDto? product { get; set; }

        public int Count { get; set; }
    }
}
