namespace Desktop_Application
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            btnCreateEmployee = new Button();
            tbFilterByName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            dgvEmployees = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            ContractType = new DataGridViewTextBoxColumn();
            btnAssignEmployeeToRegion = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.BackColor = Color.WhiteSmoke;
            btnUpdateEmployee.FlatStyle = FlatStyle.Flat;
            btnUpdateEmployee.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmployee.ForeColor = Color.LightSeaGreen;
            btnUpdateEmployee.Location = new Point(829, 1099);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(309, 92);
            btnUpdateEmployee.TabIndex = 17;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.WhiteSmoke;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.ForeColor = Color.LightSeaGreen;
            btnDeleteEmployee.Location = new Point(439, 1099);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(309, 92);
            btnDeleteEmployee.TabIndex = 16;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.WhiteSmoke;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.ForeColor = Color.LightSeaGreen;
            btnCreateEmployee.Location = new Point(54, 1099);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(309, 92);
            btnCreateEmployee.TabIndex = 15;
            btnCreateEmployee.Text = "Create Employee";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // tbFilterByName
            // 
            tbFilterByName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilterByName.BackColor = Color.Gainsboro;
            tbFilterByName.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            tbFilterByName.ForeColor = Color.LightSeaGreen;
            tbFilterByName.Location = new Point(1056, 81);
            tbFilterByName.Name = "tbFilterByName";
            tbFilterByName.PlaceholderText = "Search by name";
            tbFilterByName.Size = new Size(856, 49);
            tbFilterByName.TabIndex = 14;
            tbFilterByName.TextChanged += tbFilterByName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(271, 55);
            label2.TabIndex = 13;
            label2.Text = "Employees";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvEmployees);
            panel1.Location = new Point(44, 235);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 0, 4, 15);
            panel1.Size = new Size(1643, 833);
            panel1.TabIndex = 18;
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.LightSeaGreen;
            dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvEmployees.BackgroundColor = Color.WhiteSmoke;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvEmployees.ColumnHeadersHeight = 60;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { ID, fullName, Position, Email, Phone, ContractType });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle8;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.WhiteSmoke;
            dgvEmployees.Location = new Point(4, 0);
            dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvEmployees.RowHeadersWidth = 82;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.LightSeaGreen;
            dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvEmployees.RowTemplate.Height = 41;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1635, 818);
            dgvEmployees.TabIndex = 12;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 200;
            // 
            // fullName
            // 
            fullName.FillWeight = 350F;
            fullName.HeaderText = "Full Name";
            fullName.MinimumWidth = 10;
            fullName.Name = "fullName";
            fullName.Width = 400;
            // 
            // Position
            // 
            Position.FillWeight = 280F;
            Position.HeaderText = "Position";
            Position.MinimumWidth = 10;
            Position.Name = "Position";
            Position.Width = 300;
            // 
            // Email
            // 
            Email.FillWeight = 320F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.Width = 350;
            // 
            // Phone
            // 
            Phone.FillWeight = 180F;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 10;
            Phone.Name = "Phone";
            Phone.Width = 200;
            // 
            // ContractType
            // 
            ContractType.FillWeight = 280F;
            ContractType.HeaderText = "Contract Type";
            ContractType.MinimumWidth = 10;
            ContractType.Name = "ContractType";
            ContractType.Width = 300;
            // 
            // btnAssignEmployeeToRegion
            // 
            btnAssignEmployeeToRegion.BackColor = Color.WhiteSmoke;
            btnAssignEmployeeToRegion.FlatStyle = FlatStyle.Flat;
            btnAssignEmployeeToRegion.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssignEmployeeToRegion.ForeColor = Color.LightSeaGreen;
            btnAssignEmployeeToRegion.Location = new Point(1511, 1278);
            btnAssignEmployeeToRegion.Name = "btnAssignEmployeeToRegion";
            btnAssignEmployeeToRegion.Size = new Size(415, 92);
            btnAssignEmployeeToRegion.TabIndex = 19;
            btnAssignEmployeeToRegion.Text = "Assign Employee To Region";
            btnAssignEmployeeToRegion.UseVisualStyleBackColor = false;
            btnAssignEmployeeToRegion.Click += btnAssignEmployeeToRegion_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1955, 1399);
            Controls.Add(btnAssignEmployeeToRegion);
            Controls.Add(panel1);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnCreateEmployee);
            Controls.Add(tbFilterByName);
            Controls.Add(label2);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateEmployee;
        private Button btnDeleteEmployee;
        private Button btnCreateEmployee;
        private TextBox tbFilterByName;
        private Label label2;
        private Panel panel1;
        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn ContractType;
        private Button btnAssignEmployeeToRegion;
    }
}