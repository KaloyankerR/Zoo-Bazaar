namespace Desktop_Application
{
    partial class UpdateCage
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
            btnBack = new Button();
            btnUpdateCage = new Button();
            groupBox2 = new GroupBox();
            cageSize = new NumericUpDown();
            rbNO = new RadioButton();
            rbYES = new RadioButton();
            label7 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            tbAnimalsAssigned = new TextBox();
            label8 = new Label();
            cbTypeOfAnimal = new ComboBox();
            cageCapacity = new NumericUpDown();
            cbRegion = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            tbCageName = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btnCheckAnimals = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cageSize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cageCapacity).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(882, 652);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(309, 92);
            btnBack.TabIndex = 59;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdateCage
            // 
            btnUpdateCage.BackColor = Color.WhiteSmoke;
            btnUpdateCage.FlatStyle = FlatStyle.Flat;
            btnUpdateCage.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCage.ForeColor = Color.LightSeaGreen;
            btnUpdateCage.Location = new Point(1262, 652);
            btnUpdateCage.Name = "btnUpdateCage";
            btnUpdateCage.Size = new Size(309, 92);
            btnUpdateCage.TabIndex = 58;
            btnUpdateCage.Text = "Update Cage";
            btnUpdateCage.UseVisualStyleBackColor = false;
            btnUpdateCage.Click += btnUpdateCage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cageSize);
            groupBox2.Controls.Add(rbNO);
            groupBox2.Controls.Add(rbYES);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(863, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 246);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cage Details";
            // 
            // cageSize
            // 
            cageSize.Location = new Point(270, 63);
            cageSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cageSize.Name = "cageSize";
            cageSize.Size = new Size(396, 39);
            cageSize.TabIndex = 53;
            // 
            // rbNO
            // 
            rbNO.AutoSize = true;
            rbNO.Location = new Point(465, 143);
            rbNO.Name = "rbNO";
            rbNO.Size = new Size(77, 36);
            rbNO.TabIndex = 48;
            rbNO.TabStop = true;
            rbNO.Text = "No";
            rbNO.UseVisualStyleBackColor = true;
            // 
            // rbYES
            // 
            rbYES.AutoSize = true;
            rbYES.Location = new Point(317, 143);
            rbYES.Name = "rbYES";
            rbYES.Size = new Size(79, 36);
            rbYES.TabIndex = 47;
            rbYES.TabStop = true;
            rbYES.Text = "Yes";
            rbYES.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 147);
            label7.Name = "label7";
            label7.Size = new Size(171, 32);
            label7.TabIndex = 46;
            label7.Text = "Outdoor space";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 63);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 42;
            label4.Text = "Size (square meters)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbAnimalsAssigned);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbTypeOfAnimal);
            groupBox1.Controls.Add(cageCapacity);
            groupBox1.Controls.Add(cbRegion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbCageName);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(93, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 462);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cage";
            // 
            // tbAnimalsAssigned
            // 
            tbAnimalsAssigned.Location = new Point(364, 284);
            tbAnimalsAssigned.Name = "tbAnimalsAssigned";
            tbAnimalsAssigned.ReadOnly = true;
            tbAnimalsAssigned.Size = new Size(198, 39);
            tbAnimalsAssigned.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 249);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 54;
            label8.Text = "Animals assigned";
            // 
            // cbTypeOfAnimal
            // 
            cbTypeOfAnimal.FormattingEnabled = true;
            cbTypeOfAnimal.Location = new Point(244, 377);
            cbTypeOfAnimal.Name = "cbTypeOfAnimal";
            cbTypeOfAnimal.Size = new Size(386, 40);
            cbTypeOfAnimal.TabIndex = 53;
            // 
            // cageCapacity
            // 
            cageCapacity.Location = new Point(19, 284);
            cageCapacity.Name = "cageCapacity";
            cageCapacity.Size = new Size(176, 39);
            cageCapacity.TabIndex = 52;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new Point(212, 47);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(418, 40);
            cbRegion.TabIndex = 51;
            cbRegion.TextChanged += cbRegion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 47);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 40;
            label2.Text = "Region Assign";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 145);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 41;
            label3.Text = "Cage Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 380);
            label6.Name = "label6";
            label6.Size = new Size(193, 32);
            label6.TabIndex = 49;
            label6.Text = "Breed of animals";
            // 
            // tbCageName
            // 
            tbCageName.Location = new Point(212, 142);
            tbCageName.Name = "tbCageName";
            tbCageName.Size = new Size(418, 39);
            tbCageName.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 249);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 47;
            label5.Text = "Cage Capacity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(652, 52);
            label1.Name = "label1";
            label1.Size = new Size(303, 50);
            label1.TabIndex = 55;
            label1.Text = "ZOO CAGE INFO";
            // 
            // btnCheckAnimals
            // 
            btnCheckAnimals.BackColor = Color.WhiteSmoke;
            btnCheckAnimals.FlatStyle = FlatStyle.Flat;
            btnCheckAnimals.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckAnimals.ForeColor = Color.LightSeaGreen;
            btnCheckAnimals.Location = new Point(93, 652);
            btnCheckAnimals.Name = "btnCheckAnimals";
            btnCheckAnimals.Size = new Size(309, 92);
            btnCheckAnimals.TabIndex = 60;
            btnCheckAnimals.Text = "See animals assigned to this  cage";
            btnCheckAnimals.UseVisualStyleBackColor = false;
            btnCheckAnimals.Click += button1_Click;
            // 
            // UpdateCage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1676, 805);
            Controls.Add(btnCheckAnimals);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateCage);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UpdateCage";
            Text = "UpdateCage";
            FormClosed += UpdateCage_FormClosed;
            Load += UpdateCage_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cageSize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cageCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnUpdateCage;
        private GroupBox groupBox2;
        private NumericUpDown cageSize;
        private RadioButton rbNO;
        private RadioButton rbYES;
        private Label label7;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cbTypeOfAnimal;
        private NumericUpDown cageCapacity;
        private ComboBox cbRegion;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox tbCageName;
        private Label label5;
        private Label label1;
        private Label label8;
        private TextBox tbAnimalsAssigned;
        private Button btnCheckAnimals;
    }
}