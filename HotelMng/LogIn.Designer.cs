namespace HotelMng
{
    partial class LogIn
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
            txtPassword = new TextBox();
            btnSignIn = new Button();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(231, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(329, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkBlue;
            btnSignIn.BackgroundImageLayout = ImageLayout.None;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.ButtonHighlight;
            btnSignIn.Location = new Point(300, 258);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(169, 40);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Info;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Location = new Point(231, 123);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(329, 27);
            txtUserName.TabIndex = 3;
            // 
            // LogIn
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserName);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn Page";
            TransparencyKey = Color.SeaGreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Button btnSignIn;
        private TextBox txtUserName;
    }
}
