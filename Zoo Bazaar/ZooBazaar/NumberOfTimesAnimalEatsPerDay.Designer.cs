namespace Desktop_Application
{
    partial class NumberOfTimesAnimalEatsPerDay
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
            nudNrTimes = new NumericUpDown();
            label1 = new Label();
            btnNext = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNrTimes).BeginInit();
            SuspendLayout();
            // 
            // nudNrTimes
            // 
            nudNrTimes.Location = new Point(94, 76);
            nudNrTimes.Margin = new Padding(4, 4, 4, 4);
            nudNrTimes.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNrTimes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNrTimes.Name = "nudNrTimes";
            nudNrTimes.Size = new Size(234, 39);
            nudNrTimes.TabIndex = 44;
            nudNrTimes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 32);
            label1.TabIndex = 43;
            label1.Text = "Number of times animal eats per day:";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(273, 173);
            btnNext.Margin = new Padding(4, 4, 4, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(146, 44);
            btnNext.TabIndex = 45;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(16, 173);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 44);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // NumberOfTimesAnimalEatsPerDay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 247);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(nudNrTimes);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NumberOfTimesAnimalEatsPerDay";
            Text = "NumberOfTimesAnimalEatsPerDay";
            ((System.ComponentModel.ISupportInitialize)nudNrTimes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudNrTimes;
        private Label label1;
        private Button btnNext;
        private Button btnCancel;
    }
}