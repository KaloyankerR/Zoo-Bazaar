namespace Desktop_Application
{
    partial class ScheduleDay
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
            button1 = new Button();
            label1 = new Label();
            FLPShifts = new FlowLayoutPanel();
            tbEndTime = new TextBox();
            tbStartTime = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbPosition = new ComboBox();
            btnRefresh = new Button();
            btnFilter = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(58, 56);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(214, 91);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(544, 70);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 50);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // FLPShifts
            // 
            FLPShifts.AutoScroll = true;
            FLPShifts.BorderStyle = BorderStyle.FixedSingle;
            FLPShifts.Location = new Point(336, 299);
            FLPShifts.Margin = new Padding(5);
            FLPShifts.Name = "FLPShifts";
            FLPShifts.Size = new Size(598, 400);
            FLPShifts.TabIndex = 3;
            // 
            // tbEndTime
            // 
            tbEndTime.Location = new Point(816, 203);
            tbEndTime.Margin = new Padding(5);
            tbEndTime.Name = "tbEndTime";
            tbEndTime.Size = new Size(123, 39);
            tbEndTime.TabIndex = 14;
            // 
            // tbStartTime
            // 
            tbStartTime.Location = new Point(533, 203);
            tbStartTime.Margin = new Padding(5);
            tbStartTime.Name = "tbStartTime";
            tbStartTime.Size = new Size(123, 39);
            tbStartTime.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(816, 165);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 12;
            label4.Text = "End time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 165);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 11;
            label3.Text = "Start time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 165);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 10;
            label2.Text = "Position:";
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(202, 202);
            cbPosition.Margin = new Padding(5);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(196, 40);
            cbPosition.TabIndex = 9;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1056, 291);
            btnRefresh.Margin = new Padding(5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(153, 46);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(1056, 203);
            btnFilter.Margin = new Padding(5);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(153, 46);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.WhiteSmoke;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.LightSeaGreen;
            btnCreate.Location = new Point(995, 56);
            btnCreate.Margin = new Padding(5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(214, 91);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // ScheduleDay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnCreate);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(tbEndTime);
            Controls.Add(tbStartTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbPosition);
            Controls.Add(FLPShifts);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(5);
            Name = "ScheduleDay";
            Text = "ScheduleDay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private FlowLayoutPanel FLPShifts;
        private TextBox tbEndTime;
        private TextBox tbStartTime;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbPosition;
        private Button btnRefresh;
        private Button btnFilter;
        private Button btnCreate;
    }
}