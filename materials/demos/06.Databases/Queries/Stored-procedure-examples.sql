Create Procedure ListEmployees
As
	Begin
		SELECT * FROM Softuni.dbo.Employees
	End
GO

EXEC ListEmployees

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

EXEC GetEmployeesBySalary 60000