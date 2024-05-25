using Azure.Core;
using BannersAPI.Data;
using BannersAPI.Entity;
using BannersAPI.Interfaces;
using BannersAPI.Models;
using BannersAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BannersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
       // private readonly DataContext _context;

        //public BannersController(DataContext context)
        //{
        //    _context = context;
        //}

        private readonly ICategoryService _categoryService;

        public BannersController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }


        [HttpGet("GetCategory")]
        public GetCategoryResponse GetCategory(GetCategoryRequest request) => _categoryService.GetCategory(request);

        [HttpPost("createCategory")]
        public CreateCategoryResponse CreateCategory(CategoryModel request) => _categoryService.CreateCategory(request);

        [HttpPost("updateCategory")]
        public UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request) => _categoryService.UpdateCategory(request);

        [HttpPost("deleteCategory")]
        public DeleteCategoryResponse Delete(DeleteCategoryRequest request) => _categoryService.DeleteCategory(request);


        /*
        [HttpGet]

        public async Task<ActionResult<List<Banners>>> GetBanners()
        {
            return Ok(await _context.Banners.ToListAsync());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<List<Banners>>> CreateBanners(Banners banner)
        {
            _context.Banners.Add(banner);
            await _context.SaveChangesAsync();

            return Ok(await _context.Banners.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Banners>>> UpdateBanners(Banners banner)
        {
            var dbBanner = await _context.Banners.FindAsync(banner.Id);
            if (dbBanner == null)
                return BadRequest("ბანერი არ მოიძებნა");
                dbBanner.Name = banner.Name;
                dbBanner.Email = banner.Email;
                dbBanner.Img = banner.Img;

            await _context.SaveChangesAsync();

            return Ok(await _context.Banners.ToListAsync());
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Banners>>> DeleteBanners(int id)
        {
            var dbBanner = await _context.Banners.FindAsync(id);
            if (dbBanner == null)
                return BadRequest("ბანერი არ მოიძებნა");

            _context.Banners.Remove(dbBanner);
            await _context.SaveChangesAsync();

            return Ok(await _context.Banners.ToListAsync());
        } */
    } 
}
