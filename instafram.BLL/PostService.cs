﻿using instafram.DAL;
using instafram.Models;

namespace instafram.BLL {
    public class PostService {
        private readonly PostRepository _postRepository;

        public PostService(PostRepository postRepository) {
            _postRepository = postRepository;
        }

        public List<Post> GetPosts() {
            return _postRepository.GetPosts();
        }

        public Post GetPost(int id) {
            return _postRepository.GetPostById(id);
        }

        public List<Post> GetPostsByUserId(int userId) {
            return _postRepository.GetPostsByUserId(userId);
        }

        public Post UpdatePost(Post post) {
            return _postRepository.UpdatePost(post);
        }

        public void DeletePost(Post post) {
            _postRepository.DeletePost(post);
        }

        public Post CreatePost(Post post) {
            return _postRepository.CreatePost(post);
        }
    }
}
