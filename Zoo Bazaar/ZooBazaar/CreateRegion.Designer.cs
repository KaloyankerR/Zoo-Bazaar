namespace Desktop_Application
{
    partial class CreateRegion
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
            tbRegionName = new TextBox();
            tbTypeOfAnimals = new TextBox();
            CageCapacity = new NumericUpDown();
            AnimalCapacity = new NumericUpDown();
            btnCreateRegion = new Button();
            btnBack = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)CageCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnimalCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 29);
            label1.Name = "label1";
            label1.Size = new Size(433, 50);
            label1.TabIndex = 0;
            label1.Text = "Create New Zoo Region";
            // 
            // tbRegionName
            // 
            tbRegionName.Location = new Point(77, 291);
            tbRegionName.Name = "tbRegionName";
            tbRegionName.Size = new Size(665, 39);
            tbRegionName.TabIndex = 1;
            // 
            // tbTypeOfAnimals
            // 
            tbTypeOfAnimals.Location = new Point(77, 545);
            tbTypeOfAnimals.Name = "tbTypeOfAnimals";
            tbTypeOfAnimals.Size = new Size(665, 39);
            tbTypeOfAnimals.TabIndex = 2;
            tbTypeOfAnimals.TextChanged += textBox2_TextChanged;
            // 
            // CageCapacity
            // 
            CageCapacity.Location = new Point(77, 851);
            CageCapacity.Name = "CageCapacity";
            CageCapacity.Size = new Size(267, 39);
            CageCapacity.TabIndex = 3;
            // 
            // AnimalCapacity
            // 
            AnimalCapacity.Location = new Point(475, 851);
            AnimalCapacity.Name = "AnimalCapacity";
            AnimalCapacity.Size = new Size(267, 39);
            AnimalCapacity.TabIndex = 4;
            // 
            // btnCreateRegion
            // 
            btnCreateRegion.BackColor = Color.WhiteSmoke;
            btnCreateRegion.FlatStyle = FlatStyle.Flat;
            btnCreateRegion.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateRegion.ForeColor = Color.LightSeaGreen;
            btnCreateRegion.Location = new Point(433, 1097);
            btnCreateRegion.Name = "btnCreateRegion";
            btnCreateRegion.Size = new Size(309, 92);
            btnCreateRegion.TabIndex = 24;
            btnCreateRegion.Text = "Create Region";
            btnCreateRegion.UseVisualStyleBackColor = false;
            btnCreateRegion.Click += btnCreateRegion_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(77, 1097);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(309, 92);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 240);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 26;
            label2.Text = "REGION NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 498);
            label3.Name = "label3";
            label3.Size = new Size(209, 32);
            label3.TabIndex = 27;
            label3.Text = "TYPE OF ANIMALS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 794);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 28;
            label4.Text = "CAGE CAPACITY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 794);
            label5.Name = "label5";
            label5.Size = new Size(211, 32);
            label5.TabIndex = 29;
            label5.Text = "ANIMAL CAPACITY";
            // 
            // CreateRegion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(825, 1240);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnCreateRegion);
            Controls.Add(AnimalCapacity);
            Controls.Add(CageCapacity);
            Controls.Add(tbTypeOfAnimals);
            Controls.Add(tbRegionName);
            Controls.Add(label1);
            Name = "CreateRegion";
            Text = "CreateRegion";
            Load += CreateRegion_Load;
            ((System.ComponentModel.ISupportInitialize)CageCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnimalCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbRegionName;
        private TextBox tbTypeOfAnimals;
        private NumericUpDown CageCapacity;
        private NumericUpDown AnimalCapacity;
        private Button btnCreateRegion;
        private Button btnBack;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}