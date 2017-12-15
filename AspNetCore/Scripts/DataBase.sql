
drop table Enrollment
drop table Course
drop table STudent


select * from student

create table Student
(
	ID int not null identity(1,1) primary key ,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	EnrollmentDate datetime not null default(getdate())
)

create table Course
(
	ID int not null identity(1,1) primary key ,
	Title varchar(50) not null,
	Credits int not null
)


create table Enrollment
(
	ID int not null primary key identity(1,1),
	CourseID int not null foreign key references Course(ID),
	StudenID int not null foreign key references Student(ID),
	Grade char(1) null,
)