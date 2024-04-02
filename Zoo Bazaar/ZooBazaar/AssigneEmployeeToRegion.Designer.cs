namespace Desktop_Application
{
    partial class AssigneEmployeeToRegion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvEmployees = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            ContractType = new DataGridViewTextBoxColumn();
            lblEmployeeID = new Label();
            lbCurrentRegions = new ListBox();
            label1 = new Label();
            btnDeleteEmployee = new Button();
            btnAddRegions = new Button();
            cbAllRegions = new ComboBox();
            groupBox1 = new GroupBox();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvEmployees);
            panel1.Location = new Point(29, 130);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 0, 4, 15);
            panel1.Size = new Size(1643, 205);
            panel1.TabIndex = 19;
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightSeaGreen;
            dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.BackgroundColor = Color.WhiteSmoke;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.ColumnHeadersHeight = 60;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { ID, fullName, Position, Email, Phone, ContractType });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.WhiteSmoke;
            dgvEmployees.Location = new Point(4, 0);
            dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.RowHeadersWidth = 82;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.LightSeaGreen;
            dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvEmployees.RowTemplate.Height = 41;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1635, 190);
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
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeID.ForeColor = Color.LightSeaGreen;
            lblEmployeeID.Location = new Point(33, 31);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(324, 55);
            lblEmployeeID.TabIndex = 20;
            lblEmployeeID.Text = "Employee ID:";
            // 
            // lbCurrentRegions
            // 
            lbCurrentRegions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCurrentRegions.FormattingEnabled = true;
            lbCurrentRegions.ItemHeight = 45;
            lbCurrentRegions.Location = new Point(33, 519);
            lbCurrentRegions.Name = "lbCurrentRegions";
            lbCurrentRegions.Size = new Size(618, 544);
            lbCurrentRegions.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 451);
            label1.Name = "label1";
            label1.Size = new Size(622, 37);
            label1.TabIndex = 22;
            label1.Text = "Current Regions Assigned To Employee";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.WhiteSmoke;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.ForeColor = Color.LightSeaGreen;
            btnDeleteEmployee.Location = new Point(33, 1150);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(618, 92);
            btnDeleteEmployee.TabIndex = 23;
            btnDeleteEmployee.Text = "Unassign Employee From Region";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnAddRegions
            // 
            btnAddRegions.BackColor = Color.WhiteSmoke;
            btnAddRegions.FlatStyle = FlatStyle.Flat;
            btnAddRegions.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRegions.ForeColor = Color.LightSeaGreen;
            btnAddRegions.Location = new Point(199, 318);
            btnAddRegions.Name = "btnAddRegions";
            btnAddRegions.Size = new Size(398, 92);
            btnAddRegions.TabIndex = 24;
            btnAddRegions.Text = "Add Region";
            btnAddRegions.UseVisualStyleBackColor = false;
            btnAddRegions.Click += btnAddRegions_Click;
            // 
            // cbAllRegions
            // 
            cbAllRegions.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            cbAllRegions.FormattingEnabled = true;
            cbAllRegions.Location = new Point(75, 139);
            cbAllRegions.Name = "cbAllRegions";
            cbAllRegions.Size = new Size(622, 67);
            cbAllRegions.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddRegions);
            groupBox1.Controls.Add(cbAllRegions);
            groupBox1.Location = new Point(1052, 451);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(792, 501);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assign Regions";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(1646, 1150);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(309, 92);
            btnBack.TabIndex = 27;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AssigneEmployeeToRegion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2027, 1297);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(label1);
            Controls.Add(lbCurrentRegions);
            Controls.Add(lblEmployeeID);
            Controls.Add(panel1);
            Name = "AssigneEmployeeToRegion";
            Text = "AssigneEmployeeToRegion";
            Load += AssigneEmployeeToRegion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn ContractType;
        private Label lblEmployeeID;
        private ListBox lbCurrentRegions;
        private Label label1;
        private Button btnDeleteEmployee;
        private Button btnAddRegions;
        private ComboBox cbAllRegions;
        private GroupBox groupBox1;
        private Button btnBack;
    }
}