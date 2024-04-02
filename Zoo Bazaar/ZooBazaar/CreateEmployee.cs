using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
        }

        public int GenerateID()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            if (AreAllFieldsFilled())
            {
                DateOnly dateOfBirth = DateOnly.Parse(dtpDateOfBirth.Text);
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

                int age = currentDate.Year - dateOfBirth.Year;


                bool isOlderThan10Years = age >= 18;

                if (isOlderThan10Years)
                {
                    if (tbPassword.Text != tbConfirmPassword.Text)
                    {
                        MessageBox.Show("Password doesn't match. Please try agai!");
                        Restart();

                    }
                    else
                    {
                        string gender = "";
                        if (rbMale.Checked)
                        {
                            gender = "male";
                        }
                        else if (rbFemale.Checked)
                        {
                            gender = "female";
                        }
                        else if (rbRatherNotSay.Checked)
                        {
                            gender = "rather not say";
                        }


                        ContractType contract = ContractType.FULL_TIME;

                        string message = "";

                        switch (cbContract.SelectedItem as string)
                        {
                            case "FULL TIME":
                                contract = ContractType.FULL_TIME;
                                break;
                            case "PART TIME":
                                contract = ContractType.PART_TIME;
                                break;
                            default:
                                message = "Contract type is incorrect. Please try again!";
                                break;
                        }


                        Position position = Position.ADMINISTRATOR;

                        switch (cbPosition.SelectedItem as string)
                        {
                            case "ADMINISTRATOR":
                                position = Position.ADMINISTRATOR;
                                break;
                            case "HR":
                                position = Position.HR;
                                break;
                            case "VETERINARY":
                                position = Position.VETARINARY;
                                break;
                            case "CARE TAKER":
                                position = Position.CARETAKER;
                                break;
                            default:
                                message = "Position type is incorrect. Please try again!";


                                break;
                        }


                        int id = GenerateID();
                        string firstName = tbFirstName.Text;
                        string lastName = tbLastName.Text;
                        string email = tbEmail.Text;
                        string password = tbPassword.Text;
                        string phone = tbPhone.Text;
                        string address = tbAddress.Text;
                        string bsn = tbBSN.Text;
                        string iban = tbIBAN.Text;
                        string emergancyFirstName = tbEmergancyFirstName.Text;
                        string emergancyLastName = tbEmergancyLastName.Text;
                        string emergancyPhone = tbEmergancyPhone.Text;
                        int minHours = int.Parse(tbMinHours.Text);
                        int maxHours = int.Parse(tbMaxHours.Text);


                        string boatLicenseNumber = tbBoatLicenseNumber.Text;


                        if (message != "Contract type is incorrect. Please try again!" && message != "Position type is incorrect. Please try again!")
                        {

                            try
                            {
                                EmployeeManager empManager = new EmployeeManager(new EmployeeDAL());






                                if (position == Position.ADMINISTRATOR)
                                {
                                    Employee employee = new Employee(id, firstName, lastName, email, password, phone, address, gender, dateOfBirth, bsn, iban,
                                emergancyFirstName, emergancyLastName, emergancyPhone, contract, position, minHours, maxHours);

                                    empManager.CreateEmployee(employee);


                                }
                                else if (position == Position.HR)
                                {
                                    Employee employee = new Employee(id, firstName, lastName, email, password, phone, address, gender, dateOfBirth, bsn, iban,
                                   emergancyFirstName, emergancyLastName, emergancyPhone, contract, position, minHours, maxHours);

                                    empManager.CreateEmployee(employee);
                                }
                                else if (position == Position.VETARINARY)
                                {
                                    Employee employee = new Employee(id, firstName, lastName, email, password, phone, address, gender, dateOfBirth, bsn, iban,
                                emergancyFirstName, emergancyLastName, emergancyPhone, contract, position, minHours, maxHours);

                                    empManager.CreateEmployee(employee);
                                }
                                else if (position == Position.CARETAKER)
                                {
                                    Employee employee = new Employee(id, firstName, lastName, email, password, phone, address, gender, dateOfBirth, bsn, iban,
                                emergancyFirstName, emergancyLastName, emergancyPhone, contract, position, minHours, maxHours);

                                    empManager.CreateEmployee(employee);
                                }

                                MessageBox.Show("Employee created!");
                                Restart();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                                throw;
                            }
                        }
                        else
                        {
                            MessageBox.Show(message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Employees can not be younger than 18 years old!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields before proceeding.");
            }
        }


        public void Restart()
        {
            // Clear text in TextBox controls
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            dtpDateOfBirth.Text = "";
            tbBSN.Text = "";
            tbIBAN.Text = "";
            tbEmergancyFirstName.Text = "";
            tbEmergancyLastName.Text = "";
            tbEmergancyPhone.Text = "";
            tbMinHours.Text = "";
            tbMaxHours.Text = "";


            // Uncheck RadioButton controls
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbRatherNotSay.Checked = false;

            // Reset ComboBox selection
            cbContract.SelectedIndex = -1;
            cbPosition.SelectedIndex = -1;

            gbExtraDetails.Visible = false;
            lblBoatLicenseNumber.Visible = false;
            tbBoatLicenseNumber.Visible = false;

            tbBoatLicenseNumber.Text = "";


        }


        private bool AreAllFieldsFilled()
        {
            foreach (Control control in Controls) // Loop through all controls on the form
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false; // If any TextBox is empty, return false
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        return false; // If any ComboBox is not selected, return false
                    }
                }
                else if (control is RadioButton radioButton)
                {
                    if (radioButton.Checked)
                    {
                        return true; // If any RadioButton is checked, at least one is selected
                    }
                }
            }

            return true; // All fields have some input
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restart();
        }
    }
}
