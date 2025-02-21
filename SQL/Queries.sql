-- Query 1
SELECT u.Username
FROM follow f
JOIN users u ON f.FollowerId = u.UserId
WHERE f.FolloweeId = (SELECT UserId FROM users WHERE Username = 'cristiano');

-- Query 2
SELECT p.PostId, p.Timestamp AS PostTimestamp, p.Caption, p.Picture, 'Post' AS Type
FROM post p
JOIN follow f ON p.UserId = f.FolloweeId
JOIN users u ON f.FollowerId = u.UserId
WHERE u.Username = 'messi' 
    AND p.Timestamp >= DATEADD(WEEK, -1, GETDATE())
SELECT s.StoryId, s.Timestamp AS StoryTimestamp, s.Picture, NULL AS Caption, 'Story' AS Type
FROM story s
JOIN follow f ON s.UserId = f.FolloweeId
JOIN users u ON f.FollowerId = u.UserId
WHERE u.Username = 'messi' 
    AND s.Timestamp >= DATEADD(WEEK, -1, GETDATE())
ORDER BY PostTimestamp DESC, StoryTimestamp DESC;

-- Query 3
SELECT p.PostId, p.Timestamp AS PostTimestamp, p.Caption, p.Picture, 'Post' AS Type
FROM post p
LEFT JOIN likes l ON p.PostId = l.PostId
LEFT JOIN comment c ON p.PostId = c.PostId
JOIN users u ON (l.UserId = u.UserId OR c.UserId = u.UserId)
WHERE u.Username = 'serenawilliams'

SELECT s.StoryId, s.Timestamp AS StoryTimestamp, s.Picture, NULL AS Caption, 'Story' AS Type
FROM story s
LEFT JOIN storylikes sl ON s.StoryId = sl.StoryId
LEFT JOIN comment c ON s.StoryId = c.PostId
JOIN users u ON (sl.UserId = u.UserId OR c.UserId = u.UserId)
WHERE u.Username = 'serenawilliams'
ORDER BY PostTimestamp DESC, StoryTimestamp DESC;

-- Query 4
SELECT u.UserId, u.Username, COUNT(f.FollowerId) AS FollowerCount
FROM users u
JOIN follow f ON u.UserId = f.FolloweeId
WHERE u.ProfilePic IS NULL
GROUP BY u.UserId, u.Username
ORDER BY FollowerCount DESC
LIMIT 5;

-- Query 5

-- Query 6

-- Query 7
SELECT s.UserId, u.Username, SUM(sv.Views) AS TotalViews
FROM story s
JOIN storyviews sv ON s.Id = sv.StoryId
JOIN users u ON s.UserId = u.Id
GROUP BY s.UserId, u.Username
ORDER BY TotalViews DESC
LIMIT 1;

-- Query 8
-- Not sure if this is correct
WITH StoryLikes AS (
    SELECT sl.UserId, COUNT(*) AS LikesCount
    FROM storylikes sl
    JOIN story s ON sl.StoryId = s.StoryId
    WHERE s.UserId = (SELECT UserId FROM users WHERE Username = 'movie_quotes')
    GROUP BY sl.UserId
),
DMs AS (
    SELECT SenderId AS UserId, COUNT(*) AS DMCount 
    FROM DM 
    WHERE RecipientId = (SELECT UserId FROM users WHERE Username = 'movie_quotes')
    GROUP BY SenderId
    UNION ALL
    SELECT RecipientId AS UserId, COUNT(*) AS DMCount 
    FROM DM 
    WHERE SenderId = (SELECT UserId FROM users WHERE Username = 'movie_quotes')
    GROUP BY RecipientId
)
SELECT sl.UserId, sl.LikesCount, COALESCE(SUM(dm.DMCount), 0) AS DMCount
FROM StoryLikes sl
LEFT JOIN DMs dm ON sl.UserId = dm.UserId
GROUP BY sl.UserId, sl.LikesCount
ORDER BY sl.LikesCount DESC, DMCount ASC;


-- Query 9
SELECT DISTINCT s.*
FROM story s
JOIN storylikes sl ON s.Id = sl.StoryId
WHERE sl.UserId IN (
    SELECT DISTINCT c.UserId
    FROM comment c
    WHERE c.PostId = 1
);


-- Query 10
WITH FirstDM AS (
    SELECT DM.RecipientId, MIN(DM.Timestamp) AS FirstDMTime
    FROM DM
    JOIN users u ON DM.SenderId = u.UserId
    WHERE u.Username = 'lifeoftheparty'
    GROUP BY DM.RecipientId
),
FirstPost AS (
    SELECT p.UserId, MIN(p.Timestamp) AS FirstPostTime
    FROM post p
    GROUP BY p.UserId
)
SELECT u.Username
FROM follow f
JOIN users u ON f.FolloweeId = u.UserId
LEFT JOIN FirstDM fd ON f.FolloweeId = fd.RecipientId
LEFT JOIN FirstPost fp ON f.FolloweeId = fp.UserId
WHERE f.FollowerId = (SELECT UserId FROM users WHERE Username = 'lifeoftheparty')
AND fd.FirstDMTime IS NOT NULL
AND fp.FirstPostTime > fd.FirstDMTime;
