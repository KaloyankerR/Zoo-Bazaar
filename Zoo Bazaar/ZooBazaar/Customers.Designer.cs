namespace Desktop_Application
{
    partial class Customers
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
            dgvCustomers = new DataGridView();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnCreateCustomer = new Button();
            tbFilterByName = new TextBox();
            label2 = new Label();
            btnBlockCustomer = new Button();
            ID = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvCustomers);
            panel1.Location = new Point(57, 219);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 0, 4, 15);
            panel1.Size = new Size(1393, 833);
            panel1.TabIndex = 24;
            // 
            // dgvCustomers
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightSeaGreen;
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.BackgroundColor = Color.WhiteSmoke;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeight = 60;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { ID, fullName, Email, Phone });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.GridColor = Color.WhiteSmoke;
            dgvCustomers.Location = new Point(4, 0);
            dgvCustomers.Name = "dgvCustomers";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.RowHeadersWidth = 82;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.LightSeaGreen;
            dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomers.RowTemplate.Height = 41;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1385, 818);
            dgvCustomers.TabIndex = 12;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.WhiteSmoke;
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCustomer.ForeColor = Color.LightSeaGreen;
            btnUpdateCustomer.Location = new Point(842, 1083);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(309, 92);
            btnUpdateCustomer.TabIndex = 23;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.WhiteSmoke;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCustomer.ForeColor = Color.LightSeaGreen;
            btnDeleteCustomer.Location = new Point(452, 1083);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(309, 92);
            btnDeleteCustomer.TabIndex = 22;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = Color.WhiteSmoke;
            btnCreateCustomer.FlatStyle = FlatStyle.Flat;
            btnCreateCustomer.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCustomer.ForeColor = Color.LightSeaGreen;
            btnCreateCustomer.Location = new Point(67, 1083);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(309, 92);
            btnCreateCustomer.TabIndex = 21;
            btnCreateCustomer.Text = "Create Customer";
            btnCreateCustomer.UseVisualStyleBackColor = false;
            // 
            // tbFilterByName
            // 
            tbFilterByName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilterByName.BackColor = Color.Gainsboro;
            tbFilterByName.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            tbFilterByName.ForeColor = Color.LightSeaGreen;
            tbFilterByName.Location = new Point(1069, 65);
            tbFilterByName.Name = "tbFilterByName";
            tbFilterByName.PlaceholderText = "Search by name";
            tbFilterByName.Size = new Size(856, 49);
            tbFilterByName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(45, 65);
            label2.Name = "label2";
            label2.Size = new Size(266, 55);
            label2.TabIndex = 19;
            label2.Text = "Customers";
            // 
            // btnBlockCustomer
            // 
            btnBlockCustomer.BackColor = Color.WhiteSmoke;
            btnBlockCustomer.FlatStyle = FlatStyle.Flat;
            btnBlockCustomer.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBlockCustomer.ForeColor = Color.LightSeaGreen;
            btnBlockCustomer.Location = new Point(67, 1279);
            btnBlockCustomer.Name = "btnBlockCustomer";
            btnBlockCustomer.Size = new Size(309, 92);
            btnBlockCustomer.TabIndex = 25;
            btnBlockCustomer.Text = "Block Customer";
            btnBlockCustomer.UseVisualStyleBackColor = false;
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
            fullName.FillWeight = 450F;
            fullName.HeaderText = "Full Name";
            fullName.MinimumWidth = 10;
            fullName.Name = "fullName";
            fullName.Width = 500;
            // 
            // Email
            // 
            Email.FillWeight = 350F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.Width = 400;
            // 
            // Phone
            // 
            Phone.FillWeight = 350F;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 10;
            Phone.Name = "Phone";
            Phone.Width = 400;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1955, 1399);
            Controls.Add(btnBlockCustomer);
            Controls.Add(panel1);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnCreateCustomer);
            Controls.Add(tbFilterByName);
            Controls.Add(label2);
            Name = "Customers";
            Text = "Customers";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private Button btnCreateCustomer;
        private TextBox tbFilterByName;
        private Label label2;
        private Button btnBlockCustomer;
    }
}