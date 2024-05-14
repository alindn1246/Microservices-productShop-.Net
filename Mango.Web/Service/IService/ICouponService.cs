using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAysnc(string couponId);
        Task<ResponseDto?> GetAllCouponAysnc();

        Task<ResponseDto?> GetCouponByIdAysnc(int id);

        Task<ResponseDto?> CreateCouponAysnc(CouponDto couponDto);

        Task<ResponseDto?> UpdateCouponAysnc(CouponDto couponDto);

        Task<ResponseDto?> DeleteCouponAysnc(int id);










    }
}
