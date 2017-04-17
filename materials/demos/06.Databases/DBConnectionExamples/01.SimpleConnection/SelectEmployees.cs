using System;
using System.Data;
using System.Data.SqlClient;

class SelectEmployees
{
    static void Main()
    {
        // Change the connection string
        // to match with your system.
        string selectConnection =
        @"Data Source=.\SQLEXPRESS;" +
        @"Database=SoftUni;" +
        @"Integrated Security=True;" +
        @"Connect Timeout=30;Trusted_Connection=Yes;";
        string selectCommandText = "SELECT * FROM Employees " +
            "WHERE Salary > 12000 " +
            "ORDER BY Salary Desc";

        SqlDataAdapter dataAdapter =
        new SqlDataAdapter(
        selectCommandText, selectConnection);
        DataTable table = new DataTable();
        dataAdapter.Fill(table);

        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine("{0} {1} - {2} - {3}",
                row["FirstName"],
                row["LastName"],
                row["JobTitle"],
                row["Salary"]);
        }
    }
}
