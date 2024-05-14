using Mango.Web.Models;
using Mango.Web.Models.Utility;
using Mango.Web.Service.IService;
using System;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService=baseService;
        }
        public async Task<ResponseDto?> CreateCouponAysnc(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "api/coupon"
            }) ;
        }

        public async Task<ResponseDto?> DeleteCouponAysnc(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponAysnc()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "api/coupon"
			});
        }

        public async Task<ResponseDto?> GetCouponAysnc(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType= SD.ApiType.GET,
                Url= SD.CouponAPIBase + "api/coupon/GetByCode/"+ couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAysnc(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAysnc(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "api/coupon"
            });
        }
    }
}
