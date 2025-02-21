
-- Insert users
INSERT INTO users (Email, Bio, Username, ProfilePic, Password) VALUES
('cristiano@email.com', 'A football legend known for his incredible skills, record-breaking goals, and dedication to the sport.', 'cristiano', 'User1.jpg', 'pass123'),
('messi@email.com', 'Often regarded as the GOAT in football, known for his dribbling, vision, and goal-scoring ability.', 'messi', 'User2.jpg', 'pass123'),
('serena@email.com', 'A tennis icon with an unmatched legacy, inspiring generations with her strength and determination.', 'serenawilliams', 'User3.jpg', 'pass123'),
('aplasticplant@email.com', 'A passionate lover of greenery who collects and cares for plants, both real and artificial.', 'aplasticplant', 'User4.jpg', 'pass123'),
('moviebuff@email.com', 'Loves watching movies and quoting famous lines from classics and the latest blockbusters.', 'movie_quotes', 'User5.jpg', 'pass123'),
('partylover@email.com', 'Always the life of the party, bringing energy, fun, and unforgettable moments to every event.', 'lifeoftheparty', 'User6.jpg', 'pass123'),
('chatty@email.com', 'A social butterfly who loves talking, sharing stories, and making new friends.', 'that_talkative_user', 'User7.jpg', 'pass123'),
('naturelover@email.com', 'A dedicated nature enthusiast who enjoys hiking, camping, and exploring the great outdoors.', 'nature_lover', 'User8.jpg', 'pass123'),
('techguru@email.com', 'A tech nerd who stays updated with the latest innovations, gadgets, and software trends.', 'tech_guru', 'User9.jpg', 'pass123'),
('foodie@email.com', 'A food critic and enthusiast who loves discovering new flavors and reviewing different cuisines.', 'food_critic', 'User10.jpg', 'pass123'),
('gamer@email.com', 'A hardcore gamer who enjoys competitive play, strategy, and exploring vast virtual worlds.', 'game_master', 'User11.jpg', 'pass123'),
('artist@email.com', 'A creative painter and designer who expresses emotions through colors and artistic strokes.', 'art_lover', 'User12.jpg', 'pass123'),
('musician@email.com', 'A passionate musician who loves creating, performing, and listening to all kinds of music.', 'rockstar', 'User13.jpg', 'pass123'),
('traveler@email.com', 'An adventurer and world traveler, always exploring new cultures, places, and experiences.', 'globetrotter', 'User14.jpg', 'pass123'),
('writer@email.com', 'A storyteller with a love for crafting engaging fiction, poetry, and thought-provoking articles.', 'storyteller', 'User15.jpg', 'pass123'),
('teacher@email.com', 'A dedicated educator who loves sharing knowledge and inspiring the next generation.', 'edu_wizard', 'User16.jpg', 'pass123'),
('developer@email.com', 'A software engineer with a passion for coding, problem-solving, and building innovative applications.', 'code_ninja', 'User17.jpg', 'pass123'),
('photographer@email.com', 'A creative photographer capturing life’s most beautiful moments through the lens.', 'photo_sniper', 'User18.jpg', 'pass123'),
('fitness@email.com', 'A fitness enthusiast who believes in health, strength, and pushing limits in the gym.', 'fit_freak', 'User19.jpg', 'pass123'),
('scientist@email.com', 'A science geek who enjoys conducting experiments and exploring the mysteries of the universe.', 'science_geek', 'User20.jpg', 'pass123');



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
INSERT INTO post (UserId, Caption, Picture, Timestamp, Likes) VALUES
(1, 'Training hard!', '../Images/img2.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(1, 'Game day!', '../Images/img3.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(1, 'Victory!', '../Images/img4.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(2, 'Practice session!', '../Images/img5.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(2, 'Match highlights!', '../Images/img6.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(2, 'Family time!', '../Images/img7.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(3, 'Tennis training!', '../Images/img8.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(3, 'Grand Slam memories!', '../Images/img9.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000)),
(3, 'Winning moment!', '../Images/img10.jpg', CURRENT_TIMESTAMP, FLOOR(RAND() * 1000));


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
INSERT INTO story (Views, UserId, Timestamp, ExpirationTime, Picture, LikeStory) VALUES
(100, 1, '2025-02-19 14:00:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP), '../Images/img1.jpg', 1),
(250, 2, '2025-02-18 12:30:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP), '../Images/img2.jpg', 2),
(75, 3, '2025-02-19 08:45:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP), '../Images/img3.jpg', 3),
(300,  4, '2025-02-17 17:15:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP), '../Images/img4.jpg', 4),
(20, 5, '2025-02-19 21:00:00', DATEADD(HOUR, 24, CURRENT_TIMESTAMP), '../Images/img5.jpg', 5);

-- Insert storylikes (15-20 per post, randomized users)
INSERT INTO storylikes (UserId, StoryId, Timestamp) VALUES
(2, 1, CURRENT_TIMESTAMP), (3, 1, CURRENT_TIMESTAMP), (4, 1, CURRENT_TIMESTAMP),
(5, 1, CURRENT_TIMESTAMP), (6, 1, CURRENT_TIMESTAMP), (7, 1, CURRENT_TIMESTAMP),
(8, 1, CURRENT_TIMESTAMP), (9, 1, CURRENT_TIMESTAMP), (10, 1, CURRENT_TIMESTAMP),
(11, 1, CURRENT_TIMESTAMP), (12, 1, CURRENT_TIMESTAMP), (13, 1, CURRENT_TIMESTAMP),
(14, 1, CURRENT_TIMESTAMP), (15, 1, CURRENT_TIMESTAMP), (16, 1, CURRENT_TIMESTAMP),
(17, 1, CURRENT_TIMESTAMP), (18, 1, CURRENT_TIMESTAMP);


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
