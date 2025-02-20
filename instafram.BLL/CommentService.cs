using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    class CommentService {
        private readonly CommentRepository _commentRepository;

        public CommentService(CommentRepository commentRepository) {
            _commentRepository = commentRepository;
        }
        public List<Comment> GetComments() {
            return _commentRepository.GetComments();
        }
        public Comment GetComment(int id) {
            return _commentRepository.GetCommentById(id);
        }

        public Comment UpdateComment(Comment comment) {
            return _commentRepository.UpdateComment(comment);
        }
        public void DeleteComment(int id) {
            _commentRepository.DeleteComment(id);
        }
    }
}
