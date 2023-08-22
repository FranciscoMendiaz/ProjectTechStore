namespace UserInterfaceLayer
{
    partial class formSignup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAdress = new TextBox();
            label6 = new Label();
            btnCreateAccount = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 41);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 147);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 192);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 95);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 236);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 41);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(208, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(127, 144);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(208, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(127, 189);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(208, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(127, 233);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(208, 23);
            txtAdress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 6);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 10;
            label6.Text = "Sign Up";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(174, 274);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(103, 34);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "CREAR CUENTA";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(174, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 34);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // formSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 373);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateAccount);
            Controls.Add(label6);
            Controls.Add(txtAdress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formSignup";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAdress;
        private Label label6;
        private Button btnCreateAccount;
        private Button btnCancel;
    }
}