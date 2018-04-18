SELECT Status,IssueDate
FROM Jobs
WHERE NOT Status = 'Finished'
ORDER BY IssueDate,JobId