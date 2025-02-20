using instafram.Models;

namespace instafram.DAL {
    public class PostRepository {
        private readonly InstaframContext _context;

        public PostRepository(InstaframContext context) {
            _context = context;
        }

        public List<Post> GetPosts() {
            return _context.Posts.ToList();
        }

        public Post GetPostById(int id) {
            return _context.Posts.Find(id);
        }

        public Post UpdatePost(Post post) {
            _context.Posts.Update(post);
            _context.SaveChanges();
            return post;
        }

        public Post CreatePost(Post post) {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public Post DeletePost(Post post) {
            _context.Posts.Remove(post);
            _context.SaveChanges();
            return post;
        }
    }
}
