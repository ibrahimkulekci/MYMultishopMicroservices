﻿using Multishop.Catalog.Dtos.CategoryDtos;

namespace Multishop.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string categoryId);
        Task<ResultCategoryDto> GetByIdCategoryAsync(string categoryId);
    }
}
