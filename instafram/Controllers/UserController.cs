using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.Models;
using System.Collections.Generic;

namespace instafram.Controllers {
    public class UserController : Controller {
        private readonly UserService _userService;

        public UserController(UserService userService) {
            _userService = userService;
        }
        public IActionResult Index() {
            List<User> users = _userService.GetUsers();
            return View(users);
        }
    }
}
