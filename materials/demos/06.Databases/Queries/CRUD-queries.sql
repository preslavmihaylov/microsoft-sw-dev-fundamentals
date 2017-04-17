

SELECT
	e.FirstName + ' ' + e.LastName as Fullname, 
	e.Salary, 
	a.AddressText,
	d.Name as [Department Name]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Departments d
ON e.DepartmentID = d.DepartmentID

SELECT 
	e.FirstName + ' ' + e.LastName as [Employee Name], 
	m.FirstName + ' ' + m.LastName as [Manager Name]
FROM Employees e
FULL OUTER JOIN Employees m
ON e.ManagerId = m.EmployeeID
WHERE e.Salary > 20000

SELECT FirstName, JobTitle, AVG(Salary), COUNT(EmployeeID)
FROM Employees
GROUP BY JobTitle, FirstName

SELECT d.Name, AVG(e.Salary) as [Average Salary]
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name
HAVING AVG(e.Salary) > 20000
ORDER BY [Average Salary]

SELECT e1.FirstName, e1.LastName, e2.FirstName, e2.LastName
FROM Employees e1
JOIN Employees e2
ON e1.FirstName = e2.FirstName
WHERE e1.EmployeeID != e2.EmployeeID

INSERT INTO Departments
VALUES ('Murder department', 16)

SELECT * FROM 
Departments

DELETE FROM Departments
WHERE DepartmentId = 17

UPDATE Departments
SET Name='Marketing'
WHERE DepartmentId = 4