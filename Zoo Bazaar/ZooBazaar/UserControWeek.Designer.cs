﻿namespace DesktopApplication
{
    partial class UserControWeek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblDate = new Label();
            LCount = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(54, 190);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 0;
            label1.Text = "Morning";
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.WhiteSmoke;
            lblDate.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(3, 26);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(258, 64);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LCount
            // 
            LCount.AutoSize = true;
            LCount.Location = new Point(93, 609);
            LCount.Margin = new Padding(5, 0, 5, 0);
            LCount.Name = "LCount";
            LCount.Size = new Size(78, 32);
            LCount.TabIndex = 3;
            LCount.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 453);
            label2.Name = "label2";
            label2.Size = new Size(257, 32);
            label2.TabIndex = 4;
            label2.Text = "Total shifts for the day:";
            // 
            // UserControWeek
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label2);
            Controls.Add(LCount);
            Controls.Add(lblDate);
            Controls.Add(label1);
            Name = "UserControWeek";
            Size = new Size(265, 1066);
            Load += UserControWeek_Load;
            Click += UserControWeek_Click;
            MouseDoubleClick += UserControWeek_MouseDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDate;
        private Label LCount;
        private Label label2;
    }
}