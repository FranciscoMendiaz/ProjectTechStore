﻿namespace UserInterfaceLayer
{
    partial class formOwnerPaymentTypes
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            gridPaymentTypes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentTypeBindingSource = new BindingSource(components);
            btnAddPT = new Button();
            btnUpdatePT = new Button();
            btnDeletePT = new Button();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            toolTipSearch = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPaymentTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 0;
            label1.Text = "FORMAS DE PAGO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 2;
            // 
            // gridPaymentTypes
            // 
            gridPaymentTypes.AutoGenerateColumns = false;
            gridPaymentTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPaymentTypes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            gridPaymentTypes.DataSource = paymentTypeBindingSource;
            gridPaymentTypes.Location = new Point(12, 75);
            gridPaymentTypes.Name = "gridPaymentTypes";
            gridPaymentTypes.RowTemplate.Height = 25;
            gridPaymentTypes.Size = new Size(322, 344);
            gridPaymentTypes.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion Forma de Pago";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // paymentTypeBindingSource
            // 
            paymentTypeBindingSource.DataSource = typeof(EntitiesLayer.PaymentType);
            // 
            // btnAddPT
            // 
            btnAddPT.Location = new Point(390, 36);
            btnAddPT.Name = "btnAddPT";
            btnAddPT.Size = new Size(200, 30);
            btnAddPT.TabIndex = 4;
            btnAddPT.Text = "AÑADIR UNA FORMA DE PAGO";
            btnAddPT.UseVisualStyleBackColor = true;
            btnAddPT.Click += btnAddPT_Click;
            // 
            // btnUpdatePT
            // 
            btnUpdatePT.Location = new Point(390, 108);
            btnUpdatePT.Name = "btnUpdatePT";
            btnUpdatePT.Size = new Size(200, 30);
            btnUpdatePT.TabIndex = 5;
            btnUpdatePT.Text = "MODIFICAR FORMA DE PAGO";
            btnUpdatePT.UseVisualStyleBackColor = true;
            btnUpdatePT.Click += btnUpdatePT_Click;
            // 
            // btnDeletePT
            // 
            btnDeletePT.BackColor = Color.Red;
            btnDeletePT.ForeColor = Color.White;
            btnDeletePT.Location = new Point(390, 180);
            btnDeletePT.Name = "btnDeletePT";
            btnDeletePT.Size = new Size(200, 30);
            btnDeletePT.TabIndex = 6;
            btnDeletePT.Text = "ELIMINAR FORMA DE PAGO";
            btnDeletePT.UseVisualStyleBackColor = false;
            btnDeletePT.Click += btnDeletePT_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(12, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(34, 30);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(52, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 23);
            txtSearch.TabIndex = 8;
            toolTipSearch.SetToolTip(txtSearch, "Buscar Forma de pago por descripción\r\n");
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(284, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(50, 30);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "🔍︎";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // toolTipSearch
            // 
            toolTipSearch.IsBalloon = true;
            // 
            // formOwnerPaymentTypes
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeletePT);
            Controls.Add(btnUpdatePT);
            Controls.Add(btnAddPT);
            Controls.Add(gridPaymentTypes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formOwnerPaymentTypes";
            Text = "formOwnerPaymentTypes";
            Load += formOwnerPaymentTypes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPaymentTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentTypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView gridPaymentTypes;
        private Button btnAddPT;
        private Button btnUpdatePT;
        private Button btnDeletePT;
        private BindingSource paymentTypeBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Button btnSearch;
        private ToolTip toolTipSearch;
    }
}