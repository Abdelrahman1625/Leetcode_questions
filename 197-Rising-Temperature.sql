# Write your MySQL query statement below
Select w1.id
from Weather  w1
join Weather w2
ON DATEDIFF(w1.RecordDate, w2.RecordDate) = 1
where w1.temperature > w2.temperature