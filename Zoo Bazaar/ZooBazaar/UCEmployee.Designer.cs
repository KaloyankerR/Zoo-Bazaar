namespace Desktop_Application
{
    partial class UCEmployee
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
            LName = new Label();
            SuspendLayout();
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.ForeColor = Color.LightSeaGreen;
            LName.Location = new Point(48, 15);
            LName.Name = "LName";
            LName.Size = new Size(50, 20);
            LName.TabIndex = 0;
            LName.Text = "label1";
            // 
            // UCEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(LName);
            Name = "UCEmployee";
            Size = new Size(148, 50);
            MouseDoubleClick += UCEmployee_MouseDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LName;
    }
}
