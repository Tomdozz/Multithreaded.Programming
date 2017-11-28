namespace Assignment5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pHouseStatus = new System.Windows.Forms.Label();
            this.parkingQStatus = new System.Windows.Forms.Label();
            this.openPHouse = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.Button();
            this.nortE = new System.Windows.Forms.GroupBox();
            this.northE = new System.Windows.Forms.Label();
            this.northQ = new System.Windows.Forms.Label();
            this.southE = new System.Windows.Forms.GroupBox();
            this.southExit = new System.Windows.Forms.Label();
            this.southQ = new System.Windows.Forms.Label();
            this.westE = new System.Windows.Forms.GroupBox();
            this.westExit = new System.Windows.Forms.Label();
            this.westQ = new System.Windows.Forms.Label();
            this.eastE = new System.Windows.Forms.GroupBox();
            this.eastExit = new System.Windows.Forms.Label();
            this.eastQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.nortE.SuspendLayout();
            this.southE.SuspendLayout();
            this.westE.SuspendLayout();
            this.eastE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.pHouseStatus);
            this.groupBox1.Controls.Add(this.parkingQStatus);
            this.groupBox1.Controls.Add(this.openPHouse);
            this.groupBox1.Location = new System.Drawing.Point(295, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(461, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parking House";
            // 
            // pHouseStatus
            // 
            this.pHouseStatus.AutoSize = true;
            this.pHouseStatus.Location = new System.Drawing.Point(138, 119);
            this.pHouseStatus.Name = "pHouseStatus";
            this.pHouseStatus.Size = new System.Drawing.Size(113, 13);
            this.pHouseStatus.TabIndex = 2;
            this.pHouseStatus.Text = "Parking House Status:";
            // 
            // parkingQStatus
            // 
            this.parkingQStatus.AutoSize = true;
            this.parkingQStatus.Location = new System.Drawing.Point(6, 119);
            this.parkingQStatus.Name = "parkingQStatus";
            this.parkingQStatus.Size = new System.Drawing.Size(114, 13);
            this.parkingQStatus.TabIndex = 1;
            this.parkingQStatus.Text = "Parking Queue Status:";
            // 
            // openPHouse
            // 
            this.openPHouse.Location = new System.Drawing.Point(6, 43);
            this.openPHouse.Name = "openPHouse";
            this.openPHouse.Size = new System.Drawing.Size(134, 23);
            this.openPHouse.TabIndex = 0;
            this.openPHouse.Text = "Open Parking house";
            this.openPHouse.UseVisualStyleBackColor = true;
            this.openPHouse.Click += new System.EventHandler(this.openPHouse_Click);
            // 
            // closeApp
            // 
            this.closeApp.BackColor = System.Drawing.Color.DarkRed;
            this.closeApp.Location = new System.Drawing.Point(436, 632);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(164, 23);
            this.closeApp.TabIndex = 1;
            this.closeApp.Text = "Exit application";
            this.closeApp.UseVisualStyleBackColor = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // nortE
            // 
            this.nortE.Controls.Add(this.label5);
            this.nortE.Controls.Add(this.label1);
            this.nortE.Controls.Add(this.northE);
            this.nortE.Controls.Add(this.northQ);
            this.nortE.Location = new System.Drawing.Point(295, 86);
            this.nortE.Name = "nortE";
            this.nortE.Size = new System.Drawing.Size(200, 100);
            this.nortE.TabIndex = 2;
            this.nortE.TabStop = false;
            this.nortE.Text = "North entrance";
            // 
            // northE
            // 
            this.northE.AutoSize = true;
            this.northE.Location = new System.Drawing.Point(125, 84);
            this.northE.Name = "northE";
            this.northE.Size = new System.Drawing.Size(55, 13);
            this.northE.TabIndex = 1;
            this.northE.Text = "North exit:";
            // 
            // northQ
            // 
            this.northQ.AutoSize = true;
            this.northQ.Location = new System.Drawing.Point(125, 16);
            this.northQ.Name = "northQ";
            this.northQ.Size = new System.Drawing.Size(69, 13);
            this.northQ.TabIndex = 0;
            this.northQ.Text = "North queue:";
            // 
            // southE
            // 
            this.southE.Controls.Add(this.label7);
            this.southE.Controls.Add(this.label3);
            this.southE.Controls.Add(this.southExit);
            this.southE.Controls.Add(this.southQ);
            this.southE.Location = new System.Drawing.Point(556, 490);
            this.southE.Name = "southE";
            this.southE.Size = new System.Drawing.Size(200, 100);
            this.southE.TabIndex = 3;
            this.southE.TabStop = false;
            this.southE.Text = "South entrance";
            // 
            // southExit
            // 
            this.southExit.AutoSize = true;
            this.southExit.Location = new System.Drawing.Point(123, 84);
            this.southExit.Name = "southExit";
            this.southExit.Size = new System.Drawing.Size(57, 13);
            this.southExit.TabIndex = 6;
            this.southExit.Text = "South exit:";
            // 
            // southQ
            // 
            this.southQ.AutoSize = true;
            this.southQ.Location = new System.Drawing.Point(123, 16);
            this.southQ.Name = "southQ";
            this.southQ.Size = new System.Drawing.Size(71, 13);
            this.southQ.TabIndex = 0;
            this.southQ.Text = "South queue:";
            // 
            // westE
            // 
            this.westE.Controls.Add(this.label8);
            this.westE.Controls.Add(this.label4);
            this.westE.Controls.Add(this.westExit);
            this.westE.Controls.Add(this.westQ);
            this.westE.Location = new System.Drawing.Point(89, 384);
            this.westE.Name = "westE";
            this.westE.Size = new System.Drawing.Size(200, 100);
            this.westE.TabIndex = 4;
            this.westE.TabStop = false;
            this.westE.Text = "West entrance";
            // 
            // westExit
            // 
            this.westExit.AutoSize = true;
            this.westExit.Location = new System.Drawing.Point(126, 84);
            this.westExit.Name = "westExit";
            this.westExit.Size = new System.Drawing.Size(54, 13);
            this.westExit.TabIndex = 6;
            this.westExit.Text = "West exit:";
            // 
            // westQ
            // 
            this.westQ.AutoSize = true;
            this.westQ.Location = new System.Drawing.Point(126, 16);
            this.westQ.Name = "westQ";
            this.westQ.Size = new System.Drawing.Size(68, 13);
            this.westQ.TabIndex = 0;
            this.westQ.Text = "West queue:";
            // 
            // eastE
            // 
            this.eastE.Controls.Add(this.label6);
            this.eastE.Controls.Add(this.label2);
            this.eastE.Controls.Add(this.eastExit);
            this.eastE.Controls.Add(this.eastQ);
            this.eastE.Location = new System.Drawing.Point(762, 192);
            this.eastE.Name = "eastE";
            this.eastE.Size = new System.Drawing.Size(200, 100);
            this.eastE.TabIndex = 5;
            this.eastE.TabStop = false;
            this.eastE.Text = "East entrance";
            // 
            // eastExit
            // 
            this.eastExit.AutoSize = true;
            this.eastExit.Location = new System.Drawing.Point(130, 84);
            this.eastExit.Name = "eastExit";
            this.eastExit.Size = new System.Drawing.Size(50, 13);
            this.eastExit.TabIndex = 6;
            this.eastExit.Text = "East exit:";
            // 
            // eastQ
            // 
            this.eastQ.AutoSize = true;
            this.eastQ.Location = new System.Drawing.Point(130, 16);
            this.eastQ.Name = "eastQ";
            this.eastQ.Size = new System.Drawing.Size(64, 13);
            this.eastQ.TabIndex = 0;
            this.eastQ.Text = "East queue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "In Queue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "In Queue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "In Queue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "In Queue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Exit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Exit:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 667);
            this.Controls.Add(this.eastE);
            this.Controls.Add(this.westE);
            this.Controls.Add(this.southE);
            this.Controls.Add(this.nortE);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.nortE.ResumeLayout(false);
            this.nortE.PerformLayout();
            this.southE.ResumeLayout(false);
            this.southE.PerformLayout();
            this.westE.ResumeLayout(false);
            this.westE.PerformLayout();
            this.eastE.ResumeLayout(false);
            this.eastE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pHouseStatus;
        private System.Windows.Forms.Label parkingQStatus;
        private System.Windows.Forms.Button openPHouse;
        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.GroupBox nortE;
        private System.Windows.Forms.Label northE;
        private System.Windows.Forms.Label northQ;
        private System.Windows.Forms.GroupBox southE;
        private System.Windows.Forms.Label southExit;
        private System.Windows.Forms.Label southQ;
        private System.Windows.Forms.GroupBox westE;
        private System.Windows.Forms.Label westExit;
        private System.Windows.Forms.Label westQ;
        private System.Windows.Forms.GroupBox eastE;
        private System.Windows.Forms.Label eastExit;
        private System.Windows.Forms.Label eastQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}

