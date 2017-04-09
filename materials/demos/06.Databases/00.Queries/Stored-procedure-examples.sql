Create Procedure ListEmployees
As
	Begin
		SELECT * FROM Softuni.dbo.Employees
	End
GO

Create Procedure GetEmployeesBySalary
(
	@Salary money
)
AS
	BEGIN
		SELECT * FROM Softuni.dbo.Employees
		WHERE Salary >= @Salary
	END
GO