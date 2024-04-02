using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using DataAccessLayer;
using Desktop_Application;

namespace ZooBazaar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EMAIL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeDAL());

            string email = tbEmail.Text;
            string password = tbPassword.Text;

            Employee emp = employeeManager.Login(email, password);

            if (emp == null)
            {
                MessageBox.Show("Invalid email or password. Please try again!");
            }
            else if (emp.Position != Position.ADMINISTRATOR && emp.Position != Position.HR)
            {
                MessageBox.Show("Employee does not have access to the desktop application! Please try again!");

            }
            else
            {

                Dashboard dashboard = new Dashboard(emp);
                dashboard.Show();

                this.Hide();

            }

            tbEmail.Text = "";
            tbPassword.Text = "";
        }
    }
}