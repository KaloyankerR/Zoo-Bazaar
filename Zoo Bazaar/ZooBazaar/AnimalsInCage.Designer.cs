namespace Desktop_Application
{
    partial class AnimalsInCage
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
            panel2 = new Panel();
            dgvAnimals = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Breed = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            TypeOfFood = new DataGridViewTextBoxColumn();
            Cage = new DataGridViewTextBoxColumn();
            Region = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblCageName = new Label();
            lblIDofCage = new Label();
            btnUpdateAnimal = new Button();
            btnBack = new Button();
            btnMedicalReports = new Button();
            btnAnimalSchedule = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvAnimals);
            panel2.Location = new Point(45, 310);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4, 0, 4, 15);
            panel2.Size = new Size(1910, 720);
            panel2.TabIndex = 22;
            // 
            // dgvAnimals
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightSeaGreen;
            dgvAnimals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAnimals.BackgroundColor = Color.WhiteSmoke;
            dgvAnimals.BorderStyle = BorderStyle.None;
            dgvAnimals.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAnimals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAnimals.ColumnHeadersHeight = 60;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { ID, dataGridViewTextBoxColumn2, Breed, Age, Gender, TypeOfFood, Cage, Region });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAnimals.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAnimals.Dock = DockStyle.Fill;
            dgvAnimals.EnableHeadersVisualStyles = false;
            dgvAnimals.GridColor = Color.WhiteSmoke;
            dgvAnimals.Location = new Point(4, 0);
            dgvAnimals.Name = "dgvAnimals";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAnimals.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAnimals.RowHeadersWidth = 82;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.LightSeaGreen;
            dgvAnimals.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAnimals.RowTemplate.Height = 41;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(1902, 705);
            dgvAnimals.TabIndex = 12;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 280F;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Breed
            // 
            Breed.FillWeight = 325F;
            Breed.HeaderText = "Breed";
            Breed.MinimumWidth = 10;
            Breed.Name = "Breed";
            Breed.Width = 350;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 10;
            Age.Name = "Age";
            Age.Width = 120;
            // 
            // Gender
            // 
            Gender.FillWeight = 130F;
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 10;
            Gender.Name = "Gender";
            Gender.Width = 150;
            // 
            // TypeOfFood
            // 
            TypeOfFood.FillWeight = 250F;
            TypeOfFood.HeaderText = "Type Of Food";
            TypeOfFood.MinimumWidth = 10;
            TypeOfFood.Name = "TypeOfFood";
            TypeOfFood.Width = 280;
            // 
            // Cage
            // 
            Cage.FillWeight = 300F;
            Cage.HeaderText = "Cage";
            Cage.MinimumWidth = 10;
            Cage.Name = "Cage";
            Cage.Width = 320;
            // 
            // Region
            // 
            Region.FillWeight = 280F;
            Region.HeaderText = "Region";
            Region.MinimumWidth = 10;
            Region.Name = "Region";
            Region.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(739, 20);
            label1.Name = "label1";
            label1.Size = new Size(535, 59);
            label1.TabIndex = 23;
            label1.Text = "Animals assgined to cage";
            // 
            // lblCageName
            // 
            lblCageName.AutoSize = true;
            lblCageName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCageName.Location = new Point(891, 113);
            lblCageName.Name = "lblCageName";
            lblCageName.Size = new Size(191, 45);
            lblCageName.TabIndex = 24;
            lblCageName.Text = "Cage Name";
            lblCageName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIDofCage
            // 
            lblIDofCage.AutoSize = true;
            lblIDofCage.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDofCage.ForeColor = Color.LightSeaGreen;
            lblIDofCage.Location = new Point(886, 185);
            lblIDofCage.Name = "lblIDofCage";
            lblIDofCage.Size = new Size(196, 45);
            lblIDofCage.TabIndex = 25;
            lblIDofCage.Text = "ID OF CAGE";
            lblIDofCage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.BackColor = Color.WhiteSmoke;
            btnUpdateAnimal.FlatStyle = FlatStyle.Flat;
            btnUpdateAnimal.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAnimal.ForeColor = Color.LightSeaGreen;
            btnUpdateAnimal.Location = new Point(891, 1064);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(309, 92);
            btnUpdateAnimal.TabIndex = 56;
            btnUpdateAnimal.Text = "Check Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = false;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(45, 1064);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(309, 92);
            btnBack.TabIndex = 60;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnMedicalReports
            // 
            btnMedicalReports.BackColor = Color.WhiteSmoke;
            btnMedicalReports.FlatStyle = FlatStyle.Flat;
            btnMedicalReports.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedicalReports.ForeColor = Color.LightSeaGreen;
            btnMedicalReports.Location = new Point(1646, 1064);
            btnMedicalReports.Name = "btnMedicalReports";
            btnMedicalReports.Size = new Size(309, 92);
            btnMedicalReports.TabIndex = 61;
            btnMedicalReports.Text = "Medical Reports";
            btnMedicalReports.UseVisualStyleBackColor = false;
            // 
            // btnAnimalSchedule
            // 
            btnAnimalSchedule.BackColor = Color.WhiteSmoke;
            btnAnimalSchedule.FlatStyle = FlatStyle.Flat;
            btnAnimalSchedule.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnimalSchedule.ForeColor = Color.LightSeaGreen;
            btnAnimalSchedule.Location = new Point(1269, 1064);
            btnAnimalSchedule.Name = "btnAnimalSchedule";
            btnAnimalSchedule.Size = new Size(309, 92);
            btnAnimalSchedule.TabIndex = 62;
            btnAnimalSchedule.Text = "Animal Schedule";
            btnAnimalSchedule.UseVisualStyleBackColor = false;
            // 
            // AnimalsInCage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2006, 1196);
            Controls.Add(btnAnimalSchedule);
            Controls.Add(btnMedicalReports);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateAnimal);
            Controls.Add(lblIDofCage);
            Controls.Add(lblCageName);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "AnimalsInCage";
            Text = "AnimalsInCage";
            Load += AnimalsInCage_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvAnimals;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Breed;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn TypeOfFood;
        private DataGridViewTextBoxColumn Cage;
        private DataGridViewTextBoxColumn Region;
        private Label label1;
        private Label lblCageName;
        private Label lblIDofCage;
        private Button btnUpdateAnimal;
        private Button btnBack;
        private Button btnMedicalReports;
        private Button btnAnimalSchedule;
    }
}