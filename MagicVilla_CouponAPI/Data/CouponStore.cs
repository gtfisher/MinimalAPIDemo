using MagicVilla_CouponAPI.Models;

namespace MagicVilla_CouponAPI.Data
{
    public static class CouponStore
    {

        public static List<Coupon> couponList = new List<Coupon> {
            new Coupon{Id=1,Name="10pcOFF",Percent=10,IsActive=true },
            new Coupon{Id=2,Name="20pcOFF",Percent=20,IsActive=false }
        };
    }
}
