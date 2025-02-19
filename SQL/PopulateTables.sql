---------------------------------------------------
-- INSERT 20 USERS
---------------------------------------------------
INSERT INTO user (Email, Bio, Username, ProfilePic, Followers, Password) VALUES
('cristiano@example.com', 'Football player', 'cristiano', 'cr7.jpg', 500000, 'hashedpassword'),
('messi@example.com', 'Football GOAT', 'messi', 'messi.jpg', 600000, 'hashedpassword'),
('serena@example.com', 'Tennis legend', 'serenawilliams', 'serena.jpg', 300000, 'hashedpassword'),
('random1@example.com', 'Just a random user', 'randomuser1', NULL, 100, 'hashedpassword'),
('random2@example.com', 'Loves movies', 'movie_quotes', NULL, 50, 'hashedpassword'),
('random3@example.com', 'Outgoing person', 'lifeoftheparty', NULL, 10, 'hashedpassword'),
('random4@example.com', 'Plant lover', 'aplasticplant', NULL, 400, 'hashedpassword'),
('talkative@example.com', 'Talks a lot', 'that_talkative_user', 'talkative.jpg', 900, 'hashedpassword'),
('user10@example.com', 'Bio of user10', 'user10', NULL, 150, 'hashedpassword'),
('user11@example.com', 'Bio of user11', 'user11', 'user11.jpg', 250, 'hashedpassword'),
('user12@example.com', 'Bio of user12', 'user12', NULL, 350, 'hashedpassword'),
('user13@example.com', 'Gamer and streamer', 'gamer_13', 'gamer13.jpg', 500, 'hashedpassword'),
('user14@example.com', 'Nature photographer', 'nature_shots', 'nature.jpg', 700, 'hashedpassword'),
('user15@example.com', 'Tech enthusiast', 'tech_wiz', NULL, 1200, 'hashedpassword'),
('user16@example.com', 'Food lover', 'foodie16', 'food16.jpg', 180, 'hashedpassword'),
('user17@example.com', 'Traveler', 'wanderer17', 'wanderer17.jpg', 800, 'hashedpassword'),
('user18@example.com', 'Fitness freak', 'fit18', 'fit18.jpg', 900, 'hashedpassword'),
('user19@example.com', 'Artist', 'artistic19', 'art19.jpg', 300, 'hashedpassword'),
('user20@example.com', 'Blogger', 'blogger20', NULL, 400, 'hashedpassword');

---------------------------------------------------
-- INSERT 20 POSTS
---------------------------------------------------
INSERT INTO post (UserId, Timestamp, Caption, Picture, Views) VALUES
(1, '2025-02-18 10:00:00', 'Great match today!', 'match1.jpg', 5000),
(2, '2025-02-17 11:00:00', 'Training hard!', 'training1.jpg', 7000),
(3, '2025-02-16 12:00:00', 'Beautiful day for tennis.', 'tennis1.jpg', 3000),
(4, '2025-02-15 13:00:00', 'Random post 1', 'random1.jpg', 150),
(5, '2025-02-14 14:00:00', 'Movie night!', 'movie1.jpg', 250),
(6, '2025-02-13 15:00:00', 'Party time!', 'party1.jpg', 100),
(7, '2025-02-12 16:00:00', 'Loving my plants.', 'plant1.jpg', 400),
(8, '2025-02-11 17:00:00', 'Chatting with friends.', 'chat1.jpg', 900),
(9, '2025-02-10 18:00:00', 'Post by user10', 'user10.jpg', 150),
(10, '2025-02-09 19:00:00', 'Post by user11', 'user11.jpg', 250),
(11, '2025-02-08 20:00:00', 'Post by user12', 'user12.jpg', 350),
(12, '2025-02-07 21:00:00', 'Gaming stream!', 'game1.jpg', 500),
(13, '2025-02-06 22:00:00', 'Nature is beautiful.', 'nature1.jpg', 700),
(14, '2025-02-05 23:00:00', 'Tech news update.', 'tech1.jpg', 1200),
(15, '2025-02-04 08:00:00', 'Foodie adventures.', 'food1.jpg', 180),
(16, '2025-02-03 09:00:00', 'Travel diary.', 'travel1.jpg', 800),
(17, '2025-02-02 10:00:00', 'Artistic vibes.', 'art1.jpg', 300),
(18, '2025-02-01 11:00:00', 'Blogging my thoughts.', 'blog1.jpg', 400),
(19, '2025-01-31 12:00:00', 'Another post!', 'post19.jpg', 100),
(20, '2025-01-30 13:00:00', 'Last post for testing.', 'post20.jpg', 50);

