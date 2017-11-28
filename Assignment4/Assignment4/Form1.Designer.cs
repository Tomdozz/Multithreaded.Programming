namespace Assignment4
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
            this.receptionGruopBox = new System.Windows.Forms.GroupBox();
            this.wQLabelCP = new System.Windows.Forms.Label();
            this.wQLabelAP = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.waitingCP = new System.Windows.Forms.Label();
            this.waitingAPlable = new System.Windows.Forms.Label();
            this.adventureGroupBox = new System.Windows.Forms.GroupBox();
            this.exitAP = new System.Windows.Forms.Label();
            this.apPictureBox = new System.Windows.Forms.PictureBox();
            this.visitorLabelAP = new System.Windows.Forms.Label();
            this.limitLabelAP = new System.Windows.Forms.Label();
            this.commonPoolgroupBox = new System.Windows.Forms.GroupBox();
            this.exitCP = new System.Windows.Forms.Label();
            this.cpPictureBox = new System.Windows.Forms.PictureBox();
            this.visitorLabelCP = new System.Windows.Forms.Label();
            this.limitLabelCP = new System.Windows.Forms.Label();
            this.moveFromCPLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.receptionGruopBox.SuspendLayout();
            this.adventureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apPictureBox)).BeginInit();
            this.commonPoolgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // receptionGruopBox
            // 
            this.receptionGruopBox.Controls.Add(this.button1);
            this.receptionGruopBox.Controls.Add(this.wQLabelCP);
            this.receptionGruopBox.Controls.Add(this.wQLabelAP);
            this.receptionGruopBox.Controls.Add(this.open);
            this.receptionGruopBox.Controls.Add(this.waitingCP);
            this.receptionGruopBox.Controls.Add(this.waitingAPlable);
            this.receptionGruopBox.Location = new System.Drawing.Point(20, 20);
            this.receptionGruopBox.Margin = new System.Windows.Forms.Padding(2);
            this.receptionGruopBox.Name = "receptionGruopBox";
            this.receptionGruopBox.Padding = new System.Windows.Forms.Padding(2);
            this.receptionGruopBox.Size = new System.Drawing.Size(213, 437);
            this.receptionGruopBox.TabIndex = 0;
            this.receptionGruopBox.TabStop = false;
            this.receptionGruopBox.Text = "Reception";
            this.receptionGruopBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // wQLabelCP
            // 
            this.wQLabelCP.AutoSize = true;
            this.wQLabelCP.Location = new System.Drawing.Point(162, 292);
            this.wQLabelCP.Name = "wQLabelCP";
            this.wQLabelCP.Size = new System.Drawing.Size(13, 13);
            this.wQLabelCP.TabIndex = 4;
            this.wQLabelCP.Text = "0";
            // 
            // wQLabelAP
            // 
            this.wQLabelAP.AutoSize = true;
            this.wQLabelAP.Location = new System.Drawing.Point(170, 37);
            this.wQLabelAP.Name = "wQLabelAP";
            this.wQLabelAP.Size = new System.Drawing.Size(13, 13);
            this.wQLabelAP.TabIndex = 3;
            this.wQLabelAP.Text = "0";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(7, 183);
            this.open.Margin = new System.Windows.Forms.Padding(2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(93, 25);
            this.open.TabIndex = 2;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // waitingCP
            // 
            this.waitingCP.AutoSize = true;
            this.waitingCP.Location = new System.Drawing.Point(4, 292);
            this.waitingCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waitingCP.Name = "waitingCP";
            this.waitingCP.Size = new System.Drawing.Size(153, 13);
            this.waitingCP.TabIndex = 1;
            this.waitingCP.Text = "Waiting to enter Common Pool:";
            // 
            // waitingAPlable
            // 
            this.waitingAPlable.AutoSize = true;
            this.waitingAPlable.Location = new System.Drawing.Point(4, 37);
            this.waitingAPlable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waitingAPlable.Name = "waitingAPlable";
            this.waitingAPlable.Size = new System.Drawing.Size(161, 13);
            this.waitingAPlable.TabIndex = 0;
            this.waitingAPlable.Text = "Waiting to enter Adventure Pool:";
            // 
            // adventureGroupBox
            // 
            this.adventureGroupBox.Controls.Add(this.exitAP);
            this.adventureGroupBox.Controls.Add(this.apPictureBox);
            this.adventureGroupBox.Controls.Add(this.visitorLabelAP);
            this.adventureGroupBox.Controls.Add(this.limitLabelAP);
            this.adventureGroupBox.Location = new System.Drawing.Point(408, 20);
            this.adventureGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.adventureGroupBox.Name = "adventureGroupBox";
            this.adventureGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.adventureGroupBox.Size = new System.Drawing.Size(615, 169);
            this.adventureGroupBox.TabIndex = 1;
            this.adventureGroupBox.TabStop = false;
            this.adventureGroupBox.Text = "Adventure Pool";
            // 
            // exitAP
            // 
            this.exitAP.AutoSize = true;
            this.exitAP.Location = new System.Drawing.Point(431, 53);
            this.exitAP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitAP.Name = "exitAP";
            this.exitAP.Size = new System.Drawing.Size(24, 13);
            this.exitAP.TabIndex = 3;
            this.exitAP.Text = "Exit";
            // 
            // apPictureBox
            // 
            this.apPictureBox.Location = new System.Drawing.Point(17, 53);
            this.apPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.apPictureBox.Name = "apPictureBox";
            this.apPictureBox.Size = new System.Drawing.Size(410, 95);
            this.apPictureBox.TabIndex = 2;
            this.apPictureBox.TabStop = false;
            // 
            // visitorLabelAP
            // 
            this.visitorLabelAP.AutoSize = true;
            this.visitorLabelAP.Location = new System.Drawing.Point(99, 25);
            this.visitorLabelAP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitorLabelAP.Name = "visitorLabelAP";
            this.visitorLabelAP.Size = new System.Drawing.Size(43, 13);
            this.visitorLabelAP.TabIndex = 1;
            this.visitorLabelAP.Text = "Visitors:";
            // 
            // limitLabelAP
            // 
            this.limitLabelAP.AutoSize = true;
            this.limitLabelAP.Location = new System.Drawing.Point(15, 25);
            this.limitLabelAP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limitLabelAP.Name = "limitLabelAP";
            this.limitLabelAP.Size = new System.Drawing.Size(46, 13);
            this.limitLabelAP.TabIndex = 0;
            this.limitLabelAP.Text = "Limit: 10";
            // 
            // commonPoolgroupBox
            // 
            this.commonPoolgroupBox.Controls.Add(this.exitCP);
            this.commonPoolgroupBox.Controls.Add(this.cpPictureBox);
            this.commonPoolgroupBox.Controls.Add(this.visitorLabelCP);
            this.commonPoolgroupBox.Controls.Add(this.limitLabelCP);
            this.commonPoolgroupBox.Location = new System.Drawing.Point(408, 288);
            this.commonPoolgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.commonPoolgroupBox.Name = "commonPoolgroupBox";
            this.commonPoolgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.commonPoolgroupBox.Size = new System.Drawing.Size(615, 169);
            this.commonPoolgroupBox.TabIndex = 2;
            this.commonPoolgroupBox.TabStop = false;
            this.commonPoolgroupBox.Text = "Common Pool";
            // 
            // exitCP
            // 
            this.exitCP.AutoSize = true;
            this.exitCP.Location = new System.Drawing.Point(437, 53);
            this.exitCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitCP.Name = "exitCP";
            this.exitCP.Size = new System.Drawing.Size(24, 13);
            this.exitCP.TabIndex = 4;
            this.exitCP.Text = "Exit";
            // 
            // cpPictureBox
            // 
            this.cpPictureBox.Location = new System.Drawing.Point(17, 53);
            this.cpPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpPictureBox.Name = "cpPictureBox";
            this.cpPictureBox.Size = new System.Drawing.Size(410, 95);
            this.cpPictureBox.TabIndex = 3;
            this.cpPictureBox.TabStop = false;
            // 
            // visitorLabelCP
            // 
            this.visitorLabelCP.AutoSize = true;
            this.visitorLabelCP.Location = new System.Drawing.Point(99, 25);
            this.visitorLabelCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitorLabelCP.Name = "visitorLabelCP";
            this.visitorLabelCP.Size = new System.Drawing.Size(43, 13);
            this.visitorLabelCP.TabIndex = 1;
            this.visitorLabelCP.Text = "Visitors:";
            // 
            // limitLabelCP
            // 
            this.limitLabelCP.AutoSize = true;
            this.limitLabelCP.Location = new System.Drawing.Point(15, 25);
            this.limitLabelCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limitLabelCP.Name = "limitLabelCP";
            this.limitLabelCP.Size = new System.Drawing.Size(46, 13);
            this.limitLabelCP.TabIndex = 0;
            this.limitLabelCP.Text = "Limit: 10";
            // 
            // moveFromCPLabel
            // 
            this.moveFromCPLabel.AutoSize = true;
            this.moveFromCPLabel.Location = new System.Drawing.Point(423, 228);
            this.moveFromCPLabel.Name = "moveFromCPLabel";
            this.moveFromCPLabel.Size = new System.Drawing.Size(13, 13);
            this.moveFromCPLabel.TabIndex = 3;
            this.moveFromCPLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(7, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit application";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 477);
            this.Controls.Add(this.moveFromCPLabel);
            this.Controls.Add(this.commonPoolgroupBox);
            this.Controls.Add(this.adventureGroupBox);
            this.Controls.Add(this.receptionGruopBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.receptionGruopBox.ResumeLayout(false);
            this.receptionGruopBox.PerformLayout();
            this.adventureGroupBox.ResumeLayout(false);
            this.adventureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apPictureBox)).EndInit();
            this.commonPoolgroupBox.ResumeLayout(false);
            this.commonPoolgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox receptionGruopBox;
        private System.Windows.Forms.GroupBox adventureGroupBox;
        private System.Windows.Forms.Label visitorLabelAP;
        private System.Windows.Forms.Label limitLabelAP;
        private System.Windows.Forms.GroupBox commonPoolgroupBox;
        private System.Windows.Forms.Label visitorLabelCP;
        private System.Windows.Forms.Label limitLabelCP;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label waitingCP;
        private System.Windows.Forms.Label waitingAPlable;
        private System.Windows.Forms.Label exitAP;
        private System.Windows.Forms.PictureBox apPictureBox;
        private System.Windows.Forms.Label exitCP;
        private System.Windows.Forms.PictureBox cpPictureBox;
        private System.Windows.Forms.Label wQLabelCP;
        private System.Windows.Forms.Label wQLabelAP;
        private System.Windows.Forms.Label moveFromCPLabel;
        private System.Windows.Forms.Button button1;
    }
}

