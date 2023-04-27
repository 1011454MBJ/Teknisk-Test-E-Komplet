use FitterTest;

SELECT *
FROM Foremans
JOIN JobTitles ON Foremans.JobTitleID = JobTitles.JobTitleID
LEFT JOIN FitterForeman ON FitterForeman.ForemanID=Foremans.ForemanID
LEFT JOIN Fitters ON FitterForeman.FitterID=Fitters.FitterID
LEFT JOIN JobTitles AS JobT ON Fitters.JobTitleID=JobT.JobTitleID
WHERE Foremans.JobTitleID=100