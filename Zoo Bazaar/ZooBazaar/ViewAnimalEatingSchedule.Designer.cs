namespace Desktop_Application
{
    partial class ViewAnimalEatingSchedule
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
            dgvEatingSchedule = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxAnimalName = new TextBox();
            tbxNrTimesEatsDay = new TextBox();
            btnAddSchedule = new Button();
            btnDeleteSchedule = new Button();
            btnEditSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEatingSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvEatingSchedule
            // 
            dgvEatingSchedule.AllowUserToAddRows = false;
            dgvEatingSchedule.AllowUserToDeleteRows = false;
            dgvEatingSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEatingSchedule.BackgroundColor = Color.WhiteSmoke;
            dgvEatingSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEatingSchedule.Location = new Point(16, 17);
            dgvEatingSchedule.Margin = new Padding(4);
            dgvEatingSchedule.Name = "dgvEatingSchedule";
            dgvEatingSchedule.ReadOnly = true;
            dgvEatingSchedule.RowHeadersWidth = 62;
            dgvEatingSchedule.RowTemplate.Height = 33;
            dgvEatingSchedule.Size = new Size(468, 786);
            dgvEatingSchedule.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 5;
            label1.Text = "Animal name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 64);
            label2.TabIndex = 6;
            label2.Text = "Number of times animal\r\neats per day:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 246);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // tbxAnimalName
            // 
            tbxAnimalName.BackColor = Color.White;
            tbxAnimalName.Location = new Point(491, 78);
            tbxAnimalName.Margin = new Padding(4);
            tbxAnimalName.Name = "tbxAnimalName";
            tbxAnimalName.ReadOnly = true;
            tbxAnimalName.Size = new Size(264, 39);
            tbxAnimalName.TabIndex = 8;
            // 
            // tbxNrTimesEatsDay
            // 
            tbxNrTimesEatsDay.BackColor = Color.White;
            tbxNrTimesEatsDay.Location = new Point(493, 238);
            tbxNrTimesEatsDay.Margin = new Padding(4);
            tbxNrTimesEatsDay.Name = "tbxNrTimesEatsDay";
            tbxNrTimesEatsDay.ReadOnly = true;
            tbxNrTimesEatsDay.Size = new Size(264, 39);
            tbxNrTimesEatsDay.TabIndex = 9;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.BackColor = Color.WhiteSmoke;
            btnAddSchedule.FlatStyle = FlatStyle.Flat;
            btnAddSchedule.Font = new Font("Nirmala UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSchedule.ForeColor = Color.LightSeaGreen;
            btnAddSchedule.Location = new Point(498, 477);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(264, 92);
            btnAddSchedule.TabIndex = 46;
            btnAddSchedule.Text = "Add New Schedule";
            btnAddSchedule.UseVisualStyleBackColor = false;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // btnDeleteSchedule
            // 
            btnDeleteSchedule.BackColor = Color.WhiteSmoke;
            btnDeleteSchedule.FlatStyle = FlatStyle.Flat;
            btnDeleteSchedule.Font = new Font("Nirmala UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteSchedule.ForeColor = Color.LightSeaGreen;
            btnDeleteSchedule.Location = new Point(498, 590);
            btnDeleteSchedule.Name = "btnDeleteSchedule";
            btnDeleteSchedule.Size = new Size(264, 92);
            btnDeleteSchedule.TabIndex = 47;
            btnDeleteSchedule.Text = "Delete Schedule";
            btnDeleteSchedule.UseVisualStyleBackColor = false;
            btnDeleteSchedule.Click += btnDeleteSchedule_Click;
            // 
            // btnEditSchedule
            // 
            btnEditSchedule.BackColor = Color.WhiteSmoke;
            btnEditSchedule.FlatStyle = FlatStyle.Flat;
            btnEditSchedule.Font = new Font("Nirmala UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditSchedule.ForeColor = Color.LightSeaGreen;
            btnEditSchedule.Location = new Point(498, 700);
            btnEditSchedule.Name = "btnEditSchedule";
            btnEditSchedule.Size = new Size(264, 92);
            btnEditSchedule.TabIndex = 48;
            btnEditSchedule.Text = "Edit Entire Schedule";
            btnEditSchedule.UseVisualStyleBackColor = false;
            btnEditSchedule.Click += btnEditSchedule_Click;
            // 
            // ViewAnimalEatingSchedule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 818);
            Controls.Add(btnEditSchedule);
            Controls.Add(btnDeleteSchedule);
            Controls.Add(btnAddSchedule);
            Controls.Add(tbxNrTimesEatsDay);
            Controls.Add(tbxAnimalName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEatingSchedule);
            Margin = new Padding(4);
            Name = "ViewAnimalEatingSchedule";
            Text = "ViewAnimalEatingSchedule";
            ((System.ComponentModel.ISupportInitialize)dgvEatingSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvEatingSchedule;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxAnimalName;
        private TextBox tbxNrTimesEatsDay;
        private Button btnAddSchedule;
        private Button btnDeleteSchedule;
        private Button btnEditSchedule;
    }
}