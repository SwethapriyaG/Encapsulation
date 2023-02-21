using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employeedetails = new Employee();
            employeedetails.EmployeeName = txtEmployeeName.Text;
            employeedetails.EmployeeAge = Convert.ToInt32(txtEmployeeAge.Text);
            employeedetails.EmployeePosition = txtEmployeePosition.Text;
            FrmEmployeeDetails frm = new FrmEmployeeDetails();
            frm.label2.Text = employeedetails.EmployeeName;
            frm.label3.Text = employeedetails.EmployeeAge.ToString();
            frm.label4.Text = employeedetails.EmployeePosition;
            frm.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
