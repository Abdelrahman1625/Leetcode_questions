# Write your MySQL query statement below
WITH FirstLogins AS (
  SELECT player_id, MIN(event_date) AS first_login_date
  FROM Activity
  GROUP BY player_id
)
SELECT ROUND(COUNT(a2.player_id) / COUNT(DISTINCT a1.player_id), 2) AS fraction
FROM Activity a1
LEFT JOIN Activity a2 ON a1.player_id = a2.player_id
  AND a2.event_date = DATE_ADD(a1.event_date, INTERVAL 1 DAY)
  AND a1.event_date = (SELECT first_login_date FROM FirstLogins WHERE player_id = a1.player_id)