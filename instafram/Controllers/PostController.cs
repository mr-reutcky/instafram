using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.DAL;
using instafram.Models;

namespace instafram.Controllers {
    public class PostController : Controller {

        private readonly PostService _postService;
        private readonly CommentService _commentService;
        private readonly LikeService _likeService;
        public PostController(PostService postService, CommentService commentService, LikeService likeService) {
            _postService = postService;
            _commentService = commentService;
            _likeService = likeService;
        }
        public IActionResult Index() {
            List<Post> post = _postService.GetPosts();
            return View(post);
        }

        public IActionResult Comment(int Id) {
            ViewBag.PostID = Id;
            List<Comment> comment = _commentService.GetComments();
            List<Comment> postComments = comment.Where(c => c.PostId == Id).ToList();

            return View(postComments);
        }
        public IActionResult LikePost(int Id) {
            Post post = _postService.GetPost(Id);

            if (post == null) {
                return NotFound(); 
            }

            Like like = new Like()
            {
                PostId = Id,
                UserId = 1, 
                Timestamp = DateTime.Now,
            };

             post.Likes++;
             post.Views++;
            _postService.UpdatePost(post);
            _likeService.CreateLike(like);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CommentForm(int Id) {
            ViewBag.PlayerId = 1;
            ViewBag.PostID = Id;

            return View();
        }

       [HttpPost]
        public IActionResult CommentForm(Comment comment) {
            if (ModelState.IsValid) {
                _commentService.CreateComment(comment);
                return Redirect("/Post/Index");
            }
            return View(comment);
        }
    }
}