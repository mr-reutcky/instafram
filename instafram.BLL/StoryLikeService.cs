using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    public class StoryLikeService {
        private readonly StoryLikeRepository _storyLikeRepository;
        public StoryLikeService(StoryLikeRepository storyLikeRepository) {
            _storyLikeRepository = storyLikeRepository;
        }
        public List<Storylike> GetStoryLikes() {
            return _storyLikeRepository.GetStoryLikes();
        }
        public Storylike GetStoryLikeById(int id) {
            return _storyLikeRepository.GetStoryLikeById(id);
        }
        public Storylike CreateStoryLike(Storylike storyLike) {
            return _storyLikeRepository.CreateStoryLike(storyLike);
        }
        public Storylike DeleteStoryLike(Storylike storyLike) {
            return _storyLikeRepository.DeleteStoryLike(storyLike);
        }
    }
}
