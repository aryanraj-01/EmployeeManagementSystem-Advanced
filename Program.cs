using System.Windows.Forms;
using EmployeeManagementSystem_Advanced.Services;
using EmployeeManagementSystem_Advanced.Data;

namespace EmployeeManagementSystem_Advanced;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var repo = new EmployeeRepository();
        var service = new EmployeeService(repo);

        Application.Run(new Form1(service));
    }
}