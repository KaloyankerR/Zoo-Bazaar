namespace Desktop_Application
{
    partial class SetEatingSchedule
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
            btnPrevious = new Button();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            lblInfo = new Label();
            cbxMinutes = new ComboBox();
            cbxHours = new ComboBox();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.WhiteSmoke;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.LightSeaGreen;
            btnPrevious.Location = new Point(27, 232);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(192, 64);
            btnPrevious.TabIndex = 40;
            btnPrevious.Text = "PREVIOUS";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.WhiteSmoke;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.LightSeaGreen;
            btnNext.Location = new Point(344, 232);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(192, 64);
            btnNext.TabIndex = 39;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 41;
            label1.Text = "Choose eating timeslot:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 32);
            label2.TabIndex = 44;
            label2.Text = ":";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(27, 12);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(56, 32);
            lblInfo.TabIndex = 45;
            lblInfo.Text = "info";
            // 
            // cbxMinutes
            // 
            cbxMinutes.FormattingEnabled = true;
            cbxMinutes.Location = new Point(300, 122);
            cbxMinutes.Margin = new Padding(4, 4, 4, 4);
            cbxMinutes.Name = "cbxMinutes";
            cbxMinutes.Size = new Size(235, 40);
            cbxMinutes.TabIndex = 43;
            // 
            // cbxHours
            // 
            cbxHours.FormattingEnabled = true;
            cbxHours.Location = new Point(27, 122);
            cbxHours.Margin = new Padding(4, 4, 4, 4);
            cbxHours.Name = "cbxHours";
            cbxHours.Size = new Size(235, 40);
            cbxHours.TabIndex = 42;
            // 
            // SetEatingSchedule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 321);
            Controls.Add(lblInfo);
            Controls.Add(label2);
            Controls.Add(cbxMinutes);
            Controls.Add(cbxHours);
            Controls.Add(label1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MaximumSize = new Size(576, 392);
            MinimizeBox = false;
            MinimumSize = new Size(576, 392);
            Name = "SetEatingSchedule";
            Text = "SetEatingSchedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrevious;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label lblInfo;
        private ComboBox cbxMinutes;
        private ComboBox cbxHours;
    }
}