go
create database School_Manage_System

use School_Manage_System

go
CREATE TABLE Users
(
  UserID int primary key identity,
  FristName varchar (50) NOT NULL,
  LastName varchar (50) NOT NULL,
  UserName varchar (50) NOt NULL,
  Password varchar (50) NOT NULL,
  Usertype varchar (50) NOt NULL,
)

SELECT * From Student where Se
go
create table Department
(
   DeptID int primary key identity,
   DetyName varchar (50) not null,
   HoD varchar (50) not null,
   AddedDate Date default getdate()
)



go
create table Classes 
(
   ClassID int primary key Identity,
   ClassName varchar (50) not null,
   DeptID int foreign key references Department(DeptID) 
)

select * from Classes

SELECT Classes.ClassID,Classes.ClassName,Department.DeptID,Department.DetyName from Classes left join Department On Classes.DeptID = Department.DeptID

go
create table Teacher
(
   TeacherID int primary key identity,
   TeacherName varchar (50) not null,
   Gender varchar (50) not null,
   Phone varchar (50) not null,
   TeacherSubj varchar (50) not null,
   Dob date,
   status varchar (50) default 'active'
)



go
create table Student
(
   StudentID int primary key Identity,
   StudentName varchar (50) not null,
   Sex varchar (50) not null,
   Phone varchar (50) not null,
   Dob Date,
   status varchar (50) default 'active',
   ClassID int foreign key references Classes(ClassID)
)


go
create table StudentCharges
(
   ChargeID int primary key identity,
   StudentID int foreign key references Student(StudentID),
   ChargeMonth varchar (50),
   ChargeDate date default Getdate(),
   Amount decimal(18,2)
)

go
create table CashReceipt 
(
   RefNo int primary key identity,
   StudentID int foreign key references Student(StudentID),
   ChargeID int foreign key references StudentCharges(ChargeID),
   Amount decimal(18,2),
   Discount decimal(18,2),
   TranDate Date default getdate()
)


go
create table Course 
(
   CourseID int primary key identity,
   CourseName varchar(50),
   CourseDescrip varchar(50),
   CourseHours int 
)

GO 
create table Score
(
  ScoreID int primary key identity,
  StudentID int foreign key references Student(StudentID),
  CourseID int foreign key references Course(CourseID),
  Score decimal(18,2) 

)
SELECT Classes.ClassID,Classes.ClassName,Department.DeptID,Department.DetyName from Classes left join Department On Classes.DeptID = Department.DeptID
SELECT Score.ScoreID,Score.Score,Student.StudentID,Course.CourseID from Score inner join Student Classes On Score.CourseID  = Student.ID



 go 
 create procedure UspAddEditUsers
 @userid int, @fname varchar(50), @lname varchar(50),
 @username varchar(50),@password varchar(50), @usertype varchar(50),@type varchar(50)
 As 
 if @type = 'INSERT'
 begin
      INSERT INTO Users(FristName,LastName,UserName,Password,Usertype)
	  VALUES(@fname,@lname,@username,@password,@usertype)
 END
 if @type = 'UPDATE'
 begin
      UPDATE Users set
	         FristName = @fname,
			 LastName = @lname,
			 Usertype = @usertype
			 where UserID = @userid

end
if @type = 'DELETE'
begin 
     DELETE FROM Users where UserID = @userid
end



go


---------------------------------------------------

select UserID,UserName,Password,UserType from Users
 go 
 create procedure UspUserChangePassword
 @userid int,
 @username varchar(50),@password varchar(50),@type varchar(50)
 As 
 if @type = 'INSERT'
 begin
      INSERT INTO Users(UserName,Password)
	  VALUES(@username,@password)
 END
 if @type = 'UPDATE'
 begin
      UPDATE Users set
			 Password = @password,
			 UserName = @username
			 where UserID = @userid

end
if @type = 'DELETE'
begin 
     DELETE FROM Users where UserID = @userid
end



go





-----------------------------------
SELECT DeptID, DetyName FROM Department
SELECT 0 as DeptID,'Select Department' as DetyName UNION ALL SELECT DeptID,DetyName FROM Department
select * from Department

drop procedure UspAddEditDepartment
go
create procedure UspAddEditDepartment
@deptid int,
@detyname varchar(50),
@hod varchar(50),
@type varchar(50)
As 
if @type = 'INSERT'
begin
      INSERT INTO Department(DetyName,HoD)
	  VALUES(@detyname,@hod)
END
if @type = 'UPDATE'
begin
      UPDATE Department set
			 DetyName = @detyname,
			 HoD = @hod
			 where DeptID = @deptid

end
if @type = 'DELETE'
begin 
     DELETE FROM Department where DeptID = @deptid
end



go



--------------------------------------
drop procedure UspAddEditStudent
 go 
 create procedure UspAddEditStudent
 @studentid int, @studentname varchar(50), @classname int,
 @phone varchar(50),@dob varchar(50),@sex varchar(50),@type varchar(50)
 As 
 if @type = 'INSERT'
 begin
      INSERT INTO Student (StudentName,Sex,Phone,Dob,ClassID)
	  VALUES(@studentname,@sex,@phone,@dob,@classname)
 END
 if @type = 'UPDATE'
 begin
      UPDATE Student set
	         StudentName = @studentname,
			 Sex = @sex,
			 ClassID = @classname,
			 Phone = @phone,
			 Dob = @dob
			 where StudentID = @studentid

