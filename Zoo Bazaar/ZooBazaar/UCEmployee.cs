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
    public partial class UCEmployee : UserControl
    {
        BusinessLogicLayer.Employee employee;
        bool status;
        ShiftDetails shiftDetails;
        CreateShift createShift;
        public UCEmployee(BusinessLogicLayer.Employee employee, bool status, ShiftDetails shiftDetails)
        {
            InitializeComponent();
            this.employee = employee;
            this.status = status;
            this.shiftDetails = shiftDetails;
            this.LName.Text = employee.FirstName;
            this.createShift = null;
        }

        public UCEmployee(BusinessLogicLayer.Employee employee, bool status, CreateShift shiftCreate)
        {
            InitializeComponent();
            this.employee = employee;
            this.status = status;
            this.shiftDetails = null;
            this.LName.Text = employee.FirstName;
            this.createShift = shiftCreate;
        }

        public void ChangeStatus()
        {
            status = !status;
        }

        public BusinessLogicLayer.Employee GetEmployee()
        {
            return this.employee;
        }

        private void UCEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (shiftDetails != null)
            {
                if (status == true)
                {
                    this.shiftDetails.UnAssignEmployee(this);
                }
                else
                {
                    this.shiftDetails.AssignEmployee(this);
                }
                ChangeStatus();
            }
            else if(createShift != null)
            {
                if (status == true)
                {
                    this.createShift.UnAssignEmployee(this);
                }
                else
                {
                    this.createShift.AssignEmployee(this);
                }
                ChangeStatus();
            }
        }
    }
}
