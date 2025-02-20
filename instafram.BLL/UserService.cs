using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    class UserService {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository) {
            _userRepository = userRepository;
        }

        public List<User> GetUsers() {
            return _userRepository.GetUsers();
        }

        public User GetUser(int id) {
            return _userRepository.GetUserById(id);
        }

        public User UpdateUser(User user) {
            return _userRepository.UpdateUser(user);
        }

        public void DeleteUser(User user) {
            _userRepository.DeleteUser(user);
        }

        public User CreateUser(User user) {
            return _userRepository.CreateUser(user);
        }
    }
}
