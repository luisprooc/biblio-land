
namespace Biblioteca
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATE";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(124, 196);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 25);
            this.nameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(124, 294);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(199, 25);
            this.passwordBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(391, 196);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(199, 25);
            this.emailBox.TabIndex = 3;
            // 
            // passwordConfirmBox
            // 
            this.passwordConfirmBox.Location = new System.Drawing.Point(391, 294);
            this.passwordConfirmBox.Name = "passwordConfirmBox";
            this.passwordConfirmBox.Size = new System.Drawing.Size(199, 25);
            this.passwordConfirmBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo Electronico";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Location = new System.Drawing.Point(279, 391);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(146, 40);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Registrarse";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.kisspng_computer_icons_symbol_login_register_button_5ac21706854256_2899999815226693185458_removebg_preview_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(637, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordConfirmBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegisterForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordConfirmBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}