end
if @type = 'DELETE'
begin 
     DELETE FROM Student where StudentID = @studentid
end

go

select * from Classes
SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID

SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Classes.ClassID from Student left join Classes On Student.ClassID = Classes.ClassID

SELECT Classes.ClassID,Classes.ClassName,Department.DeptID,Department.DetyName from Classes left join Department On Classes.DeptID = Department.DeptID


-----------------------

 go 
 create procedure UspAddEditCourse
 @courseid int, @coursename varchar(50), @coursedescrip varchar(50),
 @coursehours int, @type varchar(50)
 As 
 if @type = 'INSERT'
 begin
      INSERT INTO Course(CourseName,CourseDescrip,CourseHours)
	  VALUES(@coursename,@coursedescrip,@coursehours)
 END
 if @type = 'UPDATE'
 begin
      UPDATE Course set
	         CourseName = @coursename,
			 CourseDescrip = @coursedescrip,
			 CourseHours = @coursehours
			 where  CourseID = @courseid

end
if @type = 'DELETE'
begin 
     DELETE FROM Course where CourseID = @courseid
end



go
 


 ------------------
drop procedure UspAddEditClass
go
create procedure UspAddEditClass
@classid int,
@deptid int,
@classname varchar(50),
@type varchar(50)
As 
if @type = 'INSERT'
begin
      INSERT INTO Classes(ClassName,DeptID)
	  VALUES(@classname,@deptid)
END
if @type = 'UPDATE'
begin
      UPDATE Classes set
			 ClassName = @classname,
			 DeptID = @deptid
			 where ClassID = @classid

end
if @type = 'DELETE'
begin 
     DELETE FROM Classes where ClassID = @classid
end



go

SELECT  from Classes left join Department On Classes.DeptID = Department.DeptID
select * from Department

SELECT 1 AS ClassID, 'Select Classes' AS ClassName UNION ALL SELECT ClassID, ClassName FROM Classes

SELECT 0 AS DeptID, 'Select Department' AS DetyName UNION ALL SELECT DeptID, DetyName FROM Department


_________________________________
create table Teacher
(
   TeacherID int primary key identity,
   TeacherName varchar (50) not null,
   Gender varchar (50) not null,
   Phone varchar (50) not null,
   TeacherSubj varchar (50) not null,
   Dob date,
   status varchar (50) default 'active'
)


go 
 create procedure UspAddEditTeacher
 @teacherid int,@teachername varchar(50),
 @phone varchar(50),@dob varchar(50),@gender varchar(50), @teachersubj varchar(50),@type varchar(50)
 As 
 if @type = 'INSERT'
 begin
      INSERT INTO Teacher(TeacherName,Gender,Dob,TeacherSubj,Phone)
	  VALUES(@teachername,@gender,@dob,@teachersubj,@phone)
 END
 if @type = 'UPDATE'
 begin
      UPDATE Teacher set
	         TeacherName = @teachername,
			 Gender = @gender,
			 Phone = @phone,
			 Dob = @dob
			 where TeacherID = @teacherid

end
if @type = 'DELETE'
begin 
     DELETE FROM Teacher where TeacherID = @teacherid
end

go





go
create procedure UspChargeStudentByMounth
@month Date,@amount decimal(18,2)
AS
BEGIN 
     INSERT INTO StudentCharges(StudentID,ChargeMonth,Amount)
	 SELECT s.StudentID,@month,@amount
	 FROM Student s where s.StudentID NOT IN

	 (SELECT StudentID FROM StudentCharges WHERE ChargeMonth = MONTH(@month) AND ChargeMonth = YEAR(@month))



END

select * from StudentCharges








go 
create procedure UspAddEditClass2 
@classid int, @classname varchar(50)
AS 
BEGIN
     INSERT INTO Classes(DeptID,ClassName)
	 SELECT d.DeptID,@classname
	 FROM Department d WHERE d.DeptID NOT IN

	 (SELECT D.DeptID from Classes where ClassName = char(@classname))

END

-------------------------------------------------

create table Score
(
  ScoreID int primary key identity,
  StudentID int foreign key references Student(StudentID),
  CourseID int foreign key references Course(CourseID),
  Score decimal(18,2) 

)

go 
create procedure UspAddEditScore
@scoreid int ,@studentid int ,@courseid int,@score varchar(50),@type varchar(50)
As 
if @type = 'INSERT'
begin
      INSERT INTO Score (StudentID,CourseID,Score)
	  VALUES(@studentid,@courseid,@score)
END
if @type = 'UPDATE'
begin
      UPDATE Score set
	         StudentID = @studentid,
			 CourseID = @courseid,
			 Score = @score
			 where ScoreID = @scoreid
end
if @type = 'DELETE'
begin 
     DELETE FROM Score where ScoreID = @scoreid
end

SELECT Score.ScoreID,Score.Score,Course.CourseID,Course.CourseName,Student.StudentID,Student.StudentName from Score inner join Course On Score.CourseID = Course.CourseID inner join Student On Score.StudentID = Student.StudentID
