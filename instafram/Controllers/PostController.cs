using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.DAL;
using instafram.Models;

namespace instafram.Controllers {
    public class PostController : Controller {
        private static PostRepository _postRepository = new PostRepository(new InstaframContext());
        private static PostService _postService = new PostService(_postRepository);

        public PostController() {
        }
        public IActionResult Index() {
            return View(_postService.GetPosts());
        }
    }
}