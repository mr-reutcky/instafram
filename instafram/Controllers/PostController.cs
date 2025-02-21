using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.DAL;
using instafram.Models;

namespace instafram.Controllers {
    public class PostController : Controller {

        private readonly PostService _postService;

        public PostController(PostService postService) {
            _postService = postService;
        }
        public IActionResult Index() {
            List<Post> post = _postService.GetPosts();
            return View(post);
        }
    }
}