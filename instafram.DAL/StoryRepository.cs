using instafram.Models;

namespace instafram.DAL {
    public class StoryRepository {
        private readonly InstaframContext _context;

        public StoryRepository(InstaframContext context) {
            _context = context;
        }

        public List<Story> GetStories() {
            return _context.Stories.ToList();
        }

        public Story GetStoryById(int id) {
            return _context.Stories.Find(id);
        }

        public Story UpdateStory(Story story) {
            _context.Stories.Update(story);
            _context.SaveChanges();
            return story;
        }

        public Story CreateStory(Story story) {
            _context.Stories.Add(story);
            _context.SaveChanges();
            return story;
        }

        public Story DeleteStory(Story story) {
            _context.Stories.Remove(story);
            _context.SaveChanges();
            return story;
        }
    }
}
