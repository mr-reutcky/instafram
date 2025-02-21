using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace instafram.Controllers {
    public class UserController : Controller {
        private readonly UserService _userService;
        private readonly PostService _postService;

        public UserController(UserService userService, PostService postService) {
            _userService = userService;
            _postService = postService;
        }

        public IActionResult Index() {
            List<User> users = _userService.GetUsers();
            return View(users);
        }

        public IActionResult Profile(int id) {
            User user = _userService.GetUser(id);
            if (user == null) {
                return NotFound();
            }
            List<Post> posts = _postService.GetPostsByUserId(id); 

            ViewData["User"] = user;
            ViewData["Posts"] = posts;

            return View(user);
        }

    }
}
 