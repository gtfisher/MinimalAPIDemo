namespace MagicVilla_CouponAPI.Models.DTO
{
    public class CouponDTO
    {
        public string Name { get; set; }
        public int Percent { get; set; }

        public bool IsActive { get; set; }

        public DateTime? Created { get; set; }
    }
}
