SELECT name
FROM (
    SELECT e.name, COUNT(e1.id) AS num_reports
    FROM Employee e
    JOIN Employee e1 ON e.id = e1.managerId
    GROUP BY e.id, e.name
) subquery
WHERE num_reports >= 5;
