using AutoMapper;
using Mango.Services.ProductAPI.Models.DTO;
using Mango.Services.ProductAPI.Data;
using Mango.Services.ProductAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Mango.Services.ProductAPI.Controllers
{
	[Route("api/product")]
	[ApiController]
   
    public class ProductAPIController : ControllerBase
	{
		private readonly AppDbContext _db;
		private  ResponseDto _responseDto;
		private IMapper _mapper;

        public ProductAPIController(AppDbContext db,IMapper mapper)
        {
            _db = db;
			_mapper = mapper;
			_responseDto = new ResponseDto();
        }

		///////////////////////////////////////////////////////////////////////////////////////////
		
		[HttpGet]

		public ResponseDto Get()
		{
			try
			{
				IEnumerable<Product> ObjList = _db.products.ToList();//gets All Products
				_responseDto.Result= _mapper.Map<IEnumerable<ProductDto>>(ObjList);//First We Transfer the Product(ObjList) to ProductDto and
																				   //save ObjList in _responseDto { Result=ProductDto data , IsSuccess=True,message=""}

			}
			catch (Exception ex)
			{
				_responseDto.IsSuccess= false;
				_responseDto.Message= ex.Message;
			}
			return _responseDto;
		}

		///////////////////////////////////////////////////////////////////////////////////////////

		[HttpGet("{id:int}")]

		public ResponseDto Get(int id)
		{
			try
			{
				Product obj=_db.products.First(u=>u.ProductId==id);
				_responseDto.Result = _mapper.Map<ProductDto>(obj);
			
			}
			catch (Exception ex)
			{
				_responseDto.IsSuccess= false;
				_responseDto.Message= ex.Message;
			}
			return _responseDto;
		}

		///////////////////////////////////////////////////////////////////////////////////////////


		[HttpPost]
        [Authorize(Roles = "ADMIN")]

        public ResponseDto Post([FromBody]ProductDto productdto) 
		{
			try 
			{ 
				Product obj=_mapper.Map<Product>(productdto);
				_db.products.Add(obj);
				_db.SaveChanges();
			
			}
			catch (Exception ex)
			{
				_responseDto.IsSuccess= false;
				_responseDto.Message= ex.Message;
			}
			return _responseDto;
		}

		///////////////////////////////////////////////////////////////////////////////////////////

		[HttpPut]
        [Authorize(Roles = "ADMIN")]

        public ResponseDto Put([FromBody]ProductDto productdto)
		{
			try 
			{
				Product obj = _mapper.Map<Product>(productdto);
				_db.products.Update(obj);
				_db.SaveChanges();
			}
			catch (Exception ex)
			{
				_responseDto.IsSuccess= false;
				_responseDto.Message= ex.Message;
			}
			return _responseDto;
		}

		///////////////////////////////////////////////////////////////////////////////////////////

		[HttpDelete]
		[Route("{id:int}")]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Delete(int id)
		{
			try
			{
                Product obj=_db.products.First(u=>u.ProductId==id);
				_db.products.Remove(obj);
				_db.SaveChanges();
			}
			catch (Exception ex)
			{
				_responseDto.IsSuccess= false;
				_responseDto.Message= ex.Message;
			}
			return _responseDto;
		}






	}
}
