namespace Desktop_Application
{
    partial class Settings
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
            label1 = new Label();
            gbExtraDetails = new GroupBox();
            tbBoatLicenseNumber = new TextBox();
            linkPhoto = new LinkLabel();
            lblBoatLicenseNumber = new Label();
            lblPath = new Label();
            lblUploadPhoto = new Label();
            btnLogout = new Button();
            btnUpdate = new Button();
            groupBox4 = new GroupBox();
            tbMaxHours = new TextBox();
            tbMinHours = new TextBox();
            cbPosition = new ComboBox();
            cbContract = new ComboBox();
            label17 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            label18 = new Label();
            tbConfirmPassword = new TextBox();
            label19 = new Label();
            tbPassword = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tbBSN = new TextBox();
            tbIBAN = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbFirstName = new TextBox();
            label8 = new Label();
            tbLastName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            tbEmail = new TextBox();
            rbRatherNotSay = new RadioButton();
            tbPhone = new TextBox();
            rbFemale = new RadioButton();
            tbAddress = new TextBox();
            rbMale = new RadioButton();
            label7 = new Label();
            groupBox1 = new GroupBox();
            tbEmergancyPhone = new TextBox();
            tbEmergancyLastName = new TextBox();
            tbEmergancyFirstName = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            gbExtraDetails.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(766, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 71);
            label1.TabIndex = 2;
            label1.Text = "Your Account";
            // 
            // gbExtraDetails
            // 
            gbExtraDetails.Controls.Add(tbBoatLicenseNumber);
            gbExtraDetails.Controls.Add(linkPhoto);
            gbExtraDetails.Controls.Add(lblBoatLicenseNumber);
            gbExtraDetails.Controls.Add(lblPath);
            gbExtraDetails.Controls.Add(lblUploadPhoto);
            gbExtraDetails.Location = new Point(1008, 944);
            gbExtraDetails.Name = "gbExtraDetails";
            gbExtraDetails.Size = new Size(756, 282);
            gbExtraDetails.TabIndex = 47;
            gbExtraDetails.TabStop = false;
            gbExtraDetails.Text = "Extra Details";
            gbExtraDetails.Visible = false;
            // 
            // tbBoatLicenseNumber
            // 
            tbBoatLicenseNumber.Location = new Point(306, 55);
            tbBoatLicenseNumber.Name = "tbBoatLicenseNumber";
            tbBoatLicenseNumber.Size = new Size(413, 39);
            tbBoatLicenseNumber.TabIndex = 36;
            tbBoatLicenseNumber.Visible = false;
            // 
            // linkPhoto
            // 
            linkPhoto.ActiveLinkColor = Color.White;
            linkPhoto.AutoSize = true;
            linkPhoto.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            linkPhoto.LinkColor = Color.LightSeaGreen;
            linkPhoto.Location = new Point(457, 119);
            linkPhoto.Name = "linkPhoto";
            linkPhoto.Size = new Size(184, 37);
            linkPhoto.TabIndex = 30;
            linkPhoto.TabStop = true;
            linkPhoto.Text = "Upload photo";
            // 
            // lblBoatLicenseNumber
            // 
            lblBoatLicenseNumber.AutoSize = true;
            lblBoatLicenseNumber.Location = new Point(36, 55);
            lblBoatLicenseNumber.Name = "lblBoatLicenseNumber";
            lblBoatLicenseNumber.Size = new Size(242, 32);
            lblBoatLicenseNumber.TabIndex = 35;
            lblBoatLicenseNumber.Text = "Boat License Number";
            lblBoatLicenseNumber.Visible = false;
            // 
            // lblPath
            // 
            lblPath.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblPath.ForeColor = Color.DarkGray;
            lblPath.ImeMode = ImeMode.NoControl;
            lblPath.Location = new Point(9, 173);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(731, 103);
            lblPath.TabIndex = 33;
            lblPath.Text = "Previous Oders";
            lblPath.TextAlign = ContentAlignment.MiddleCenter;
            lblPath.Visible = false;
            // 
            // lblUploadPhoto
            // 
            lblUploadPhoto.AutoSize = true;
            lblUploadPhoto.Location = new Point(36, 123);
            lblUploadPhoto.Name = "lblUploadPhoto";
            lblUploadPhoto.Size = new Size(160, 32);
            lblUploadPhoto.TabIndex = 34;
            lblUploadPhoto.Text = "Upload Photo";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.WhiteSmoke;
            btnLogout.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.LightSeaGreen;
            btnLogout.Location = new Point(1004, 1255);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(349, 123);
            btnLogout.TabIndex = 53;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.LightSeaGreen;
            btnUpdate.Location = new Point(1431, 1255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(349, 123);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update Credentials";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbMaxHours);
            groupBox4.Controls.Add(tbMinHours);
            groupBox4.Controls.Add(cbPosition);
            groupBox4.Controls.Add(cbContract);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(1008, 548);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(756, 363);
            groupBox4.TabIndex = 51;
            groupBox4.TabStop = false;
            groupBox4.Text = "Employmet";
            // 
            // tbMaxHours
            // 
            tbMaxHours.Location = new Point(549, 279);
            tbMaxHours.Name = "tbMaxHours";
            tbMaxHours.Size = new Size(152, 39);
            tbMaxHours.TabIndex = 36;
            // 
            // tbMinHours
            // 
            tbMinHours.Location = new Point(193, 283);
            tbMinHours.Name = "tbMinHours";
            tbMinHours.Size = new Size(152, 39);
            tbMinHours.TabIndex = 35;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "ADMINISTRATOR", "HR", "VETERINARY", "CARE TAKER" });
            cbPosition.Location = new Point(246, 185);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(398, 40);
            cbPosition.TabIndex = 34;
            // 
            // cbContract
            // 
            cbContract.FormattingEnabled = true;
            cbContract.Items.AddRange(new object[] { "FULL TIME", "PART TIME" });
            cbContract.Location = new Point(246, 86);
            cbContract.Name = "cbContract";
            cbContract.Size = new Size(398, 40);
            cbContract.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(387, 286);
            label17.Name = "label17";
            label17.Size = new Size(135, 32);
            label17.TabIndex = 32;
            label17.Text = "MAX Hours";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 286);
            label13.Name = "label13";
            label13.Size = new Size(130, 32);
            label13.TabIndex = 31;
            label13.Text = "MIN Hours";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 188);
            label12.Name = "label12";
            label12.Size = new Size(98, 32);
            label12.TabIndex = 30;
            label12.Text = "Position";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 90);
            label11.Name = "label11";
            label11.Size = new Size(162, 32);
            label11.TabIndex = 29;
            label11.Text = "Contract Type";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(tbConfirmPassword);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(tbPassword);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(tbBSN);
            groupBox3.Controls.Add(tbIBAN);
            groupBox3.Location = new Point(168, 999);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(732, 379);
            groupBox3.TabIndex = 50;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Details";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(41, 329);
            label18.Name = "label18";
            label18.Size = new Size(204, 32);
            label18.TabIndex = 23;
            label18.Text = "Confirm Password";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(271, 322);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(375, 39);
            tbConfirmPassword.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(41, 263);
            label19.Name = "label19";
            label19.Size = new Size(111, 32);
            label19.TabIndex = 21;
            label19.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(271, 256);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(375, 39);
            tbPassword.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 74);
            label9.Name = "label9";
            label9.Size = new Size(59, 32);
            label9.TabIndex = 17;
            label9.Text = "BSN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 166);
            label10.Name = "label10";
            label10.Size = new Size(67, 32);
            label10.TabIndex = 18;
            label10.Text = "IBAN";
            // 
            // tbBSN
            // 
            tbBSN.Location = new Point(132, 67);
            tbBSN.Name = "tbBSN";
            tbBSN.Size = new Size(514, 39);
            tbBSN.TabIndex = 19;
            // 
            // tbIBAN
            // 
            tbIBAN.Location = new Point(132, 159);
            tbIBAN.Name = "tbIBAN";
            tbIBAN.Size = new Size(514, 39);
            tbIBAN.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbFirstName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbLastName);
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(rbRatherNotSay);
            groupBox2.Controls.Add(tbPhone);
            groupBox2.Controls.Add(rbFemale);
            groupBox2.Controls.Add(tbAddress);
            groupBox2.Controls.Add(rbMale);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(168, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(732, 793);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 107);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 199);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 296);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 388);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 483);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(237, 100);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(413, 39);
            tbFirstName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 709);
            label8.Name = "label8";
            label8.Size = new Size(154, 32);
            label8.TabIndex = 16;
            label8.Text = "Date Of Birth";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(237, 192);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(413, 39);
            tbLastName.TabIndex = 7;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(237, 702);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(413, 39);
            dtpDateOfBirth.TabIndex = 15;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(237, 293);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(413, 39);
            tbEmail.TabIndex = 8;
            // 
            // rbRatherNotSay
            // 
            rbRatherNotSay.AutoSize = true;
            rbRatherNotSay.Location = new Point(524, 604);
            rbRatherNotSay.Name = "rbRatherNotSay";
            rbRatherNotSay.Size = new Size(192, 36);
            rbRatherNotSay.TabIndex = 14;
            rbRatherNotSay.TabStop = true;
            rbRatherNotSay.Text = "rather not say";
            rbRatherNotSay.UseVisualStyleBackColor = true;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(237, 385);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(413, 39);
            tbPhone.TabIndex = 9;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(375, 602);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(118, 36);
            rbFemale.TabIndex = 13;
            rbFemale.TabStop = true;
            rbFemale.Text = "female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(237, 476);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(413, 39);
            tbAddress.TabIndex = 10;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(237, 602);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(97, 36);
            rbMale.TabIndex = 12;
            rbMale.TabStop = true;
            rbMale.Text = "male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 604);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 11;
            label7.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbEmergancyPhone);
            groupBox1.Controls.Add(tbEmergancyLastName);
            groupBox1.Controls.Add(tbEmergancyFirstName);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Location = new Point(1008, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 414);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Emergancy Contact";
            // 
            // tbEmergancyPhone
            // 
            tbEmergancyPhone.Location = new Point(231, 295);
            tbEmergancyPhone.Name = "tbEmergancyPhone";
            tbEmergancyPhone.Size = new Size(413, 39);
            tbEmergancyPhone.TabIndex = 32;
            // 
            // tbEmergancyLastName
            // 
            tbEmergancyLastName.Location = new Point(231, 194);
            tbEmergancyLastName.Name = "tbEmergancyLastName";
            tbEmergancyLastName.Size = new Size(413, 39);
            tbEmergancyLastName.TabIndex = 31;
            // 
            // tbEmergancyFirstName
            // 
            tbEmergancyFirstName.Location = new Point(231, 102);
            tbEmergancyFirstName.Name = "tbEmergancyFirstName";
            tbEmergancyFirstName.Size = new Size(413, 39);
            tbEmergancyFirstName.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 298);
            label14.Name = "label14";
            label14.Size = new Size(82, 32);
            label14.TabIndex = 29;
            label14.Text = "Phone";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(39, 201);
            label15.Name = "label15";
            label15.Size = new Size(126, 32);
            label15.TabIndex = 28;
            label15.Text = "Last Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(39, 109);
            label16.Name = "label16";
            label16.Size = new Size(129, 32);
            label16.TabIndex = 27;
            label16.Text = "First Name";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1955, 1399);
            Controls.Add(gbExtraDetails);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            gbExtraDetails.ResumeLayout(false);
            gbExtraDetails.PerformLayout();
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

        private Label label1;
        private GroupBox gbExtraDetails;
        private TextBox tbBoatLicenseNumber;
        private LinkLabel linkPhoto;
        private Label lblBoatLicenseNumber;
        private Label lblPath;
        private Label lblUploadPhoto;
        private Button btnLogout;
        private Button btnUpdate;
        private GroupBox groupBox4;
        private TextBox tbMaxHours;
        private TextBox tbMinHours;
        private ComboBox cbPosition;
        private ComboBox cbContract;
        private Label label17;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox groupBox3;
        private Label label18;
        private TextBox tbConfirmPassword;
        private Label label19;
        private TextBox tbPassword;
        private Label label9;
        private Label label10;
        private TextBox tbBSN;
        private TextBox tbIBAN;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbFirstName;
        private Label label8;
        private TextBox tbLastName;
        private DateTimePicker dtpDateOfBirth;
        private TextBox tbEmail;
        private RadioButton rbRatherNotSay;
        private TextBox tbPhone;
        private RadioButton rbFemale;
        private TextBox tbAddress;
        private RadioButton rbMale;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox tbEmergancyPhone;
        private TextBox tbEmergancyLastName;
        private TextBox tbEmergancyFirstName;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}