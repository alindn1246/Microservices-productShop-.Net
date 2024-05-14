using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models
{
    public class CouponDto
    {
        public int Id { get; set; }
        [Required]
        public  string CouponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        [Required]
        public int MinAmount { get; set; }
    }
}
