using instafram.Models;

namespace instafram.DAL {
    public class StoryLikeRepository {
        private readonly InstaframContext _context;

        public StoryLikeRepository(InstaframContext context) {
            _context = context;
        }

        public List<Storylike> GetStoryLikes() {
            return _context.Storylikes.ToList();
        }

        public Storylike GetStoryLikeById(int id) {
            return _context.Storylikes.Find(id);
        }

        public Storylike CreateStoryLike(Storylike storyLike) {
            _context.Storylikes.Add(storyLike);
            _context.SaveChanges();
            return storyLike;
        }

        public Storylike DeleteStoryLike(Storylike storyLike) {
            _context.Storylikes.Remove(storyLike);
            _context.SaveChanges();
            return storyLike;
        }
    }
}
