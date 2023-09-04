namespace UserInterfaceLayer
{
    partial class formOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOwner));
            panelSide = new Panel();
            btnLogoHome = new PictureBox();
            btnLogOut = new Button();
            btnPaymentTypes = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            btnBrands = new Button();
            panelMain = new Panel();
            btnCategories = new Button();
            panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogoHome).BeginInit();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BackColor = SystemColors.Highlight;
            panelSide.Controls.Add(btnLogoHome);
            panelSide.Controls.Add(btnLogOut);
            panelSide.Controls.Add(btnPaymentTypes);
            panelSide.Controls.Add(btnCustomers);
            panelSide.Controls.Add(btnProducts);
            panelSide.Controls.Add(btnBrands);
            panelSide.Controls.Add(btnCategories);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(200, 563);
            panelSide.TabIndex = 0;
            // 
            // btnLogoHome
            // 
            btnLogoHome.Image = (Image)resources.GetObject("btnLogoHome.Image");
            btnLogoHome.Location = new Point(53, 12);
            btnLogoHome.Name = "btnLogoHome";
            btnLogoHome.Size = new Size(100, 100);
            btnLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogoHome.TabIndex = 0;
            btnLogoHome.TabStop = false;
            btnLogoHome.Click += btnLogoHome_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.Highlight;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(3, 530);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(200, 30);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Cerrar Sesión ← ";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnPaymentTypes
            // 
            btnPaymentTypes.BackColor = SystemColors.Highlight;
            btnPaymentTypes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaymentTypes.ForeColor = Color.White;
            btnPaymentTypes.Location = new Point(0, 239);
            btnPaymentTypes.Name = "btnPaymentTypes";
            btnPaymentTypes.Size = new Size(200, 30);
            btnPaymentTypes.TabIndex = 4;
            btnPaymentTypes.Text = "FORMAS DE PAGO";
            btnPaymentTypes.UseVisualStyleBackColor = false;
            btnPaymentTypes.Click += btnPaymentTypes_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.Highlight;
            btnCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 210);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(200, 30);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "CLIENTES";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Highlight;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 123);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 30);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "PRODUCTOS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnBrands
            // 
            btnBrands.BackColor = SystemColors.Highlight;
            btnBrands.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrands.ForeColor = Color.White;
            btnBrands.Location = new Point(0, 181);
            btnBrands.Name = "btnBrands";
            btnBrands.Size = new Size(200, 30);
            btnBrands.TabIndex = 2;
            btnBrands.Text = "MARCAS";
            btnBrands.UseVisualStyleBackColor = false;
            btnBrands.Click += btnBrands_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(708, 563);
            panelMain.TabIndex = 2;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.Highlight;
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 152);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(200, 30);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "CATEGORIAS";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // formOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 563);
            Controls.Add(panelMain);
            Controls.Add(panelSide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formOwner";
            Text = "formOwner";
            Load += formOwner_Load;
            panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLogoHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private Button btnLogOut;
        private Button btnPaymentTypes;
        private Button btnCustomers;
        private Button btnProducts;
        private Button btnBrands;
        private Panel panelMain;
        private PictureBox btnLogoHome;
        private Button btnCategories;
    }
}