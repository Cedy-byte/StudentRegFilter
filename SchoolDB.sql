Create database SchoolReg

CREATE TABLE STUDENTS(
StudentID INT IDENTITY(10,1) PRIMARY KEY NOT NULL,
Name VARCHAR (200) NOT NULL,
Surname VARCHAR (200) NOT NULL,
Addrress VARCHAR (200) NOT NULL,
Course VARCHAR (200) NOT NULL,
YearOfStudy date NOT NULL,
DateOfReg DateTime NOT NULL);

Select * from Students