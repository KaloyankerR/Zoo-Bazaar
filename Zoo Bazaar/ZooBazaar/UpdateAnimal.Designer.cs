namespace Desktop_Application
{
    partial class UpdateAnimal
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
            gbExtraDetails = new GroupBox();
            linkPhoto = new LinkLabel();
            pictureBox = new PictureBox();
            lblPath = new Label();
            btnBack = new Button();
            btnUpdate = new Button();
            groupBox4 = new GroupBox();
            cbTypeOfFood = new ComboBox();
            label11 = new Label();
            groupBox3 = new GroupBox();
            tbDescription = new TextBox();
            tbAdopter = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            tbBreed = new TextBox();
            tbRegion = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cbCage = new ComboBox();
            label14 = new Label();
            label16 = new Label();
            label1 = new Label();
            lblID = new Label();
            gbExtraDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbExtraDetails
            // 
            gbExtraDetails.Controls.Add(linkPhoto);
            gbExtraDetails.Controls.Add(pictureBox);
            gbExtraDetails.Controls.Add(lblPath);
            gbExtraDetails.Location = new Point(1039, 215);
            gbExtraDetails.Name = "gbExtraDetails";
            gbExtraDetails.Size = new Size(494, 680);
            gbExtraDetails.TabIndex = 47;
            gbExtraDetails.TabStop = false;
            gbExtraDetails.Text = "Image";
            // 
            // linkPhoto
            // 
            linkPhoto.ActiveLinkColor = Color.White;
            linkPhoto.AutoSize = true;
            linkPhoto.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            linkPhoto.LinkColor = Color.LightSeaGreen;
            linkPhoto.Location = new Point(159, 467);
            linkPhoto.Name = "linkPhoto";
            linkPhoto.Size = new Size(184, 37);
            linkPhoto.TabIndex = 30;
            linkPhoto.TabStop = true;
            linkPhoto.Text = "Upload photo";
            linkPhoto.LinkClicked += linkPhoto_LinkClicked;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(44, 64);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(409, 350);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 36;
            pictureBox.TabStop = false;
            // 
            // lblPath
            // 
            lblPath.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblPath.ForeColor = Color.DarkGray;
            lblPath.ImeMode = ImeMode.NoControl;
            lblPath.Location = new Point(14, 524);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(474, 123);
            lblPath.TabIndex = 33;
            lblPath.Text = "Previous Oders";
            lblPath.TextAlign = ContentAlignment.MiddleCenter;
            lblPath.Visible = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(940, 1381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(309, 92);
            btnBack.TabIndex = 46;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.LightSeaGreen;
            btnUpdate.Location = new Point(1338, 1381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(309, 92);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "UPDATE ANIMAL";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbTypeOfFood);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(940, 1171);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(707, 163);
            groupBox4.TabIndex = 44;
            groupBox4.TabStop = false;
            groupBox4.Text = "Food";
            // 
            // cbTypeOfFood
            // 
            cbTypeOfFood.FormattingEnabled = true;
            cbTypeOfFood.Items.AddRange(new object[] { "Meat", "Grass", "Seeds", "SeaLifeFood", "Granulas" });
            cbTypeOfFood.Location = new Point(246, 86);
            cbTypeOfFood.Name = "cbTypeOfFood";
            cbTypeOfFood.Size = new Size(398, 40);
            cbTypeOfFood.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 90);
            label11.Name = "label11";
            label11.Size = new Size(151, 32);
            label11.TabIndex = 29;
            label11.Text = "Type of food";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbDescription);
            groupBox3.Controls.Add(tbAdopter);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(41, 940);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(732, 550);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Details";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(45, 256);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(601, 245);
            tbDescription.TabIndex = 20;
            // 
            // tbAdopter
            // 
            tbAdopter.Location = new Point(237, 71);
            tbAdopter.Name = "tbAdopter";
            tbAdopter.Size = new Size(409, 39);
            tbAdopter.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 74);
            label9.Name = "label9";
            label9.Size = new Size(100, 32);
            label9.TabIndex = 17;
            label9.Text = "Adopter";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 195);
            label10.Name = "label10";
            label10.Size = new Size(213, 32);
            label10.TabIndex = 18;
            label10.Text = "Animal description";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbBreed);
            groupBox2.Controls.Add(tbRegion);
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(rbFemale);
            groupBox2.Controls.Add(rbMale);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(41, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(732, 636);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // tbBreed
            // 
            tbBreed.Location = new Point(237, 296);
            tbBreed.Name = "tbBreed";
            tbBreed.ReadOnly = true;
            tbBreed.Size = new Size(413, 39);
            tbBreed.TabIndex = 43;
            // 
            // tbRegion
            // 
            tbRegion.Location = new Point(237, 207);
            tbRegion.Name = "tbRegion";
            tbRegion.ReadOnly = true;
            tbRegion.Size = new Size(413, 39);
            tbRegion.TabIndex = 42;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(237, 509);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(413, 39);
            dtpDateOfBirth.TabIndex = 41;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(494, 404);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(122, 36);
            rbFemale.TabIndex = 40;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(312, 402);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(98, 36);
            rbMale.TabIndex = 39;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 107);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 296);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 3;
            label4.Text = "Breed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 207);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 4;
            label5.Text = "Region";
            // 
            // tbName
            // 
            tbName.Location = new Point(237, 100);
            tbName.Name = "tbName";
            tbName.Size = new Size(413, 39);
            tbName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 509);
            label8.Name = "label8";
            label8.Size = new Size(154, 32);
            label8.TabIndex = 16;
            label8.Text = "Date Of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 404);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 11;
            label7.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCage);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label16);
            groupBox1.Location = new Point(940, 940);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 200);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zoo";
            // 
            // cbCage
            // 
            cbCage.FormattingEnabled = true;
            cbCage.Location = new Point(150, 113);
            cbCage.Name = "cbCage";
            cbCage.Size = new Size(494, 40);
            cbCage.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 116);
            label14.Name = "label14";
            label14.Size = new Size(68, 32);
            label14.TabIndex = 29;
            label14.Text = "Cage";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(39, 48);
            label16.Name = "label16";
            label16.Size = new Size(0, 32);
            label16.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(595, 14);
            label1.Name = "label1";
            label1.Size = new Size(427, 71);
            label1.TabIndex = 40;
            label1.Text = "UPDATE ANIMAL";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.ForeColor = Color.LightSeaGreen;
            lblID.Location = new Point(41, 151);
            lblID.Name = "lblID";
            lblID.Size = new Size(76, 50);
            lblID.TabIndex = 48;
            lblID.Text = "ID: ";
            // 
            // UpdateAnimal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1676, 1567);
            Controls.Add(lblID);
            Controls.Add(gbExtraDetails);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UpdateAnimal";
            Text = "UpdateAnimal";
            FormClosed += UpdateAnimal_FormClosed;
            Load += UpdateAnimal_Load;
            gbExtraDetails.ResumeLayout(false);
            gbExtraDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbExtraDetails;
        private LinkLabel linkPhoto;
        private PictureBox pictureBox;
        private Label lblPath;
        private Button btnBack;
        private Button btnUpdate;
        private GroupBox groupBox4;
        private ComboBox cbTypeOfFood;
        private Label label11;
        private GroupBox groupBox3;
        private TextBox tbDescription;
        private TextBox tbAdopter;
        private Label label9;
        private Label label10;
        private GroupBox groupBox2;
        private DateTimePicker dtpDateOfBirth;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private ComboBox cbCage;
        private Label label14;
        private Label label16;
        private Label label1;
        private Label lblID;
        private TextBox tbBreed;
        private TextBox tbRegion;
    }
}