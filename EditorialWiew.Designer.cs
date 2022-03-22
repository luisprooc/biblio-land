namespace Biblioteca
{
    partial class EditorialWiew
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
            this.dgvEditorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddEditorial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddEditorial = new System.Windows.Forms.Button();
            this.btnDeleteEditorial = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateEditorial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditorial
            // 
            this.dgvEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditorial.Location = new System.Drawing.Point(33, 91);
            this.dgvEditorial.Name = "dgvEditorial";
            this.dgvEditorial.Size = new System.Drawing.Size(244, 323);
            this.dgvEditorial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "EDITORIAL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.librosToolStripMenuItem.Text = "Libros 📕";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.autoresToolStripMenuItem.Text = "Autores 👨‍💼";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios 👩👨";
            // 
            // txtAddEditorial
            // 
            this.txtAddEditorial.Location = new System.Drawing.Point(423, 121);
            this.txtAddEditorial.Name = "txtAddEditorial";
            this.txtAddEditorial.Size = new System.Drawing.Size(145, 20);
            this.txtAddEditorial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de la Editorial";
            // 
            // btnAddEditorial
            // 
            this.btnAddEditorial.Location = new System.Drawing.Point(574, 119);
            this.btnAddEditorial.Name = "btnAddEditorial";
            this.btnAddEditorial.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditorial.TabIndex = 6;
            this.btnAddEditorial.Text = "Agregar";
            this.btnAddEditorial.UseVisualStyleBackColor = true;
            this.btnAddEditorial.Click += new System.EventHandler(this.btnAddEditorial_Click);
            // 
            // btnDeleteEditorial
            // 
            this.btnDeleteEditorial.Location = new System.Drawing.Point(528, 372);
            this.btnDeleteEditorial.Name = "btnDeleteEditorial";
            this.btnDeleteEditorial.Size = new System.Drawing.Size(138, 42);
            this.btnDeleteEditorial.TabIndex = 6;
            this.btnDeleteEditorial.Text = "Borrar Editorial";
            this.btnDeleteEditorial.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Location = new System.Drawing.Point(347, 372);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(153, 42);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refrescar 🔄";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(569, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 24);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateEditorial
            // 
            this.txtUpdateEditorial.Location = new System.Drawing.Point(414, 166);
            this.txtUpdateEditorial.Name = "txtUpdateEditorial";
            this.txtUpdateEditorial.Size = new System.Drawing.Size(145, 20);
            this.txtUpdateEditorial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Actualizar ";
            // 
            // EditorialWiew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.btnDeleteEditorial);
            this.Controls.Add(this.btnAddEditorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpdateEditorial);
            this.Controls.Add(this.txtAddEditorial);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEditorial);
            this.Name = "EditorialWiew";
            this.Text = "EditorialWiew";
            this.Load += new System.EventHandler(this.EditorialWiew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAddEditorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEditorial;
        private System.Windows.Forms.Button btnDeleteEditorial;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateEditorial;
        private System.Windows.Forms.Label label3;
    }
}