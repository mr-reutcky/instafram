-- Insert users
/*INSERT INTO users (Email, Bio, Username, ProfilePic, Password) VALUES*/
INSERT INTO users (Email, Bio, Username, ProfilePic, Password) VALUES
('cristiano@email.com', 'Football legend', 'cristiano', 'images/profiles/cr7.jpg', 'pass123'),
('messi@email.com', 'GOAT in football', 'messi', 'images/profiles/messi.png', 'pass123'),
('serena@email.com', 'Tennis icon', 'serenawilliams', 'images/profiles/serena.jpg', 'pass123'),
('aplasticplant@email.com', 'Lover of greenery', 'aplasticplant', 'images/profiles/plant.png', 'pass123'),
('moviebuff@email.com', 'Quotes all day', 'movie_quotes', 'images/profiles/movie.jpg', 'pass123'),
('partylover@email.com', 'Life of the party!', 'lifeoftheparty', 'images/profiles/party.jpg', 'pass123'),
('chatty@email.com', 'Talks a lot', 'that_talkative_user', 'images/profiles/chatty.png', 'pass123'),
('naturelover@email.com', 'Nature enthusiast', 'nature_lover', 'images/profiles/nature.jpg', 'pass123'),
('techguru@email.com', 'Tech nerd', 'tech_guru', 'images/profiles/tech.png', 'pass123'),
('foodie@email.com', 'Food reviewer', 'food_critic', 'images/profiles/food.jpg', 'pass123'),
('gamer@email.com', 'Pro gamer', 'game_master', 'images/profiles/gamer.png', 'pass123'),
('artist@email.com', 'Painter and designer', 'art_lover', 'images/profiles/art.jpg', 'pass123'),
('musician@email.com', 'Loves music', 'rockstar', 'images/profiles/music.png', 'pass123'),
('traveler@email.com', 'World traveler', 'globetrotter', 'images/profiles/travel.jpg', 'pass123'),
('writer@email.com', 'Writes fiction', 'storyteller', 'images/profiles/writer.jpg', 'pass123'),
('teacher@email.com', 'Passionate educator', 'edu_wizard', 'images/profiles/teacher.png', 'pass123'),
('developer@email.com', 'Software engineer', 'code_ninja', 'images/profiles/dev.jpg', 'pass123'),
('photographer@email.com', 'Capturing moments', 'photo_sniper', 'images/profiles/photo.jpg', 'pass123'),
('fitness@email.com', 'Gym rat', 'fit_freak', 'images/profiles/fitness.png', 'pass123'),
('scientist@email.com', 'Loves experiments', 'science_geek', 'images/profiles/science.jpg', 'pass123');

-- Insert follows (ensuring Cristiano has at least 15 followers)
INSERT INTO follow (FollowerId, FolloweeId, Timestamp) VALUES
(2, 1, CURRENT_TIMESTAMP),
(3, 1, CURRENT_TIMESTAMP),
(4, 1, CURRENT_TIMESTAMP),
(5, 1, CURRENT_TIMESTAMP),
(6, 1, CURRENT_TIMESTAMP),
(7, 1, CURRENT_TIMESTAMP),
(8, 1, CURRENT_TIMESTAMP),
(9, 1, CURRENT_TIMESTAMP),
(10, 1, CURRENT_TIMESTAMP),
(11, 1, CURRENT_TIMESTAMP),
(12, 1, CURRENT_TIMESTAMP),
(13, 1, CURRENT_TIMESTAMP),
(14, 1, CURRENT_TIMESTAMP),
(15, 1, CURRENT_TIMESTAMP),
(16, 1, CURRENT_TIMESTAMP),
-- Additional follows for variation
(1, 2, CURRENT_TIMESTAMP),
(3, 2, CURRENT_TIMESTAMP),
(4, 3, CURRENT_TIMESTAMP),
(5, 4, CURRENT_TIMESTAMP),
(6, 5, CURRENT_TIMESTAMP);

