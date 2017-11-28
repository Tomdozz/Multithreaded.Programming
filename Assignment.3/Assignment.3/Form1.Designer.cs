namespace Assignment._3
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
            this.plainTextBox = new System.Windows.Forms.ListBox();
            this.encryptedTextBox = new System.Windows.Forms.ListBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainTextBox
            // 
            this.plainTextBox.FormattingEnabled = true;
            this.plainTextBox.Location = new System.Drawing.Point(16, 86);
            this.plainTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(277, 394);
            this.plainTextBox.TabIndex = 0;
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.FormattingEnabled = true;
            this.encryptedTextBox.Location = new System.Drawing.Point(431, 86);
            this.encryptedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(264, 394);
            this.encryptedTextBox.TabIndex = 1;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(325, 180);
            this.Encrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(78, 29);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(325, 213);
            this.Decrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(78, 29);
            this.Decrypt.TabIndex = 3;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(298, 457);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(128, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit Application";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 507);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox plainTextBox;
        private System.Windows.Forms.ListBox encryptedTextBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Exit;
    }
}

