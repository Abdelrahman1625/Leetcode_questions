# Write your MySQL query statement below
Select id, movie, description, rating 
From cinema 
Where id %2 = 1 && description != 'boring'
ORDER BY rating DESC;