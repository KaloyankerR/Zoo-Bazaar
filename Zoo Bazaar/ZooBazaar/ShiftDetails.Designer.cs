namespace Desktop_Application
{
    partial class ShiftDetails
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
            FLPAvaibleEmp = new FlowLayoutPanel();
            FLPAssignedEmp = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // FLPAvaibleEmp
            // 
            FLPAvaibleEmp.AutoScroll = true;
            FLPAvaibleEmp.BorderStyle = BorderStyle.FixedSingle;
            FLPAvaibleEmp.Location = new Point(130, 320);
            FLPAvaibleEmp.Margin = new Padding(5);
            FLPAvaibleEmp.Name = "FLPAvaibleEmp";
            FLPAvaibleEmp.Size = new Size(405, 199);
            FLPAvaibleEmp.TabIndex = 1;
            FLPAvaibleEmp.Paint += FLPAvaibleEmp_Paint;
            // 
            // FLPAssignedEmp
            // 
            FLPAssignedEmp.AutoScroll = true;
            FLPAssignedEmp.BorderStyle = BorderStyle.FixedSingle;
            FLPAssignedEmp.Location = new Point(741, 320);
            FLPAssignedEmp.Margin = new Padding(5);
            FLPAssignedEmp.Name = "FLPAssignedEmp";
            FLPAssignedEmp.Size = new Size(405, 199);
            FLPAssignedEmp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(580, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 40);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 194);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 40);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(33, 26);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(214, 91);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ShiftDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FLPAssignedEmp);
            Controls.Add(FLPAvaibleEmp);
            Margin = new Padding(5);
            Name = "ShiftDetails";
            Text = "ShiftDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel FLPAvaibleEmp;
        private FlowLayoutPanel FLPAssignedEmp;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}