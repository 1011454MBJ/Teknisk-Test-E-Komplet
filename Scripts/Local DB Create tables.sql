--Creating tables for Teknisk Test E-Komplet

--CREATE DATABASE FitterTest
USE FitterTest

CREATE TABLE JobTitles
(
	JobTitleID int IDENTITY(100,100) PRIMARY KEY,
	JobTitle varchar(200)
)

CREATE TABLE Fitters
(
	FitterID int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(100) NOT NULL,
	LastName varchar(100) NOT NULL,
	PhoneNumber varchar(30) NOT NULL,
	JobTitleID int NOT NULL,
	FOREIGN KEY (JobTitleID) REFERENCES JobTitles(JobTitleID)
)

CREATE TABLE Foremans
(
    ForemanID int IDENTITY(10,10) PRIMARY KEY,
    FirstName varchar(100) NOT NULL,
    LastName varchar(100) NOT NULL,
    PhoneNumber varchar(30) NOT NULL,
    JobTitleID int NOT NULL,
    FOREIGN KEY (JobTitleID) REFERENCES JobTitles(JobTitleID)
)

CREATE TABLE FitterForeman
(
	ForemanID int NOT NULL,
	FitterID int,
	--PRIMARY KEY (ForemanID, FitterID),
	FOREIGN KEY (ForemanID) REFERENCES Foremans(ForemanID),
	FOREIGN KEY (FitterID) REFERENCES Fitters(FitterID),
	CONSTRAINT UC_FitterForeman UNIQUE (ForemanID, FitterID)
)
