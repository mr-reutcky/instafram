using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using instafram.Models;

namespace instafram.DAL {
    public class FollowRepository {
        private readonly InstaframContext _context;

        public FollowRepository(InstaframContext context) {
            _context = context;
        }

        public List<Follow> GetFollows() {
            return _context.Follows.ToList();
        }

        public Follow GetFollowById(int id) {
            return _context.Follows.Find(id);
        }

        public Follow UpdateFollow(Follow follow) {
            _context.Follows.Update(follow);
            _context.SaveChanges();
            return follow;
        }

        public Follow CreateFollow(Follow follow) {
            _context.Follows.Add(follow);
            _context.SaveChanges();
            return follow;
        }

        public Follow DeleteFollow(Follow follow) {
            _context.Follows.Remove(follow);
            _context.SaveChanges();
            return follow;
        }
    }
}
