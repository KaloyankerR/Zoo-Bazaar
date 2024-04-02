using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaar;
using BusinessLogicObjectLayer;
using BusinessLogicLayer;
using Org.BouncyCastle.Crypto.Modes;

namespace Desktop_Application
{
    public partial class Settings : Form
    {
        Employee emp;
        Dashboard dash;
        public Settings(Employee employee, Dashboard dashboard)
        {
            InitializeComponent();
            this.emp = employee;
            this.dash = dashboard;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            dash.Close();
            Login login = new Login();
            login.Show();
        }

        public void Refresh()
        {
            tbFirstName.Text = emp.FirstName;
            tbLastName.Text = emp.LastName;
            tbEmail.Text = emp.Email;
            tbPhone.Text = emp.Phone;
            tbEmergancyFirstName.Text = emp.EmergancyFirstName;
            tbEmergancyLastName.Text = emp.EmergancyLastName;
            tbEmergancyPhone.Text = emp.EmergancyPhone;
            tbIBAN.Text = emp.IBAN;
            tbBSN.Text = emp.BSN;
            tbPassword.Text = emp.Password;
            tbAddress.Text = emp.Address;
            tbMinHours.Text = emp.MinHours.ToString();
            tbMaxHours.Text = emp.MaxHours.ToString();
            cbPosition.Text = emp.Position.ToString();
            cbContract.Text = emp.ContractType.ToString();



            if (emp.Gender == "male")
            {
                rbMale.Checked = true;
            }
            else if (emp.Gender == "female")
            {
                rbFemale.Checked = true;
            }
            else if (emp.Gender == "rather not say")
            {
                rbRatherNotSay.Checked = true;
            }

            DateTime dateOfBirth = emp.DateOfBirth.ToDateTime(new TimeOnly(0));
            dtpDateOfBirth.Value = dateOfBirth;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
