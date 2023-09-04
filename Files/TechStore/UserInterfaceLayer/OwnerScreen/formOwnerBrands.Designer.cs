namespace UserInterfaceLayer
{
    partial class formOwnerBrands
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnAddBrand = new Button();
            btnUpdateBrand = new Button();
            btnDeleteBrand = new Button();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "MARCAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName });
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(283, 334);
            dataGridView1.TabIndex = 2;
            // 
            // btnAddBrand
            // 
            btnAddBrand.Location = new Point(325, 36);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(200, 30);
            btnAddBrand.TabIndex = 3;
            btnAddBrand.Text = "AÑADIR MARCA";
            btnAddBrand.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBrand
            // 
            btnUpdateBrand.Location = new Point(325, 103);
            btnUpdateBrand.Name = "btnUpdateBrand";
            btnUpdateBrand.Size = new Size(200, 30);
            btnUpdateBrand.TabIndex = 4;
            btnUpdateBrand.Text = "MODIFICAR MARCA";
            btnUpdateBrand.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBrand
            // 
            btnDeleteBrand.BackColor = Color.Red;
            btnDeleteBrand.ForeColor = Color.White;
            btnDeleteBrand.Location = new Point(325, 173);
            btnDeleteBrand.Name = "btnDeleteBrand";
            btnDeleteBrand.Size = new Size(200, 30);
            btnDeleteBrand.TabIndex = 5;
            btnDeleteBrand.Text = "ELIMINAR MARCA";
            btnDeleteBrand.UseVisualStyleBackColor = false;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID Marca";
            ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre de la Marca";
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 140;
            // 
            // formOwnerBrands
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteBrand);
            Controls.Add(btnUpdateBrand);
            Controls.Add(btnAddBrand);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formOwnerBrands";
            Text = "formOwnerBrands";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnAddBrand;
        private Button btnUpdateBrand;
        private Button btnDeleteBrand;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
    }
}