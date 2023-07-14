create database EmployeePayroll

create table EmployeeDetails(
EmployeeID int primary key identity(1,1),
Name varchar(50) not null,
ProfileImage varchar(255),
Gender char(1) check (Gender in ('M', 'F')),
StartDate date,
Department varchar(50),
Salary decimal(10,2),
Notes text,
CreatedAt datetime,
UpdatedAt datetime
)




alter procedure EmployeeRegisteration
@emp_name varchar(50),
@emp_profile_img varchar(255),
@emp_gender char(1),
@emp_start_date date,
@department varchar(50),
@emp_salary decimal,
@notes text,
@createdAt datetime,
@updatedAt datetime
as
begin
	begin try
	begin transaction
		insert into EmployeeDetails(Name, ProfileImage ,Gender ,StartDate,Department, Salary, Notes, CreatedAt, UpdatedAt)
		values (@emp_name, @emp_profile_img, @emp_gender, @emp_start_date, @department,@emp_salary, @notes, @createdAt, @updatedAt)
		print 'Employee Details inserted successfully'

	commit transaction
	end try

	begin catch
		print 'Some Error occurred'
		rollback transaction
	end catch
end

alter procedure EmployeeLogin
@emp_id int,
@emp_name varchar(50)
as
begin
	
		select count(*) from EmployeeDetails where EmployeeID  = @emp_id and Name = @emp_name
		
end






select * from EmployeeDetails

create procedure GetAllEmployees
as
begin
	begin try
	begin transaction
		select * from EmployeeDetails
	commit transaction
	end try

	begin catch
		print 'Some Error occurred'
		rollback transaction
	end catch
end

alter procedure GetEmployeeById
@emp_id int
as
begin
	begin try
	begin transaction
		select * from EmployeeDetails
		where EmployeeID = @emp_id

	commit transaction
	end try

	begin catch
		print 'Some Error occurred'
		rollback transaction
	end catch
end


alter procedure EditEmployee
@emp_id int,
@emp_name varchar(50),
@emp_profile_img varchar(255),
@emp_gender char(1),
@emp_start_date date,
@department varchar(50),
@emp_salary decimal,
@notes text
as
begin
	begin try
	begin transaction
		update EmployeeDetails
		set Name = @emp_name, ProfileImage = @emp_profile_img, Gender = @emp_gender, StartDate = @emp_start_date, Department = @department,
		Salary = @emp_salary, Notes = @notes
		where EmployeeID = @emp_id
		print 'Employee Details updated successfully'

	commit transaction
	end try

	begin catch
		print 'Some Error occurred'
		rollback transaction
	end catch
end

alter procedure DeleteEmployee
@emp_id int
as
begin
	begin try
	begin transaction
		delete from EmployeeDetails
		where EmployeeID = @emp_id
		print 'Employee Details deleted successfully'

	commit transaction
	end try

	begin catch
		print 'Some Error occurred'
		rollback transaction
	end catch
end




