namespace HiddenPixels
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseEncrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtFileEncrypt = new System.Windows.Forms.TextBox();
            this.txtPasswordEncrypt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPasswordDecrypt = new System.Windows.Forms.TextBox();
            this.txtFileDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(248, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(61, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a photo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(299, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "set an encryption key";
            // 
            // btnBrowseEncrypt
            // 
            this.btnBrowseEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnBrowseEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBrowseEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBrowseEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseEncrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.btnBrowseEncrypt.Location = new System.Drawing.Point(64, 197);
            this.btnBrowseEncrypt.Name = "btnBrowseEncrypt";
            this.btnBrowseEncrypt.Size = new System.Drawing.Size(87, 40);
            this.btnBrowseEncrypt.TabIndex = 3;
            this.btnBrowseEncrypt.Text = "Browse";
            this.btnBrowseEncrypt.UseVisualStyleBackColor = false;
            this.btnBrowseEncrypt.Click += new System.EventHandler(this.btnBrowseEncrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEncrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.btnEncrypt.Location = new System.Drawing.Point(336, 327);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(87, 40);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtFileEncrypt
            // 
            this.txtFileEncrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileEncrypt.Location = new System.Drawing.Point(64, 171);
            this.txtFileEncrypt.Name = "txtFileEncrypt";
            this.txtFileEncrypt.Size = new System.Drawing.Size(359, 21);
            this.txtFileEncrypt.TabIndex = 5;
            // 
            // txtPasswordEncrypt
            // 
            this.txtPasswordEncrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordEncrypt.Location = new System.Drawing.Point(64, 301);
            this.txtPasswordEncrypt.Name = "txtPasswordEncrypt";
            this.txtPasswordEncrypt.Size = new System.Drawing.Size(359, 21);
            this.txtPasswordEncrypt.TabIndex = 6;
            this.txtPasswordEncrypt.TextChanged += new System.EventHandler(this.txtPasswordEncrypt_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel1.Location = new System.Drawing.Point(505, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 369);
            this.panel1.TabIndex = 7;
            // 
            // txtPasswordDecrypt
            // 
            this.txtPasswordDecrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordDecrypt.Location = new System.Drawing.Point(565, 301);
            this.txtPasswordDecrypt.Name = "txtPasswordDecrypt";
            this.txtPasswordDecrypt.Size = new System.Drawing.Size(359, 21);
            this.txtPasswordDecrypt.TabIndex = 14;
            this.txtPasswordDecrypt.TextChanged += new System.EventHandler(this.txtPasswordDecrypt_TextChanged);
            // 
            // txtFileDecrypt
            // 
            this.txtFileDecrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileDecrypt.Location = new System.Drawing.Point(565, 171);
            this.txtFileDecrypt.Name = "txtFileDecrypt";
            this.txtFileDecrypt.Size = new System.Drawing.Size(359, 21);
            this.txtFileDecrypt.TabIndex = 13;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.btnDecrypt.Location = new System.Drawing.Point(837, 327);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(87, 40);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnBrowseDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBrowseDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBrowseDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseDecrypt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(565, 197);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(87, 40);
            this.btnBrowseDecrypt.TabIndex = 11;
            this.btnBrowseDecrypt.Text = "Browse";
            this.btnBrowseDecrypt.UseVisualStyleBackColor = false;
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(771, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "confirm the encryption key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Location = new System.Drawing.Point(562, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select a photo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(761, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(994, 443);
            this.Controls.Add(this.txtPasswordDecrypt);
            this.Controls.Add(this.txtFileDecrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnBrowseDecrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPasswordEncrypt);
            this.Controls.Add(this.txtFileEncrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnBrowseEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseEncrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtFileEncrypt;
        private System.Windows.Forms.TextBox txtPasswordEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPasswordDecrypt;
        private System.Windows.Forms.TextBox txtFileDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnBrowseDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

