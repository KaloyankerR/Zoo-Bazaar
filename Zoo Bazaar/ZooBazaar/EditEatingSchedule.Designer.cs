namespace Desktop_Application
{
    partial class EditEatingSchedule
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
            lblInfo = new Label();
            label2 = new Label();
            cbxMinutes = new ComboBox();
            cbxHours = new ComboBox();
            label1 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(43, 25);
            lblInfo.TabIndex = 52;
            lblInfo.Text = "info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 98);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 51;
            label2.Text = ":";
            // 
            // cbxMinutes
            // 
            cbxMinutes.FormattingEnabled = true;
            cbxMinutes.Location = new Point(222, 95);
            cbxMinutes.Name = "cbxMinutes";
            cbxMinutes.Size = new Size(182, 33);
            cbxMinutes.TabIndex = 50;
            // 
            // cbxHours
            // 
            cbxHours.FormattingEnabled = true;
            cbxHours.Location = new Point(12, 95);
            cbxHours.Name = "cbxHours";
            cbxHours.Size = new Size(182, 33);
            cbxHours.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 48;
            label1.Text = "Choose eating timeslot:";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.WhiteSmoke;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.LightSeaGreen;
            btnPrevious.Location = new Point(12, 181);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(148, 50);
            btnPrevious.TabIndex = 47;
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
            btnNext.Location = new Point(256, 181);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(148, 50);
            btnNext.TabIndex = 46;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // EditEatingSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 266);
            Controls.Add(lblInfo);
            Controls.Add(label2);
            Controls.Add(cbxMinutes);
            Controls.Add(cbxHours);
            Controls.Add(label1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            MaximizeBox = false;
            MaximumSize = new Size(449, 322);
            MinimizeBox = false;
            MinimumSize = new Size(449, 322);
            Name = "EditEatingSchedule";
            Text = "EditEatingSchedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label label2;
        private ComboBox cbxMinutes;
        private ComboBox cbxHours;
        private Label label1;
        private Button btnPrevious;
        private Button btnNext;
    }
}