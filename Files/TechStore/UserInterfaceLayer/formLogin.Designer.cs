namespace UserInterfaceLayer
{
    partial class formLogin
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
            btnLogin = new Button();
            btnForgotPass = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lnkSingUp = new LinkLabel();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(136, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 27);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgotPass
            // 
            btnForgotPass.Location = new Point(136, 232);
            btnForgotPass.Name = "btnForgotPass";
            btnForgotPass.Size = new Size(146, 27);
            btnForgotPass.TabIndex = 1;
            btnForgotPass.Text = "Olvidé mi contraseña";
            btnForgotPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 82);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 140);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 36);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Iniciar Sesión";
            // 
            // lnkSingUp
            // 
            lnkSingUp.AutoSize = true;
            lnkSingUp.Location = new Point(136, 279);
            lnkSingUp.Name = "lnkSingUp";
            lnkSingUp.Size = new Size(161, 15);
            lnkSingUp.TabIndex = 5;
            lnkSingUp.TabStop = true;
            lnkSingUp.Text = "¿No tienes cuenta? Regístrate\r\n";
            lnkSingUp.LinkClicked += lnkSingUp_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(218, 23);
            txtPassword.TabIndex = 7;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 373);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lnkSingUp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnForgotPass);
            Controls.Add(btnLogin);
            Name = "formLogin";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnForgotPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel lnkSingUp;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}