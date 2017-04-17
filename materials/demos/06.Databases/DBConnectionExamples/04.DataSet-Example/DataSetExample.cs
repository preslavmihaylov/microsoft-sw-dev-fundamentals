using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

class DataSetExample
{
    static void Main()
    {
        // Change the connection string
        // to match with your system.
        SqlConnection connection =
            new SqlConnection(
                @"Data Source=.\SQLEXPRESS;" +
                @"Database=SoftUni;" +
                @"Integrated Security=True;" +
                @"Connect Timeout=30;Trusted_Connection=Yes;");
        string name = "'; DROP TABLE; SELECT * FROM EMPLOYEES WHERE FirstName='";

        string selectCommandText = "SELECT * FROM Employees WHERE FirstName = '" + name + "';";
        connection.Open();

        SqlDataAdapter employeesAdapter =
        new SqlDataAdapter(
        selectCommandText, connection);

        selectCommandText = "SELECT * FROM Departments";
        SqlDataAdapter departmentsAdapter =
        new SqlDataAdapter(
        selectCommandText, connection);

        DataSet dbSet = new DataSet();

        employeesAdapter.Fill(dbSet, "Employees");
        departmentsAdapter.Fill(dbSet, "Departments");

        ReadEmployees(dbSet);
        ReadDepartments(dbSet);
    }

    static void ReadEmployees(DataSet dbSet)
    {
        using (StreamWriter sw = new StreamWriter("employees.txt"))
        {
            foreach (DataRow row  in dbSet.Tables["Employees"].Rows)
            {
                sw.WriteLine("{0} {1} - {2} - {3}",
                    row["FirstName"],
                    row["LastName"],
                    row["JobTitle"],
                    row["Salary"]);
            }
        }
    }

    static void ReadDepartments(DataSet dbSet)
    {
        using (StreamWriter sw = new StreamWriter("departments.txt"))
        {
            foreach (DataRow row in dbSet.Tables["Departments"].Rows)
            {
                sw.WriteLine("{0} - {1}",
                    row["DepartmentID"],
                    row["Name"]);
            }
        }
    }
}