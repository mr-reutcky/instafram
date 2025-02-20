using System;
using instafram.Models;

namespace instafram.DAL {
    public class CommentRepository {
        private readonly InstaframContext _context;

        public CommentRepository(InstaframContext context) {
            _context = context;
        }

        public List<Comment> GetComments() {
            return _context.Comments.ToList();
        }

        public Comment GetCommentById(int id) {
            return _context.Comments.Find(id);
        }

        public Comment UpdateComment(Comment comment) {
            _context.Comments.Update(comment);
            _context.SaveChanges();
            return comment;
        }

        public Comment CreateComment(Comment comment) {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return comment;
        }

        public Comment DeleteComment(int id) {
            var comment = _context.Comments.Find(id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return comment;
        }
    }
}
