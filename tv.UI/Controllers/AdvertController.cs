using Microsoft.AspNetCore.Mvc;
using tv.Business.Abstract;
using tv.UI.Models;

namespace tv.UI.Controllers
{
    public class AdvertController : Controller
    {
        private IAdvertService _advertService;
        public AdvertController(IAdvertService advertService)
        {
            _advertService = advertService;
        }
        public IActionResult Index()
        {
            var model = new AdvertViewModel
            {
                Adverts = _advertService.GetAll()
            };
            return View(model);
        }
        
    }
}
