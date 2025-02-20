using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    class FollowService {
        private readonly FollowRepository _followRepository;

        public FollowService(FollowRepository followRepository) {
            _followRepository = followRepository;
        }

        public List<Follow> GetFollows() {
            return _followRepository.GetFollows();
        }

        public Follow GetFollow(int id) {
            return _followRepository.GetFollowById(id);
        }

        public Follow UpdateFollow(Follow follow) {
            return _followRepository.UpdateFollow(follow);
        }

        public void DeleteFollow(Follow follow) {
            _followRepository.DeleteFollow(follow);
        }
    }
}
