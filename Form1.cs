using EmployeeManagementSystem_Advanced.Services;
using EmployeeManagementSystem_Advanced.Models;

namespace EmployeeManagementSystem_Advanced;

public partial class Form1 : Form
{
    EmployeeService service;
    List<Employee> employees = new();

    public Form1(EmployeeService service)
    {
        InitializeComponent();
        this.service = service;
        LoadEmployees();
    }

    void LoadEmployees()
    {
        employees = service.GetEmployees();
        gridEmployees.DataSource = null;
        gridEmployees.DataSource = employees;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtSalary.Text, out decimal salary))
        {
            MessageBox.Show("Invalid salary");
            return;
        }

        service.AddEmployee(txtName.Text, salary, cmbDepartment.Text);
        LoadEmployees();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (gridEmployees.CurrentRow == null) return;

        var emp = (Employee)gridEmployees.CurrentRow.DataBoundItem;
        service.DeleteEmployee(emp.Id);

        LoadEmployees();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (gridEmployees.CurrentRow == null) return;

        var emp = (Employee)gridEmployees.CurrentRow.DataBoundItem;

        emp.Name = txtName.Text;
        emp.Salary = Convert.ToDecimal(txtSalary.Text);
        emp.Department = cmbDepartment.Text;

        service.UpdateEmployee(emp);
        LoadEmployees();
    }

    private void gridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (gridEmployees.CurrentRow == null) return;

        var emp = (Employee)gridEmployees.CurrentRow.DataBoundItem;

        txtName.Text = emp.Name;
        txtSalary.Text = emp.Salary.ToString();
        cmbDepartment.Text = emp.Department;
    }
}