CREATE DATABASE Tithi;
DROP DATABASE Tithi;

Use Tithi;

CREATE TABLE Student
(
StudentID INT NOT NULL,
StudentName VARCHAR(50),
DateofBirth DATE,
YearEnrolled VARCHAR(10),
CONSTRAINT pk_studentid PRIMARY KEY(studentid)
);

ALTER TABLE student
ADD sGrade VARCHAR (10);

DROP TABLE Student;

CREATE TABLE student_Lecturer
(
sid2 int NOT NULL,
Lid2 int NOT NULL,
CONSTRAINT pk_student_lec PRIMARY KEY(sid2, LID2),
CONSTRAINT fk_sid2 FOREIGN KEY(sid2) REFERENCES student(StudentID),
CONSTRAINT fk_Lid2 FOREIGN KEY(Lid2) REFERENCES Lecturer(Lid)
);


DROP TABLE student_lecturer;

CREATE TABLE Course
(
CourseID INT NOT NULL,
CourseName VARCHAR(50),
pid INT,
CONSTRAINT pk_courseid PRIMARY KEY(CourseID),
CONSTRAINT fk_program FOREIGN KEY(pid) REFERENCES program(programid)
);

DROP TABLE Course;

CREATE TABLE Lecturer_course
(
Cid2 INT NOT NULL,
LecID INT NOT NULL,
CONSTRAINT pk_Lec_course PRIMARY KEY (cid2, Lecid),
CONSTRAINT fk_cid2 FOREIGN KEY(cid2) REFERENCES course(courseid),
CONSTRAINT fk_Lecid FOREIGN KEY (LecID) REFERENCES Lecturer (LID)
);

DROP TABLE Lecturer_Course;

CREATE TABLE Lecturer
(
LID INT ,
LName VARCHAR(50),
LTitle VARCHAR(30),
Lofficeroom VARCHAR(20),
SupID INT,
CONSTRAINT pk_LID PRIMARY KEY(LID),
CONSTRAINT fk_supervisorID FOREIGN KEY(SupID) REFERENCES Supervisor(supervisorid)
);

DROP TABLE Lecturer;

CREATE TABLE Supervisor
(
SupervisorID INT NOT NULL,
SupervisorName VARCHAR(50),
STitle VARCHAR(20),
SOfficeRoom VARCHAR(20),
CONSTRAINT pk_supervisorid PRIMARY KEY(supervisorid)
);

DROP TABLE Supervisor;

CREATE TABLE Committee_Lec
(
ComID INT NOT NULL,
LecID2 INT NOT NULL,
CONSTRAINT pk_Committee_Lec PRIMARY KEY(comID, Lecid2),
CONSTRAINT fk_ComID FOREIGN KEY(ComID) REFERENCES Committee(committeeID),
CONSTRAINT fk_LecID2 FOREIGN KEY (LecID2) REFERENCES Lecturer(LID)
);

CREATE TABLE Committee
(
CommitteeID INT NOT NULL,
CommitteeName VARCHAR(50),
fac_ID INT,
CONSTRAINT pk_CommitteeID PRIMARY KEY(CommitteeID),
CONSTRAINT fk_facultyID FOREIGN KEY(fac_ID) REFERENCES Faculty(FacultyID)
);

DROP TABLE Committee;

CREATE TABLE Program
(
ProgramID INT NOT NULL,
PTitle VARCHAR(50),
LevelNo VARCHAR(25),
Duration DATETIME,
facid2 int,
CONSTRAINT pk_Programid PRIMARY KEY(Programid),
CONSTRAINT fk_facultyID2 FOREIGN KEY(facid2) REFERENCES Faculty(Facultyid)
);

DROP TABLE program;

CREATE TABLE Faculty
(
FacultyID INT NOT NULL,
FacultyName VARCHAR(50),
Dean VARCHAR(50),
Building VARCHAR(25),
CONSTRAINT pk_Facultyid PRIMARY KEY(FacultyID),

);

DROP TABLE Faculty;

CREATE TABLE Works_on
(
StdntID INT NOT NULL,
CrsID INT NOT NULL,
ExamDate INT NOT NULL,
ExaminationID INT NOT NULL,
Grade VARCHAR(10),
LectrID INT,
CONSTRAINT pk_works_on PRIMARY KEY(stdntID,crsID, ExamDate, ExaminationID),
CONSTRAINT fk_stdntID FOREIGN KEY(stdntID) REFERENCES student(StudentID),
CONSTRAINT fk_crsID FOREIGN KEY(crsID) REFERENCES Course(CourseID),
CONSTRAINT fk_LectrID FOREIGN KEY(LectrID) REFERENCES Lecturer(LID)
);

DROP TABLE Works_on;




SELECT * FROM Student;


