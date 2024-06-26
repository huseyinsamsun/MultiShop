﻿using Microsoft.AspNetCore.Mvc;
using GlobalAuto.Catalog.Dtos.ProductImageDtos;
using GlobalAuto.Catalog.Services.ProductImageServices;

namespace GlobalAuto.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesConroller : ControllerBase
    {
        private readonly IProductImageService _productImageService;
        public ProductImagesConroller(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        [HttpGet]
        public async Task<IActionResult> ProductImageList()
        {
            var values = await _productImageService.GetAllProductImageAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var values = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("Ürün Fotoğrafı Başarı Ile Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Ürün Fotoğrafı Başarı İle Silindi");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Ürün Fotoğrafı Başarı İle Güncellendi");

        }
    }
}