---------------------------------------------------
-- INSERT 20 STORIES
---------------------------------------------------
INSERT INTO story (UserId, Views, Timestamp) VALUES
(1, 1000, '2025-02-18 09:00:00'),
(2, 1100, '2025-02-17 09:30:00'),
(3, 1200, '2025-02-16 10:00:00'),
(4, 1300, '2025-02-15 10:30:00'),
(5, 1400, '2025-02-14 11:00:00'),
(6, 1500, '2025-02-13 11:30:00'),
(7, 1600, '2025-02-12 12:00:00'),
(8, 1700, '2025-02-11 12:30:00'),
(9, 1800, '2025-02-10 13:00:00'),
(10, 1900, '2025-02-09 13:30:00'),
(11, 2000, '2025-02-08 14:00:00'),
(12, 2100, '2025-02-07 14:30:00'),
(13, 2200, '2025-02-06 15:00:00'),
(14, 2300, '2025-02-05 15:30:00'),
(15, 2400, '2025-02-04 16:00:00'),
(16, 2500, '2025-02-03 16:30:00'),
(17, 2600, '2025-02-02 17:00:00'),
(18, 2700, '2025-02-01 17:30:00'),
(19, 2800, '2025-01-31 18:00:00'),
(20, 2900, '2025-01-30 18:30:00');

---------------------------------------------------
-- INSERT 20 COMMENTS
---------------------------------------------------
INSERT INTO comment (PostId, UserId, Timestamp) VALUES
(1, 2, '2025-02-18 10:30:00'),
(2, 3, '2025-02-18 11:00:00'),
(3, 4, '2025-02-18 11:30:00'),
(4, 5, '2025-02-18 12:00:00'),
(5, 6, '2025-02-18 12:30:00'),
(6, 7, '2025-02-18 13:00:00'),
(7, 8, '2025-02-18 13:30:00'),
(8, 9, '2025-02-18 14:00:00'),
(9, 10, '2025-02-18 14:30:00'),
(10, 11, '2025-02-18 15:00:00'),
(11, 12, '2025-02-18 15:30:00'),
(12, 13, '2025-02-18 16:00:00'),
(13, 14, '2025-02-18 16:30:00'),
(14, 15, '2025-02-18 17:00:00'),
(15, 16, '2025-02-18 17:30:00'),
(16, 17, '2025-02-18 18:00:00'),
(17, 18, '2025-02-18 18:30:00'),
(18, 19, '2025-02-18 19:00:00'),
(19, 20, '2025-02-18 19:30:00'),
(20, 1, '2025-02-18 20:00:00');

