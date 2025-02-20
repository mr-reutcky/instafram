using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    class LikeService {
        private readonly LikeRepository _likeRepository;

        public LikeService(LikeRepository likeRepository) {
            _likeRepository = likeRepository;
        }

        public List<Like> GetLikes() {
            return _likeRepository.GetLikes();
        }

        public Like GetLike(int id) {
            return _likeRepository.GetLikeById(id);
        }

        public Like UpdateLike(Like like) {
            return _likeRepository.UpdateLike(like);
        }

        public void DeleteLike(Like like) {
            _likeRepository.DeleteLike(like);
        }

        public Like CreateLike(Like like) {
            return _likeRepository.CreateLike(like);
        }
    }
}
