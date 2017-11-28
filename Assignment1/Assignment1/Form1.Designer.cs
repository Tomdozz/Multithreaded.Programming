namespace Assignment1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "STextThread";
            this.button1.AccessibleName = "STextThread";
            this.button1.Location = new System.Drawing.Point(38, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start text thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "StopTextThread";
            this.button2.AccessibleName = "StopTextThread";
            this.button2.Location = new System.Drawing.Point(38, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop Text Thread";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "SCubeThread";
            this.button3.AccessibleName = "SCubeThread";
            this.button3.Location = new System.Drawing.Point(38, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start Cube Thread";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "StopCube Thread";
            this.button4.AccessibleName = "StopCube Thread";
            this.button4.Location = new System.Drawing.Point(38, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stop Cube Thread";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "CubeThreadPanel";
            this.panel1.AccessibleName = "CubeThreadPanel";
            this.panel1.Location = new System.Drawing.Point(245, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 155);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "TextThreadPanel";
            this.panel2.AccessibleName = "TextThreadPanel";
            this.panel2.Location = new System.Drawing.Point(245, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 152);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "TextLabel";
            this.label1.AccessibleName = "TextLabel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text Thread";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "CuebLabel";
            this.label2.AccessibleName = "CuebLabel";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cube Thread";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(38, 205);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 462);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
    }
}

