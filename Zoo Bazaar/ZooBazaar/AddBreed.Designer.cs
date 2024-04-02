namespace Desktop_Application
{
    partial class AddBreed
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
            label2 = new Label();
            label3 = new Label();
            tbRegion = new TextBox();
            tbBreed = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(835, 59);
            label1.TabIndex = 0;
            label1.Text = "ADD BREEDS TYPICAL FOR THE REGION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 180);
            label2.Name = "label2";
            label2.Size = new Size(119, 45);
            label2.TabIndex = 1;
            label2.Text = "Region";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(409, 359);
            label3.Name = "label3";
            label3.Size = new Size(196, 45);
            label3.TabIndex = 2;
            label3.Text = "Breed Name";
            // 
            // tbRegion
            // 
            tbRegion.BackColor = Color.White;
            tbRegion.Location = new Point(212, 241);
            tbRegion.Name = "tbRegion";
            tbRegion.ReadOnly = true;
            tbRegion.Size = new Size(569, 39);
            tbRegion.TabIndex = 3;
            // 
            // tbBreed
            // 
            tbBreed.CharacterCasing = CharacterCasing.Upper;
            tbBreed.Location = new Point(212, 424);
            tbBreed.Name = "tbBreed";
            tbBreed.Size = new Size(569, 39);
            tbBreed.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.LightSeaGreen;
            btnAdd.Location = new Point(351, 534);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(309, 92);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "ADD BREED";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddBreed
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(991, 674);
            Controls.Add(btnAdd);
            Controls.Add(tbBreed);
            Controls.Add(tbRegion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBreed";
            Text = "Add Breed";
            Load += AddBreed_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbRegion;
        private TextBox tbBreed;
        private Button btnAdd;
    }
}