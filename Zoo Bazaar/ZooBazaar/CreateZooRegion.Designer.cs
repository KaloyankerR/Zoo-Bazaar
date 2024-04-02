namespace Desktop_Application
{
    partial class CreateZooRegion
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(326, 39);
            label1.Name = "label1";
            label1.Size = new Size(325, 45);
            label1.TabIndex = 0;
            label1.Text = "CREATE ZOO REGION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 165);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 1;
            label2.Text = "Region Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 281);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 2;
            label3.Text = "Cage Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 398);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 3;
            label4.Text = "Size (square meters)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(435, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(435, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(418, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(435, 391);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(418, 39);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(314, 511);
            button1.Name = "button1";
            button1.Size = new Size(347, 76);
            button1.TabIndex = 38;
            button1.Text = "CREATE REGION";
            button1.UseVisualStyleBackColor = false;
            // 
            // CreateZooRegion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 622);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateZooRegion";
            Text = "CreateZooRegion";
            Load += CreateZooRegion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}