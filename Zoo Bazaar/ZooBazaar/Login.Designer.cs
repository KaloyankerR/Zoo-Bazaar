namespace ZooBazaar
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            EMAIL = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(763, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 342);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(545, 701);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(830, 39);
            tbEmail.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(545, 913);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(830, 39);
            tbPassword.TabIndex = 2;
            // 
            // EMAIL
            // 
            EMAIL.AutoSize = true;
            EMAIL.Location = new Point(921, 647);
            EMAIL.Name = "EMAIL";
            EMAIL.Size = new Size(80, 32);
            EMAIL.TabIndex = 3;
            EMAIL.Text = "EMAIL";
            EMAIL.Click += EMAIL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(895, 861);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 4;
            label1.Text = "PASSWORD";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(729, 1121);
            button1.Name = "button1";
            button1.Size = new Size(483, 123);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1968, 1310);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(EMAIL);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label EMAIL;
        private Label label1;
        private Button button1;
    }
}