﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartHeaderDto
    {
       
        public int CartHeaderId { get; set; }
        public string? UserId { get; set; }
        public string? CuponCode { get; set; }

      
        public double Discount { get; }
       
        public double CartTotal { get; set; }
    }
}
