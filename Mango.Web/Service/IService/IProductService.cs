﻿
using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IProductService
    {
        Task <ResponseDto?> GetAllProductAsync ();
        Task<ResponseDto?> GetProductAsync (int productId);
		Task<ResponseDto?> CreateProductAsync(ProductDto productDto);
		Task<ResponseDto?> UpdateProductAsync (ProductDto productDto);
        Task<ResponseDto?> DeleteProductAsync (int productId);


    }
}
