using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.DAL;
using instafram.Models;

namespace instafram.Controllers {
    public class PostController : Controller {

        private readonly PostService _postService;
        private readonly CommentService _commentService;
        private int _commentId;

        public PostController(PostService postService, CommentService commentService) {
            _postService = postService;
            _commentService = commentService;
            _commentId = LastCommentID();
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

        [HttpGet]
        public IActionResult CommentForm(int Id) {
            ViewBag.PlayerId = 1;
            ViewBag.PostID = Id;

            return View();
        }

       [HttpPost]
        public IActionResult CommentForm(Comment comment) {
            if (ModelState.IsValid) {
               // comment.CommentId = _commentId++;
                _commentService.CreateComment(comment);
                return Redirect("/Post/Index");
            }
            return View(comment);
        }
        
        private int LastCommentID() {
            int lastId = _commentService.GetComments()
                .OrderByDescending(c => c.CommentId) 
                .Select(c => c.CommentId)
                .FirstOrDefault();

            return lastId + 1; 
        }

    }
}