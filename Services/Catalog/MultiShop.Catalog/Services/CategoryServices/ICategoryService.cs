﻿using GlobalAuto.Catalog.Dtos.CategoryDtos;

namespace GlobalAuto.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync (CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync (UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync (string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
        




    }
}
