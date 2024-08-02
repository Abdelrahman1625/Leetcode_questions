# Write your MySQL query statement below
SELECT
    DATE_FORMAT(trans_date, '%Y-%m') AS month,
    country,
    count(state) AS trans_count,
    sum(CASE WHEN state = 'approved' THEN 1 ELSE 0 END) AS approved_count,
    sum(amount) AS trans_total_amount,
    sum(CASE WHEN state = 'approved' THEN amount ELSE 0 END) AS approved_total_amount 
FROM
    Transactions
GROUP BY DATE_FORMAT(trans_date, '%Y-%m'), country;