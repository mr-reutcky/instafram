using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    class StoryService {
        private readonly StoryRepository _storyRepository;

        public StoryService(StoryRepository storyRepository) {
            _storyRepository = storyRepository;
        }

        public List<Story> GetStories() {
            return _storyRepository.GetStories();
        }

        public Story GetStory(int id) {
            return _storyRepository.GetStoryById(id);
        }

        public Story UpdateStory(Story story) {
            return _storyRepository.UpdateStory(story);
        }

        public void DeleteStory(Story story) {
            _storyRepository.DeleteStory(story);
        }

        public Story CreateStory(Story story) {
            return _storyRepository.CreateStory(story);
        }
    }
}
