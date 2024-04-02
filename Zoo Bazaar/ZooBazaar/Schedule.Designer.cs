namespace Desktop_Application
{
    partial class Schedule
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
            panel1 = new Panel();
            btnMonth = new Button();
            btnWeek = new Button();
            lblDate = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            dayContainer = new FlowLayoutPanel();
            btnCopyWeek = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMonth);
            panel1.Controls.Add(btnWeek);
            panel1.Controls.Add(lblDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 49);
            panel1.TabIndex = 36;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = Color.WhiteSmoke;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonth.ForeColor = Color.LightSeaGreen;
            btnMonth.Location = new Point(1064, 13);
            btnMonth.Margin = new Padding(2);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(123, 29);
            btnMonth.TabIndex = 6;
            btnMonth.Text = "Month";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click_1;
            // 
            // btnWeek
            // 
            btnWeek.BackColor = Color.WhiteSmoke;
            btnWeek.FlatStyle = FlatStyle.Flat;
            btnWeek.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeek.ForeColor = Color.LightSeaGreen;
            btnWeek.Location = new Point(20, 13);
            btnWeek.Margin = new Padding(2);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(123, 29);
            btnWeek.TabIndex = 14;
            btnWeek.Text = "Week";
            btnWeek.UseVisualStyleBackColor = false;
            btnWeek.Click += btnWeek_Click_1;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Nirmala UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.LightSeaGreen;
            lblDate.Location = new Point(295, 6);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(590, 37);
            lblDate.TabIndex = 13;
            lblDate.Text = "MONTH YEAR";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1054, 105);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 24);
            label7.TabIndex = 35;
            label7.Text = "Sunday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(894, 105);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 24);
            label6.TabIndex = 34;
            label6.Text = "Saturday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(742, 105);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 30;
            label5.Text = "Friday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(556, 105);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 33;
            label4.Text = "Thursday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(381, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 32;
            label3.Text = "Wednesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(228, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 31;
            label2.Text = "Tuesday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 105);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 29;
            label1.Text = "Monday";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.WhiteSmoke;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.LightSeaGreen;
            btnNext.Location = new Point(1054, 806);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 29);
            btnNext.TabIndex = 28;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.WhiteSmoke;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.LightSeaGreen;
            btnPrevious.Location = new Point(911, 806);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(123, 29);
            btnPrevious.TabIndex = 27;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(20, 128);
            dayContainer.Margin = new Padding(2);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1243, 668);
            dayContainer.TabIndex = 26;
            // 
            // btnCopyWeek
            // 
            btnCopyWeek.BackColor = Color.WhiteSmoke;
            btnCopyWeek.FlatStyle = FlatStyle.Flat;
            btnCopyWeek.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopyWeek.ForeColor = Color.LightSeaGreen;
            btnCopyWeek.Location = new Point(62, 806);
            btnCopyWeek.Margin = new Padding(2);
            btnCopyWeek.Name = "btnCopyWeek";
            btnCopyWeek.Size = new Size(123, 29);
            btnCopyWeek.TabIndex = 37;
            btnCopyWeek.Text = "Copy Week";
            btnCopyWeek.UseVisualStyleBackColor = false;
            btnCopyWeek.Click += btnCopyWeek_Click;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 866);
            Controls.Add(btnCopyWeek);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dayContainer);
            Margin = new Padding(2);
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMonth;
        private Button btnWeek;
        private Label lblDate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNext;
        private Button btnPrevious;
        private FlowLayoutPanel dayContainer;
        private Button btnCopyWeek;
    }
}