---------------------------------------------------
-- INSERT 20 FOLLOWING RELATIONSHIPS
---------------------------------------------------
INSERT INTO following (FollowerId, FolloweeId, Timestamp) VALUES
(1, 2, '2025-02-18 09:00:00'),
(2, 3, '2025-02-18 09:05:00'),
(3, 4, '2025-02-18 09:10:00'),
(4, 5, '2025-02-18 09:15:00'),
(5, 6, '2025-02-18 09:20:00'),
(6, 7, '2025-02-18 09:25:00'),
(7, 8, '2025-02-18 09:30:00'),
(8, 9, '2025-02-18 09:35:00'),
(9, 10, '2025-02-18 09:40:00'),
(10, 11, '2025-02-18 09:45:00'),
(11, 12, '2025-02-18 09:50:00'),
(12, 13, '2025-02-18 09:55:00'),
(13, 14, '2025-02-18 10:00:00'),
(14, 15, '2025-02-18 10:05:00'),
(15, 16, '2025-02-18 10:10:00'),
(16, 17, '2025-02-18 10:15:00'),
(17, 18, '2025-02-18 10:20:00'),
(18, 19, '2025-02-18 10:25:00'),
(19, 20, '2025-02-18 10:30:00'),
(20, 1, '2025-02-18 10:35:00');

---------------------------------------------------
-- INSERT 20 DIRECT MESSAGES
---------------------------------------------------
INSERT INTO DM (SenderId, RecipientId, Message, Timestamp) VALUES
(1, 2, 'DM 1 from user1 to user2', '2025-02-18 08:00:00');
(2, 3, 'DM 2 from user2 to user3', '2025-02-18 08:05:00');
(3, 4, 'DM 3 from user3 to user4', '2025-02-18 08:10:00');
(4, 5, 'DM 4 from user4 to user5', '2025-02-18 08:15:00');
(5, 6, 'DM 5 from user5 to user6', '2025-02-18 08:20:00');
(6, 7, 'DM 6 from user6 to user7', '2025-02-18 08:25:00');
(7, 8, 'DM 7 from user7 to user8', '2025-02-18 08:30:00');
(8, 9, 'DM 8 from user8 to user9', '2025-02-18 08:35:00');
(9, 10, 'DM 9 from user9 to user10', '2025-02-18 08:40:00');
(10, 11, 'DM 10 from user10 to user11', '2025-02-18 08:45:00');
(11, 12, 'DM 11 from user11 to user12', '2025-02-18 08:50:00');
(12, 13, 'DM 12 from user12 to user13', '2025-02-18 08:55:00');
(13, 14, 'DM 13 from user13 to user14', '2025-02-18 09:00:00');
(14, 15, 'DM 14 from user14 to user15', '2025-02-18 09:05:00');
(15, 16, 'DM 15 from user15 to user16', '2025-02-18 09:10:00');
(16, 17, 'DM 16 from user16 to user17', '2025-02-18 09:15:00');
(17, 18, 'DM 17 from user17 to user18', '2025-02-18 09:20:00');
(18, 19, 'DM 18 from user18 to user19', '2025-02-18 09:25:00');
(19, 20, 'DM 19 from user19 to user20', '2025-02-18 09:30:00');
(20, 1, 'DM 20 from user20 to user1', '2025-02-18 09:35:00');

---------------------------------------------------
-- INSERT 20 LIKES
---------------------------------------------------
INSERT INTO likes (UserId, PostId, Timestamp) VALUES
(1, 1, '2025-02-18 07:00:00'),
(2, 2, '2025-02-18 07:05:00'),
(3, 3, '2025-02-18 07:10:00'),
(4, 4, '2025-02-18 07:15:00'),
(5, 5, '2025-02-18 07:20:00'),
(6, 6, '2025-02-18 07:25:00'),
(7, 7, '2025-02-18 07:30:00'),
(8, 8, '2025-02-18 07:35:00'),
(9, 9, '2025-02-18 07:40:00'),
(10, 10, '2025-02-18 07:45:00'),
(11, 11, '2025-02-18 07:50:00'),
(12, 12, '2025-02-18 07:55:00'),
(13, 13, '2025-02-18 08:00:00'),
(14, 14, '2025-02-18 08:05:00'),
(15, 15, '2025-02-18 08:10:00'),
(16, 16, '2025-02-18 08:15:00'),
(17, 17, '2025-02-18 08:20:00'),
(18, 18, '2025-02-18 08:25:00'),
(19, 19, '2025-02-18 08:30:00'),
(20, 20, '2025-02-18 08:35:00');
