
namespace Biblioteca
{
    partial class AuthorAdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgAuthor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.sexCb = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.contryBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuthor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.editorialesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.librosToolStripMenuItem.Text = "Libros 📕";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.editorialesToolStripMenuItem.Text = "Editoriales 🏢";
            this.editorialesToolStripMenuItem.Click += new System.EventHandler(this.editorialesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios 👩👨";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // dgAuthor
            // 
            this.dgAuthor.AllowUserToAddRows = false;
            this.dgAuthor.AllowUserToDeleteRows = false;
            this.dgAuthor.AllowUserToOrderColumns = true;
            this.dgAuthor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuthor.Location = new System.Drawing.Point(294, 102);
            this.dgAuthor.Name = "dgAuthor";
            this.dgAuthor.RowHeadersWidth = 51;
            this.dgAuthor.RowTemplate.Height = 24;
            this.dgAuthor.Size = new System.Drawing.Size(638, 274);
            this.dgAuthor.TabIndex = 2;
            this.dgAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAuthor_CellContentClick);
            this.dgAuthor.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAuthor_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.sexCb);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.lastNameBox);
            this.panel1.Controls.Add(this.contryBox);
            this.panel1.Controls.Add(this.firstNameBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 237);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saveBtn
            // 
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(464, 130);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(142, 46);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(461, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(241, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apellidos";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(12, 35);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(78, 18);
            this.Nombre.TabIndex = 10;
            this.Nombre.Text = "Nombres";
            // 
            // sexCb
            // 
            this.sexCb.FormattingEnabled = true;
            this.sexCb.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexCb.Location = new System.Drawing.Point(244, 150);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(183, 26);
            this.sexCb.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(464, 66);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(400, 25);
            this.dateTimePicker.TabIndex = 8;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(12, 151);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(183, 25);
            this.lastNameBox.TabIndex = 3;
            // 
            // contryBox
            // 
            this.contryBox.Location = new System.Drawing.Point(244, 66);
            this.contryBox.Name = "contryBox";
            this.contryBox.Size = new System.Drawing.Size(183, 25);
            this.contryBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(12, 66);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(183, 25);
            this.firstNameBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(359, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autores";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(67, 118);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(152, 46);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Eliminar❌";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.ForeColor = System.Drawing.Color.Black;
            this.refreshBtn.Location = new System.Drawing.Point(67, 206);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(152, 42);
            this.refreshBtn.TabIndex = 18;
            this.refreshBtn.Text = "Refrescar 🔄";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // AuthorAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 630);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgAuthor);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AuthorAdminForm";
            this.Text = "Biblio Land - Autores";
            this.Load += new System.EventHandler(this.AuthorAdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuthor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox sexCb;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox contryBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}