using Multishop.Catalog.Dtos.ProductDetailDtos;

namespace Multishop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProdcutDetailDto);
        Task DeleteProductDetailAsync(string productDetailId);
        Task<ResultProductDetailDto> GetByIdProductDetailAsync(string productDetailId);
    }
}
