namespace Desktop_Application
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            NavBar = new Panel();
            btnZoo = new Button();
            btnEmployees = new Button();
            btnSettings = new Button();
            btnAnimals = new Button();
            btnSchedule = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            lblPosition = new Label();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblZooRegion = new Label();
            ChildForm = new Panel();
            NavBar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.BackColor = Color.WhiteSmoke;
            NavBar.Controls.Add(btnZoo);
            NavBar.Controls.Add(btnEmployees);
            NavBar.Controls.Add(btnSettings);
            NavBar.Controls.Add(btnAnimals);
            NavBar.Controls.Add(btnSchedule);
            NavBar.Controls.Add(btnHome);
            NavBar.Controls.Add(panel2);
            NavBar.Dock = DockStyle.Left;
            NavBar.Location = new Point(0, 0);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(420, 1548);
            NavBar.TabIndex = 1;
            NavBar.Paint += NavBar_Paint;
            // 
            // btnZoo
            // 
            btnZoo.Dock = DockStyle.Top;
            btnZoo.FlatAppearance.BorderSize = 0;
            btnZoo.FlatStyle = FlatStyle.Flat;
            btnZoo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZoo.ForeColor = Color.LightSeaGreen;
            btnZoo.Location = new Point(0, 730);
            btnZoo.Name = "btnZoo";
            btnZoo.Size = new Size(420, 111);
            btnZoo.TabIndex = 3;
            btnZoo.Text = "Zoo";
            btnZoo.UseVisualStyleBackColor = true;
            btnZoo.Click += btnZoo_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.LightSeaGreen;
            btnEmployees.Location = new Point(0, 619);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(420, 111);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.LightSeaGreen;
            btnSettings.Location = new Point(0, 1437);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(420, 111);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAnimals
            // 
            btnAnimals.Dock = DockStyle.Top;
            btnAnimals.FlatAppearance.BorderSize = 0;
            btnAnimals.FlatStyle = FlatStyle.Flat;
            btnAnimals.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnimals.ForeColor = Color.LightSeaGreen;
            btnAnimals.Location = new Point(0, 508);
            btnAnimals.Name = "btnAnimals";
            btnAnimals.Size = new Size(420, 111);
            btnAnimals.TabIndex = 1;
            btnAnimals.Text = "Animals";
            btnAnimals.UseVisualStyleBackColor = true;
            btnAnimals.Click += btnAnimals_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Dock = DockStyle.Top;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.ForeColor = Color.LightSeaGreen;
            btnSchedule.Location = new Point(0, 397);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(420, 111);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.LightSeaGreen;
            btnHome.Location = new Point(0, 286);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(420, 111);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lblPosition);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 286);
            panel2.TabIndex = 0;
            // 
            // lblPosition
            // 
            lblPosition.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.Black;
            lblPosition.Location = new Point(12, 222);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(402, 37);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Position";
            lblPosition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.LightSeaGreen;
            lblUsername.Location = new Point(12, 167);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(402, 45);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "User Name";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblZooRegion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(420, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1981, 78);
            panel1.TabIndex = 2;
            // 
            // lblZooRegion
            // 
            lblZooRegion.AutoSize = true;
            lblZooRegion.Location = new Point(821, 16);
            lblZooRegion.Name = "lblZooRegion";
            lblZooRegion.Size = new Size(137, 32);
            lblZooRegion.TabIndex = 0;
            lblZooRegion.Text = "Zoo Region";
            // 
            // ChildForm
            // 
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.Location = new Point(420, 78);
            ChildForm.Name = "ChildForm";
            ChildForm.Size = new Size(1981, 1470);
            ChildForm.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2401, 1548);
            Controls.Add(ChildForm);
            Controls.Add(panel1);
            Controls.Add(NavBar);
            Name = "Dashboard";
            Text = "Dashboard";
            NavBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavBar;
        private Button btnEmployees;
        private Button btnSettings;
        private Button btnAnimals;
        private Button btnSchedule;
        private Button btnHome;
        private Panel panel2;
        private Label lblPosition;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblZooRegion;
        private Panel ChildForm;
        private Button btnZoo;
    }
}