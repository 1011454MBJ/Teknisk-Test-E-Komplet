USE FitterTest

INSERT INTO JobTitles (JobTitle) 
VALUES('Overmontør'), ('Montør');

INSERT INTO Fitters (FirstName, LastName, PhoneNumber, JobTitleID) 
VALUES('Alice', 'Cooper', '+44 888757512', 200),
('Margrethe', 'Rechs', '+45 45454545', 200),
('Juan', 'Jensen', '+45 50403020', 200),
('Pierre', 'Picard', '+45 20304050', 200),
('Hans', 'Hansen', '+45 70501892', 200);

INSERT INTO Foremans (FirstName, LastName, PhoneNumber, JobTitleID)
VALUES('Peter', 'Jessen', '+45 50504040', 100),
('Ali', 'Taheri', '+45 70709090', 100),
('Pedro', 'Gonzales', '+45 12345678', 100);

INSERT INTO FitterForeman (ForemanID, FitterID)
VALUES(10, 1),
(10, 2),
(10, 3),
(20, 2),
(20, 4),
(20, 5),
(30, NULL);

SELECT * FROM FitterForeman; 
SELECT * FROM Foremans;
SELECT * FROM Fitters;
SELECT * FROM JobTitles;