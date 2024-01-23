using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tv.Business.Abstract;
using tv.Entity.Concrete;

namespace tv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertsController : ControllerBase
    {
        private IAdvertService _advertService;

        public AdvertsController(IAdvertService advertServie)
        {
            _advertService = advertServie;
        }
        
        [HttpGet("getall")]
        public IActionResult GetList() 
        {
            var result = _advertService.GetAll();
            if (result.Success) 
            { 
             return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        {
            var result = _advertService.GetById(id);
            if (result.Success) 
            { 
             return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getlistbycategory")]
        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _advertService.GetByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getlistbyowner")]
        public IActionResult GetListByOwner(int ownerId)
        {
            var result = _advertService.GetByOwner(ownerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("create")]
        public IActionResult Create(Advert advert)
        {
            var result = _advertService.Add(advert);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Advert advert)
        {
            var result = _advertService.Delete(advert);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Advert advert)
        {
            var result = _advertService.Update(advert);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
