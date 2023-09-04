namespace UserInterfaceLayer
{
    partial class formAddPT
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
            groupBox1 = new GroupBox();
            btnCancelNewPT = new Button();
            btnAcceptNewPT = new Button();
            txtNewPT = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelNewPT);
            groupBox1.Controls.Add(btnAcceptNewPT);
            groupBox1.Controls.Add(txtNewPT);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 180);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descripcion de la Forma de Pago";
            // 
            // btnCancelNewPT
            // 
            btnCancelNewPT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelNewPT.Location = new Point(92, 130);
            btnCancelNewPT.Name = "btnCancelNewPT";
            btnCancelNewPT.Size = new Size(78, 34);
            btnCancelNewPT.TabIndex = 2;
            btnCancelNewPT.Text = "CANCELAR";
            btnCancelNewPT.UseVisualStyleBackColor = true;
            btnCancelNewPT.Click += btnCancel_Click;
            // 
            // btnAcceptNewPT
            // 
            btnAcceptNewPT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceptNewPT.Location = new Point(93, 90);
            btnAcceptNewPT.Name = "btnAcceptNewPT";
            btnAcceptNewPT.Size = new Size(77, 34);
            btnAcceptNewPT.TabIndex = 1;
            btnAcceptNewPT.Text = "ACEPTAR";
            btnAcceptNewPT.UseVisualStyleBackColor = true;
            btnAcceptNewPT.Click += btnAcceptNewPT_Click;
            // 
            // txtNewPT
            // 
            txtNewPT.Location = new Point(18, 42);
            txtNewPT.Name = "txtNewPT";
            txtNewPT.Size = new Size(254, 27);
            txtNewPT.TabIndex = 0;
            // 
            // formAddPT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 210);
            ControlBox = false;
            Controls.Add(groupBox1);
            Name = "formAddPT";
            Text = "Forma De Pago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnCancelNewPT;
        private Button btnAcceptNewPT;
        private TextBox txtNewPT;
    }
}