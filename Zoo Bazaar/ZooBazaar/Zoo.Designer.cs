namespace Desktop_Application
{
    partial class Zoo
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvRegions = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Cages = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dgvCages = new DataGridView();
            cageID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Region = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btnCreateRegion = new Button();
            btnDeleteRegion = new Button();
            btnCreateCage = new Button();
            btnUpdateCage = new Button();
            btnDeleteCage = new Button();
            cbFilterByRegion = new ComboBox();
            btnAddBreeds = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegions).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCages).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvRegions);
            panel1.Location = new Point(29, 179);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 0, 4, 15);
            panel1.Size = new Size(790, 833);
            panel1.TabIndex = 19;
            // 
            // dgvRegions
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightSeaGreen;
            dgvRegions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegions.BackgroundColor = Color.WhiteSmoke;
            dgvRegions.BorderStyle = BorderStyle.None;
            dgvRegions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegions.ColumnHeadersHeight = 60;
            dgvRegions.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Cages });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRegions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRegions.Dock = DockStyle.Fill;
            dgvRegions.EnableHeadersVisualStyles = false;
            dgvRegions.GridColor = Color.WhiteSmoke;
            dgvRegions.Location = new Point(4, 0);
            dgvRegions.Name = "dgvRegions";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRegions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRegions.RowHeadersWidth = 82;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.LightSeaGreen;
            dgvRegions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRegions.RowTemplate.Height = 41;
            dgvRegions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegions.Size = new Size(782, 818);
            dgvRegions.TabIndex = 12;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 200;
            // 
            // Name
            // 
            Name.FillWeight = 350F;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 10;
            Name.Name = "Name";
            Name.Width = 400;
            // 
            // Cages
            // 
            Cages.FillWeight = 280F;
            Cages.HeaderText = "Cages Count";
            Cages.MinimumWidth = 10;
            Cages.Name = "Cages";
            Cages.Width = 300;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvCages);
            panel2.Location = new Point(879, 179);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4, 0, 4, 15);
            panel2.Size = new Size(1065, 833);
            panel2.TabIndex = 20;
            // 
            // dgvCages
            // 
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.LightSeaGreen;
            dgvCages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCages.BackgroundColor = Color.WhiteSmoke;
            dgvCages.BorderStyle = BorderStyle.None;
            dgvCages.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCages.ColumnHeadersHeight = 60;
            dgvCages.Columns.AddRange(new DataGridViewColumn[] { cageID, dataGridViewTextBoxColumn2, Region, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCages.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCages.Dock = DockStyle.Fill;
            dgvCages.EnableHeadersVisualStyles = false;
            dgvCages.GridColor = Color.WhiteSmoke;
            dgvCages.Location = new Point(4, 0);
            dgvCages.Name = "dgvCages";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvCages.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvCages.RowHeadersWidth = 82;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.LightSeaGreen;
            dgvCages.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvCages.RowTemplate.Height = 41;
            dgvCages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCages.Size = new Size(1057, 818);
            dgvCages.TabIndex = 12;
            // 
            // cageID
            // 
            cageID.HeaderText = "ID";
            cageID.MinimumWidth = 10;
            cageID.Name = "cageID";
            cageID.Visible = false;
            cageID.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 350F;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 400;
            // 
            // Region
            // 
            Region.FillWeight = 325F;
            Region.HeaderText = "Region";
            Region.MinimumWidth = 10;
            Region.Name = "Region";
            Region.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 200F;
            dataGridViewTextBoxColumn3.HeaderText = "Cage Capacity";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 220;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 113);
            label1.Name = "label1";
            label1.Size = new Size(238, 50);
            label1.TabIndex = 21;
            label1.Text = "Zoo Regions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1024, 113);
            label2.Name = "label2";
            label2.Size = new Size(202, 50);
            label2.TabIndex = 22;
            label2.Text = "Zoo Cages";
            // 
            // btnCreateRegion
            // 
            btnCreateRegion.BackColor = Color.WhiteSmoke;
            btnCreateRegion.FlatStyle = FlatStyle.Flat;
            btnCreateRegion.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateRegion.ForeColor = Color.LightSeaGreen;
            btnCreateRegion.Location = new Point(97, 1037);
            btnCreateRegion.Name = "btnCreateRegion";
            btnCreateRegion.Size = new Size(309, 92);
            btnCreateRegion.TabIndex = 23;
            btnCreateRegion.Text = "Create Region";
            btnCreateRegion.UseVisualStyleBackColor = false;
            btnCreateRegion.Click += btnCreateRegion_Click;
            // 
            // btnDeleteRegion
            // 
            btnDeleteRegion.BackColor = Color.WhiteSmoke;
            btnDeleteRegion.FlatStyle = FlatStyle.Flat;
            btnDeleteRegion.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteRegion.ForeColor = Color.LightSeaGreen;
            btnDeleteRegion.Location = new Point(458, 1037);
            btnDeleteRegion.Name = "btnDeleteRegion";
            btnDeleteRegion.Size = new Size(309, 92);
            btnDeleteRegion.TabIndex = 24;
            btnDeleteRegion.Text = "Delete Region";
            btnDeleteRegion.UseVisualStyleBackColor = false;
            btnDeleteRegion.Click += btnDeleteRegion_Click;
            // 
            // btnCreateCage
            // 
            btnCreateCage.BackColor = Color.WhiteSmoke;
            btnCreateCage.FlatStyle = FlatStyle.Flat;
            btnCreateCage.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCage.ForeColor = Color.LightSeaGreen;
            btnCreateCage.Location = new Point(917, 1037);
            btnCreateCage.Name = "btnCreateCage";
            btnCreateCage.Size = new Size(309, 92);
            btnCreateCage.TabIndex = 25;
            btnCreateCage.Text = "Create Cage";
            btnCreateCage.UseVisualStyleBackColor = false;
            btnCreateCage.Click += btnCreateCage_Click;
            // 
            // btnUpdateCage
            // 
            btnUpdateCage.BackColor = Color.WhiteSmoke;
            btnUpdateCage.FlatStyle = FlatStyle.Flat;
            btnUpdateCage.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCage.ForeColor = Color.LightSeaGreen;
            btnUpdateCage.Location = new Point(1259, 1037);
            btnUpdateCage.Name = "btnUpdateCage";
            btnUpdateCage.Size = new Size(309, 92);
            btnUpdateCage.TabIndex = 26;
            btnUpdateCage.Text = "Update Cage";
            btnUpdateCage.UseVisualStyleBackColor = false;
            btnUpdateCage.Click += btnUpdateCage_Click;
            // 
            // btnDeleteCage
            // 
            btnDeleteCage.BackColor = Color.WhiteSmoke;
            btnDeleteCage.FlatStyle = FlatStyle.Flat;
            btnDeleteCage.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCage.ForeColor = Color.LightSeaGreen;
            btnDeleteCage.Location = new Point(1597, 1037);
            btnDeleteCage.Name = "btnDeleteCage";
            btnDeleteCage.Size = new Size(309, 92);
            btnDeleteCage.TabIndex = 27;
            btnDeleteCage.Text = "Delete Cage";
            btnDeleteCage.UseVisualStyleBackColor = false;
            btnDeleteCage.Click += btnDeleteCage_Click;
            // 
            // cbFilterByRegion
            // 
            cbFilterByRegion.FormattingEnabled = true;
            cbFilterByRegion.Location = new Point(1361, 123);
            cbFilterByRegion.Name = "cbFilterByRegion";
            cbFilterByRegion.Size = new Size(579, 40);
            cbFilterByRegion.TabIndex = 28;
            cbFilterByRegion.Text = "Filter By Region";
            cbFilterByRegion.SelectedIndexChanged += cbFilterByRegion_SelectedIndexChanged;
            cbFilterByRegion.TextChanged += cbFilterByRegion_TextChanged;
            // 
            // btnAddBreeds
            // 
            btnAddBreeds.BackColor = Color.WhiteSmoke;
            btnAddBreeds.FlatStyle = FlatStyle.Flat;
            btnAddBreeds.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBreeds.ForeColor = Color.LightSeaGreen;
            btnAddBreeds.Location = new Point(177, 1208);
            btnAddBreeds.Name = "btnAddBreeds";
            btnAddBreeds.Size = new Size(512, 92);
            btnAddBreeds.TabIndex = 29;
            btnAddBreeds.Text = "Add Breeds To Region";
            btnAddBreeds.UseVisualStyleBackColor = false;
            btnAddBreeds.Click += btnAddBreeds_Click;
            // 
            // Zoo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1955, 1399);
            Controls.Add(btnAddBreeds);
            Controls.Add(cbFilterByRegion);
            Controls.Add(btnDeleteCage);
            Controls.Add(btnUpdateCage);
            Controls.Add(btnCreateCage);
            Controls.Add(btnDeleteRegion);
            Controls.Add(btnCreateRegion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Text = "Zoo";
            Load += Zoo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegions).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvRegions;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Cages;
        private Panel panel2;
        private DataGridView dgvCages;
        private Label label1;
        private Label label2;
        private Button btnCreateRegion;
        private Button btnDeleteRegion;
        private Button btnCreateCage;
        private Button btnUpdateCage;
        private Button btnDeleteCage;
        private DataGridViewTextBoxColumn cageID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Region;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ComboBox cbFilterByRegion;
        private Button btnAddBreeds;
    }
}