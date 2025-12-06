namespace Forms_Prototype
{
    partial class Login
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
            LoginButton = new Button();
            Username = new Label();
            Password = new Label();
            UsernameTB = new TextBox();
            PasswordTB = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(475, 236);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(105, 64);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F);
            Username.Location = new Point(189, 112);
            Username.Name = "Username";
            Username.Size = new Size(81, 21);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F);
            Password.Location = new Point(194, 189);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // UsernameTB
            // 
            UsernameTB.Location = new Point(318, 114);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(137, 23);
            UsernameTB.TabIndex = 3;
            UsernameTB.TextChanged += UsernameTB_TextChanged;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(318, 187);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(137, 23);
            PasswordTB.TabIndex = 4;
            PasswordTB.TextChanged += PasswordTB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(637, 329);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 5;
            label1.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(637, 361);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create new account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "alice_wonder";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 190);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "pass123";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(PasswordTB);
            Controls.Add(UsernameTB);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(LoginButton);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label Username;
        private Label Password;
        private TextBox UsernameTB;
        private TextBox PasswordTB;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
    }
}