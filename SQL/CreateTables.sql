-- Drop tables in the correct order to avoid foreign key errors
DROP TABLE IF EXISTS likes;
DROP TABLE IF EXISTS storylikes;
DROP TABLE IF EXISTS DM;
DROP TABLE IF EXISTS story;
DROP TABLE IF EXISTS follow;
DROP TABLE IF EXISTS comment;
DROP TABLE IF EXISTS post;
DROP TABLE IF EXISTS users;

-- Create users table
CREATE TABLE users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Bio NVARCHAR(500),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    ProfilePic NVARCHAR(255),
    Password NVARCHAR(255) NOT NULL
);

-- Create post table
CREATE TABLE post (
    PostId INT IDENTITY(1,1) PRIMARY KEY,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    Views INT DEFAULT 0,
    Likes INT DEFAULT 0,
    UserId INT,
    Caption NVARCHAR(500),
    Picture NVARCHAR(255),
    FOREIGN KEY (UserId) REFERENCES users(UserId) ON DELETE CASCADE
);

-- Create comment table
CREATE TABLE comment (
    CommentId INT IDENTITY(1,1) PRIMARY KEY,
    PostId INT,
    UserId INT,
    Comment NVARCHAR(500) NOT NULL,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (PostId) REFERENCES post(PostId) ON DELETE CASCADE,
    FOREIGN KEY (UserId) REFERENCES users(UserId) ON DELETE NO ACTION
);

-- Create follow table
CREATE TABLE follow (
    FollowId INT IDENTITY(1,1) PRIMARY KEY,
    FollowerId INT,
    FolloweeId INT,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (FollowerId) REFERENCES users(UserId) ON DELETE CASCADE,
    FOREIGN KEY (FolloweeId) REFERENCES users(UserId) ON DELETE NO ACTION,
    CONSTRAINT unique_follow UNIQUE (FollowerId, FolloweeId)
);

-- Create story table
CREATE TABLE story (
    StoryId INT IDENTITY(1,1) PRIMARY KEY,
    Views INT DEFAULT 0,
    UserId INT,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    ExpirationTime DATETIME,
    FOREIGN KEY (UserId) REFERENCES users(UserId) ON DELETE CASCADE
);

-- Create DM table
CREATE TABLE DM (
    DMId INT IDENTITY(1,1) PRIMARY KEY,
    SenderId INT,
    RecipientId INT,
    Message NVARCHAR(1000) NOT NULL,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (SenderId) REFERENCES users(UserId) ON DELETE CASCADE,
    FOREIGN KEY (RecipientId) REFERENCES users(UserId) ON DELETE NO ACTION
);

-- Create likes table
CREATE TABLE likes (
    LikeId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT,
    PostId INT,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES users(UserId) ON DELETE CASCADE,
    FOREIGN KEY (PostId) REFERENCES post(PostId) ON DELETE NO ACTION,
);

-- Create storylikes table
CREATE TABLE storylikes (
    StoryLikeId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT,
    StoryId INT,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES users(UserId) ON DELETE CASCADE,
    FOREIGN KEY (StoryId) REFERENCES story(StoryId) ON DELETE NO ACTION,
);
