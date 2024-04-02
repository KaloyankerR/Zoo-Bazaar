namespace Desktop_Application
{
    partial class Animals
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
            Animal = new Label();
            btnAddAnimal = new Button();
            btnUpdateAnimal = new Button();
            btnDeleteAnimal = new Button();
            cbFilterByRegion = new ComboBox();
            tbFilterByBreed = new TextBox();
            btnEatingSchedule = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvAnimals);
            panel2.Location = new Point(32, 118);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4, 0, 4, 15);
            panel2.Size = new Size(1910, 1001);
            panel2.TabIndex = 21;
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
            dgvAnimals.Size = new Size(1902, 986);
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
            // Animal
            // 
            Animal.AutoSize = true;
            Animal.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            Animal.Location = new Point(859, 31);
            Animal.Name = "Animal";
            Animal.Size = new Size(220, 59);
            Animal.TabIndex = 13;
            Animal.Text = "ANIMALS";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.BackColor = Color.WhiteSmoke;
            btnAddAnimal.FlatStyle = FlatStyle.Flat;
            btnAddAnimal.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAnimal.ForeColor = Color.LightSeaGreen;
            btnAddAnimal.Location = new Point(36, 1149);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(309, 92);
            btnAddAnimal.TabIndex = 54;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = false;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.BackColor = Color.WhiteSmoke;
            btnUpdateAnimal.FlatStyle = FlatStyle.Flat;
            btnUpdateAnimal.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAnimal.ForeColor = Color.LightSeaGreen;
            btnUpdateAnimal.Location = new Point(413, 1149);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(309, 92);
            btnUpdateAnimal.TabIndex = 55;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = false;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnDeleteAnimal
            // 
            btnDeleteAnimal.BackColor = Color.WhiteSmoke;
            btnDeleteAnimal.FlatStyle = FlatStyle.Flat;
            btnDeleteAnimal.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAnimal.ForeColor = Color.LightSeaGreen;
            btnDeleteAnimal.Location = new Point(792, 1149);
            btnDeleteAnimal.Name = "btnDeleteAnimal";
            btnDeleteAnimal.Size = new Size(309, 92);
            btnDeleteAnimal.TabIndex = 56;
            btnDeleteAnimal.Text = "Delete Animal";
            btnDeleteAnimal.UseVisualStyleBackColor = false;
            btnDeleteAnimal.Click += btnDeleteAnimal_Click;
            // 
            // cbFilterByRegion
            // 
            cbFilterByRegion.FormattingEnabled = true;
            cbFilterByRegion.Location = new Point(1291, 49);
            cbFilterByRegion.Name = "cbFilterByRegion";
            cbFilterByRegion.Size = new Size(648, 40);
            cbFilterByRegion.TabIndex = 59;
            cbFilterByRegion.Text = "FILTER BY REGION";
            cbFilterByRegion.TextChanged += cbFilterByRegion_TextChanged;
            // 
            // tbFilterByBreed
            // 
            tbFilterByBreed.CharacterCasing = CharacterCasing.Upper;
            tbFilterByBreed.Location = new Point(32, 49);
            tbFilterByBreed.Name = "tbFilterByBreed";
            tbFilterByBreed.PlaceholderText = "FILTER BY BREED";
            tbFilterByBreed.Size = new Size(648, 39);
            tbFilterByBreed.TabIndex = 60;
            tbFilterByBreed.TextChanged += tbFilterByBreed_TextChanged;
            // 
            // btnEatingSchedule
            // 
            btnEatingSchedule.BackColor = Color.WhiteSmoke;
            btnEatingSchedule.FlatStyle = FlatStyle.Flat;
            btnEatingSchedule.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnEatingSchedule.ForeColor = Color.LightSeaGreen;
            btnEatingSchedule.Location = new Point(1165, 1149);
            btnEatingSchedule.Name = "btnEatingSchedule";
            btnEatingSchedule.Size = new Size(309, 92);
            btnEatingSchedule.TabIndex = 61;
            btnEatingSchedule.Text = "View Eating Schedule";
            btnEatingSchedule.UseVisualStyleBackColor = false;
            btnEatingSchedule.Click += btnEatingSchedule_Click;
            // 
            // Animals
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1955, 1399);
            Controls.Add(btnEatingSchedule);
            Controls.Add(tbFilterByBreed);
            Controls.Add(cbFilterByRegion);
            Controls.Add(btnDeleteAnimal);
            Controls.Add(btnUpdateAnimal);
            Controls.Add(btnAddAnimal);
            Controls.Add(Animal);
            Controls.Add(panel2);
            Name = "Animals";
            Text = "Animals";
            Load += Animals_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvAnimals;
        private Label Animal;
        private Button btnAddAnimal;
        private Button btnUpdateAnimal;
        private Button btnDeleteAnimal;
        private ComboBox cbFilterByRegion;
        private TextBox tbFilterByBreed;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Breed;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn TypeOfFood;
        private DataGridViewTextBoxColumn Cage;
        private DataGridViewTextBoxColumn Region;
        private Button btnEatingSchedule;
    }
}