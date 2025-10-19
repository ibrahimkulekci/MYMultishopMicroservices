using Multishop.Catalog.Dtos.ProductImageDtos;

namespace Multishop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProdcutImageDto);
        Task DeleteProductImageAsync(string productImageId);
        Task<ResultProductImageDto> GetByIdProductImageAsync(string productImageId);
    }
}
