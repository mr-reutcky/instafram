using instafram.Models;

namespace instafram.DAL {
    public class UserRepository {
        private readonly InstaframContext _context;

        public UserRepository(InstaframContext context) {
            _context = context;
        }

        public List<User> GetUsers() {
            return _context.Users.ToList();
        }

        public User GetUserById(int id) {
            return _context.Users.Find(id);
        }

        public User UpdateUser(User user) {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public User CreateUser(User user) {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User DeleteUser(User user) {
            _context.Users.Remove(user);
            _context.SaveChanges();
            return user;
        }
    }
}
