namespace EmployeeManagementSystem_Advanced;

partial class Form1
{
    TextBox txtName;
    TextBox txtSalary;
    ComboBox cmbDepartment;
    Button btnAdd;
    Button btnUpdate;
    Button btnDelete;
    DataGridView gridEmployees;

    private void InitializeComponent()
    {
        txtName = new TextBox();
        txtSalary = new TextBox();
        cmbDepartment = new ComboBox();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        gridEmployees = new DataGridView();

        SuspendLayout();

        txtName.PlaceholderText = "Name";
        txtName.Top = 20;
        txtName.Left = 20;

        txtSalary.PlaceholderText = "Salary";
        txtSalary.Top = 60;
        txtSalary.Left = 20;

        cmbDepartment.Top = 100;
        cmbDepartment.Left = 20;
        cmbDepartment.Items.AddRange(new object[]{"IT","HR","Finance","Sales"});

        btnAdd.Text = "Add";
        btnAdd.Top = 140;
        btnAdd.Left = 20;
        btnAdd.Click += btnAdd_Click;

        btnUpdate.Text = "Update";
        btnUpdate.Top = 140;
        btnUpdate.Left = 100;
        btnUpdate.Click += btnUpdate_Click;

        btnDelete.Text = "Delete";
        btnDelete.Top = 140;
        btnDelete.Left = 200;
        btnDelete.Click += btnDelete_Click;

        gridEmployees.Top = 200;
        gridEmployees.Left = 20;
        gridEmployees.Width = 600;
        gridEmployees.Height = 250;
        gridEmployees.CellClick += gridEmployees_CellClick;

        Controls.Add(txtName);
        Controls.Add(txtSalary);
        Controls.Add(cmbDepartment);
        Controls.Add(btnAdd);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(gridEmployees);

        Text = "Employee Management System (Advanced)";
        Width = 700;
        Height = 520;

        ResumeLayout(false);
    }
}