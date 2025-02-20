using instafram.Models;

namespace instafram.DAL {
    public class LikeRepository {
        private readonly InstaframContext _context;

        public LikeRepository(InstaframContext context) {
            _context = context;
        }

        public List<Like> GetLikes() {
            return _context.Likes.ToList();
        }

        public Like GetLikeById(int id) {
            return _context.Likes.Find(id);
        }

        public Like UpdateLike(Like like) {
            _context.Likes.Update(like);
            _context.SaveChanges();
            return like;
        }

        public Like CreateLike(Like like) {
            _context.Likes.Add(like);
            _context.SaveChanges();
            return like;
        }

        public Like DeleteLike(Like like) {
            _context.Likes.Remove(like);
            _context.SaveChanges();
            return like;
        }
    }
}
