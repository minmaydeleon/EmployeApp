using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace EmployeApp
{
    public partial class Form1 : Form
    {
        private List<Class2> employees = new List<Class2>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Column1", "Employee ID");
            dataGridView1.Columns.Add("Column2", "First Name");
            dataGridView1.Columns.Add("Column3", "Last Name");
            dataGridView1.Columns.Add("Column4", "Position");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var employeeId = textBox1.Text;
            var firstName = textBox2.Text;
            var lastName = textBox3.Text;
            var position = textBox4.Text;
            if (!string.IsNullOrWhiteSpace(employeeId) &&
                !string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(lastName) &&
                !string.IsNullOrWhiteSpace(position))
            {
                var employee = new Class2(employeeId, firstName, lastName, position);
                employees.Add(employee);
                UpdateEmployeeList();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
        private void UpdateEmployeeList()
        {
            dataGridView1.Rows.Clear();
            foreach (var emp in employees)
            {
                dataGridView1.Rows.Add(emp.EmployeeID, emp.FirstName, emp.LastName, emp.Position);
            }
        }
    }
}
