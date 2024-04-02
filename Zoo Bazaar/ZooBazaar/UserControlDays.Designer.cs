namespace DesktopApplication
{
    partial class UserControlDays
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
            lblDays = new Label();
            lblReservations = new Label();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDays.ForeColor = Color.LightSeaGreen;
            lblDays.Location = new Point(10, 9);
            lblDays.Margin = new Padding(2, 0, 2, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(36, 28);
            lblDays.TabIndex = 1;
            lblDays.Text = "00";
            lblDays.MouseDoubleClick += lblDays_MouseDoubleClick;
            // 
            // lblReservations
            // 
            lblReservations.Font = new Font("Nirmala UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblReservations.ForeColor = Color.Black;
            lblReservations.Location = new Point(2, 52);
            lblReservations.Margin = new Padding(2, 0, 2, 0);
            lblReservations.Name = "lblReservations";
            lblReservations.Size = new Size(161, 40);
            lblReservations.TabIndex = 2;
            lblReservations.TextAlign = ContentAlignment.MiddleCenter;
            lblReservations.MouseDoubleClick += lblReservations_MouseDoubleClick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblReservations);
            Controls.Add(lblDays);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserControlDays";
            Size = new Size(163, 100);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            MouseDoubleClick += UserControlDays_MouseDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
        private Label lblReservations;
    }
}
