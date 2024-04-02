namespace Desktop_Application
{
    partial class CreateShift
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
            FLPAssignedEmp = new FlowLayoutPanel();
            FLPAvaibleEmp = new FlowLayoutPanel();
            CBType = new ComboBox();
            NUDCapacity = new NumericUpDown();
            groupBox1 = new GroupBox();
            DTPStart = new DateTimePicker();
            groupBox2 = new GroupBox();
            DTPEnd = new DateTimePicker();
            LPosition = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCreate = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDCapacity).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // FLPAssignedEmp
            // 
            FLPAssignedEmp.AutoScroll = true;
            FLPAssignedEmp.BorderStyle = BorderStyle.FixedSingle;
            FLPAssignedEmp.Location = new Point(771, 372);
            FLPAssignedEmp.Margin = new Padding(5);
            FLPAssignedEmp.Name = "FLPAssignedEmp";
            FLPAssignedEmp.Size = new Size(405, 199);
            FLPAssignedEmp.TabIndex = 4;
            // 
            // FLPAvaibleEmp
            // 
            FLPAvaibleEmp.AutoScroll = true;
            FLPAvaibleEmp.BorderStyle = BorderStyle.FixedSingle;
            FLPAvaibleEmp.Location = new Point(168, 372);
            FLPAvaibleEmp.Margin = new Padding(5);
            FLPAvaibleEmp.Name = "FLPAvaibleEmp";
            FLPAvaibleEmp.Size = new Size(405, 199);
            FLPAvaibleEmp.TabIndex = 3;
            // 
            // CBType
            // 
            CBType.FormattingEnabled = true;
            CBType.Items.AddRange(new object[] { " ADMINISTRATOR", " HR", " VETARINARY", " CARETAKER" });
            CBType.Location = new Point(608, 263);
            CBType.Margin = new Padding(5);
            CBType.Name = "CBType";
            CBType.Size = new Size(356, 40);
            CBType.TabIndex = 9;
            CBType.SelectedIndexChanged += CBType_SelectedIndexChanged;
            // 
            // NUDCapacity
            // 
            NUDCapacity.Location = new Point(446, 263);
            NUDCapacity.Margin = new Padding(5);
            NUDCapacity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NUDCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDCapacity.Name = "NUDCapacity";
            NUDCapacity.Size = new Size(110, 39);
            NUDCapacity.TabIndex = 10;
            NUDCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DTPStart);
            groupBox1.Location = new Point(249, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(406, 154);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Start time";
            // 
            // DTPStart
            // 
            DTPStart.Format = DateTimePickerFormat.Custom;
            DTPStart.Location = new Point(84, 74);
            DTPStart.Margin = new Padding(5);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(170, 39);
            DTPStart.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DTPEnd);
            groupBox2.Location = new Point(683, 14);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(406, 154);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "End time";
            // 
            // DTPEnd
            // 
            DTPEnd.Format = DateTimePickerFormat.Custom;
            DTPEnd.Location = new Point(132, 74);
            DTPEnd.Margin = new Padding(5);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(170, 39);
            DTPEnd.TabIndex = 19;
            // 
            // LPosition
            // 
            LPosition.AutoSize = true;
            LPosition.Location = new Point(683, 211);
            LPosition.Margin = new Padding(5, 0, 5, 0);
            LPosition.Name = "LPosition";
            LPosition.Size = new Size(92, 32);
            LPosition.TabIndex = 13;
            LPosition.Text = "Positon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 227);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 32);
            label5.TabIndex = 14;
            label5.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 335);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(215, 32);
            label6.TabIndex = 15;
            label6.Text = "Avaible employees";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(856, 335);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(233, 32);
            label7.TabIndex = 16;
            label7.Text = "Assigned employees";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.WhiteSmoke;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.LightSeaGreen;
            btnCreate.Location = new Point(924, 608);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(309, 92);
            btnCreate.TabIndex = 55;
            btnCreate.Text = "Create Shift";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(59, 608);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(309, 92);
            btnBack.TabIndex = 56;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CreateShift
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LPosition);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(NUDCapacity);
            Controls.Add(CBType);
            Controls.Add(FLPAssignedEmp);
            Controls.Add(FLPAvaibleEmp);
            Margin = new Padding(5);
            Name = "CreateShift";
            Text = "CreateShift";
            ((System.ComponentModel.ISupportInitialize)NUDCapacity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel FLPAssignedEmp;
        private FlowLayoutPanel FLPAvaibleEmp;
        private ComboBox CBType;
        private NumericUpDown NUDCapacity;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label LPosition;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker DTPStart;
        private DateTimePicker DTPEnd;
        private Button btnCreate;
        private Button btnBack;
    }
}