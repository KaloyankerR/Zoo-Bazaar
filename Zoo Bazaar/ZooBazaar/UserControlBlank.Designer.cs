namespace DesktopApplication
{
    partial class UserControlBlank
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
            lblText = new Label();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblText.ForeColor = Color.WhiteSmoke;
            lblText.Location = new Point(13, 18);
            lblText.Name = "lblText";
            lblText.Size = new Size(0, 45);
            lblText.TabIndex = 0;
            // 
            // UserControlBlank
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblText);
            Name = "UserControlBlank";
            Size = new Size(265, 160);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
    }
}
