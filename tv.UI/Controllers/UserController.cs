using Microsoft.AspNetCore.Mvc;
using tv.Business.Abstract;
using tv.Core.Entity.Concrete;
using tv.UI.Error;
using tv.UI.Models;

namespace tv.UI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            var model = new UserViewModel { Users = _userService.GetAll() };
            return View(model);
        }
        public IActionResult Create(User user)
        {
            if (!_userService.Create(user))
            {
                return BadRequest();
            }

            return Ok();
        }

    }
}
