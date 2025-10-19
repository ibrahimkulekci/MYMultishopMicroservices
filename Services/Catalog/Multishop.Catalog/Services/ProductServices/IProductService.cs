using Multishop.Catalog.Dtos.ProductDtos;

namespace Multishop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string productId);
        Task<ResultProductDto> GetByIdProductAsync(string productId);
    }
}
