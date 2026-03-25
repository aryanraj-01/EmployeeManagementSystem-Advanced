using Microsoft.Data.Sqlite;
using EmployeeManagementSystem_Advanced.Models;

namespace EmployeeManagementSystem_Advanced.Data;

public class EmployeeRepository
{
    string connection = "Data Source=employees.db";

    public EmployeeRepository()
    {
        using var con = new SqliteConnection(connection);
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText =
        @"
        CREATE TABLE IF NOT EXISTS Employees(
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Name TEXT,
            Salary REAL,
            Department TEXT
        )
        ";
        cmd.ExecuteNonQuery();
    }

    public List<Employee> GetAll()
    {
        var list = new List<Employee>();

        using var con = new SqliteConnection(connection);
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT * FROM Employees";

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Employee
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Salary = reader.GetDecimal(2),
                Department = reader.GetString(3)
            });
        }

        return list;
    }

    public void Add(Employee emp)
    {
        using var con = new SqliteConnection(connection);
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText =
        @"INSERT INTO Employees (Name,Salary,Department)
          VALUES ($name,$salary,$dept)";

        cmd.Parameters.AddWithValue("$name", emp.Name);
        cmd.Parameters.AddWithValue("$salary", emp.Salary);
        cmd.Parameters.AddWithValue("$dept", emp.Department);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var con = new SqliteConnection(connection);
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText = "DELETE FROM Employees WHERE Id=$id";
        cmd.Parameters.AddWithValue("$id", id);

        cmd.ExecuteNonQuery();
    }

    public void Update(Employee emp)
    {
        using var con = new SqliteConnection(connection);
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText =
        @"UPDATE Employees
          SET Name=$name, Salary=$salary, Department=$dept
          WHERE Id=$id";

        cmd.Parameters.AddWithValue("$id", emp.Id);
        cmd.Parameters.AddWithValue("$name", emp.Name);
        cmd.Parameters.AddWithValue("$salary", emp.Salary);
        cmd.Parameters.AddWithValue("$dept", emp.Department);

        cmd.ExecuteNonQuery();
    }
}