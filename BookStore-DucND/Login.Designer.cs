namespace BookStore_DucND
{
    partial class frmLogin
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
            lblBookManager = new Label();
            grbSignin = new GroupBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnSignIn = new Button();
            lblPassword = new Label();
            lblEmail = new Label();
            lblSignin = new Label();
            grbSignin.SuspendLayout();
            SuspendLayout();
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookManager.Location = new Point(109, 26);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(181, 32);
            lblBookManager.TabIndex = 0;
            lblBookManager.Text = "Book Manager";
            // 
            // grbSignin
            // 
            grbSignin.BackColor = Color.Lime;
            grbSignin.Controls.Add(txtPassword);
            grbSignin.Controls.Add(txtEmail);
            grbSignin.Controls.Add(btnSignIn);
            grbSignin.Controls.Add(lblPassword);
            grbSignin.Controls.Add(lblEmail);
            grbSignin.Controls.Add(lblSignin);
            grbSignin.Location = new Point(71, 72);
            grbSignin.Name = "grbSignin";
            grbSignin.Size = new Size(256, 231);
            grbSignin.TabIndex = 1;
            grbSignin.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(38, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(181, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(38, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(192, 64, 0);
            btnSignIn.Location = new Point(86, 173);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(87, 30);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(31, 116);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblSignin
            // 
            lblSignin.AutoSize = true;
            lblSignin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignin.Location = new Point(86, 19);
            lblSignin.Name = "lblSignin";
            lblSignin.Size = new Size(63, 21);
            lblSignin.TabIndex = 0;
            lblSignin.Text = "Sign In";
            // 
            // frmLogin
            // 
            AcceptButton = btnSignIn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(401, 337);
            Controls.Add(grbSignin);
            Controls.Add(lblBookManager);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grbSignin.ResumeLayout(false);
            grbSignin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookManager;
        private GroupBox grbSignin;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblSignin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnSignIn;
    }
}