-- Insert posts (3 per user)
INSERT INTO post (UserId, Caption, Picture, Timestamp) VALUES
(1, 'Training hard!', 'post1.jpg', CURRENT_TIMESTAMP),
(1, 'Game day!', 'post2.jpg', CURRENT_TIMESTAMP),
(1, 'Victory!', 'post3.jpg', CURRENT_TIMESTAMP),
(2, 'Practice session!', 'post4.jpg', CURRENT_TIMESTAMP),
(2, 'Match highlights!', 'post5.jpg', CURRENT_TIMESTAMP),
(2, 'Family time!', 'post6.jpg', CURRENT_TIMESTAMP),
(3, 'Tennis training!', 'post7.jpg', CURRENT_TIMESTAMP),
(3, 'Grand Slam memories!', 'post8.jpg', CURRENT_TIMESTAMP),
(3, 'Winning moment!', 'post9.jpg', CURRENT_TIMESTAMP);

-- Insert likes (15-20 per post, randomized users)
INSERT INTO likes (UserId, PostId, Timestamp) VALUES
(2, 1, CURRENT_TIMESTAMP), (3, 1, CURRENT_TIMESTAMP), (4, 1, CURRENT_TIMESTAMP),
(5, 1, CURRENT_TIMESTAMP), (6, 1, CURRENT_TIMESTAMP), (7, 1, CURRENT_TIMESTAMP),
(8, 1, CURRENT_TIMESTAMP), (9, 1, CURRENT_TIMESTAMP), (10, 1, CURRENT_TIMESTAMP),
(11, 1, CURRENT_TIMESTAMP), (12, 1, CURRENT_TIMESTAMP), (13, 1, CURRENT_TIMESTAMP),
(14, 1, CURRENT_TIMESTAMP), (15, 1, CURRENT_TIMESTAMP), (16, 1, CURRENT_TIMESTAMP),
(17, 1, CURRENT_TIMESTAMP), (18, 1, CURRENT_TIMESTAMP);

-- Insert comments (5-10 per post)
INSERT INTO comment (UserId, PostId, Comment, Timestamp) VALUES
(2, 1, 'Great job!', CURRENT_TIMESTAMP),
(3, 1, 'Amazing performance!', CURRENT_TIMESTAMP),
(4, 1, 'Keep it up!', CURRENT_TIMESTAMP),
(5, 1, 'Legend!', CURRENT_TIMESTAMP),
(6, 1, 'Outstanding play!', CURRENT_TIMESTAMP),
(7, 1, 'Inspirational!', CURRENT_TIMESTAMP);

-- Insert stories (expiring in 1 minute for testing)
INSERT INTO story (Views, Likes, UserId, Timestamp, ExpirationTime) VALUES
(100, 10, 1, '2025-02-19 14:00:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP)),
(250, 50, 2, '2025-02-18 12:30:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP)),
(75, 5, 3, '2025-02-19 08:45:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP)),
(300, 80, 4, '2025-02-17 17:15:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP)),
(20, 1, 5, '2025-02-19 21:00:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP));


-- Insert DMs (10 per user to 3 different users)
INSERT INTO DM (SenderId, RecipientId, Message, Timestamp) VALUES
(1, 2, 'Hey, how’s training?', CURRENT_TIMESTAMP),
(1, 3, 'Looking forward to the game!', CURRENT_TIMESTAMP),
(1, 4, 'Good luck!', CURRENT_TIMESTAMP),
(2, 1, 'Thanks! Excited for it!', CURRENT_TIMESTAMP),
(2, 3, 'Nice match today.', CURRENT_TIMESTAMP),
(2, 4, 'See you at the press conference.', CURRENT_TIMESTAMP),
(3, 1, 'Well played!', CURRENT_TIMESTAMP),
(3, 2, 'Training tips?', CURRENT_TIMESTAMP),
(3, 4, 'What a great tournament!', CURRENT_TIMESTAMP);
