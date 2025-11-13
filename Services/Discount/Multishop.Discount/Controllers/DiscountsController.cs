using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Discount.Dtos;
using Multishop.Discount.Services;

namespace Multishop.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var result = await _discountService.GetAllDiscountCouponAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var result = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto coupon)
        {
            await _discountService.CreateDiscountCouponAsync(coupon);
            return Ok("Kupon başarıyla oluşturuldu.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Kupon başarıyla silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto coupon)
        {
            await _discountService.UpdateDiscountCouponAsync(coupon);
            return Ok("İndirim kuponu başarıyla güncellendi.");
        }
    }
}
