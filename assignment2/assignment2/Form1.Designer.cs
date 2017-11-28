namespace assignment2
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
            this.listBoxWrite = new System.Windows.Forms.ListBox();
            this.listBoxRead = new System.Windows.Forms.ListBox();
            this.StringToEnter = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.stringtotransfer = new System.Windows.Forms.Label();
            this.SynchronizedMode = new System.Windows.Forms.CheckBox();
            this.AsynchronizedMode = new System.Windows.Forms.CheckBox();
            this.RunningStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.RecivedString = new System.Windows.Forms.Label();
            this.TransmittedString = new System.Windows.Forms.Label();
            this.syncMode = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RunningStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWrite
            // 
            this.listBoxWrite.FormattingEnabled = true;
            this.listBoxWrite.Location = new System.Drawing.Point(27, 36);
            this.listBoxWrite.Name = "listBoxWrite";
            this.listBoxWrite.Size = new System.Drawing.Size(193, 589);
            this.listBoxWrite.TabIndex = 0;
            // 
            // listBoxRead
            // 
            this.listBoxRead.FormattingEnabled = true;
            this.listBoxRead.Location = new System.Drawing.Point(642, 36);
            this.listBoxRead.Name = "listBoxRead";
            this.listBoxRead.Size = new System.Drawing.Size(193, 589);
            this.listBoxRead.TabIndex = 1;
            // 
            // StringToEnter
            // 
            this.StringToEnter.Location = new System.Drawing.Point(297, 272);
            this.StringToEnter.Name = "StringToEnter";
            this.StringToEnter.Size = new System.Drawing.Size(268, 20);
            this.StringToEnter.TabIndex = 2;
            this.StringToEnter.TextChanged += new System.EventHandler(this.StringToEnter_TextChanged);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(297, 298);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(84, 27);
            this.Run.TabIndex = 3;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // stringtotransfer
            // 
            this.stringtotransfer.AutoSize = true;
            this.stringtotransfer.Location = new System.Drawing.Point(391, 256);
            this.stringtotransfer.Name = "stringtotransfer";
            this.stringtotransfer.Size = new System.Drawing.Size(84, 13);
            this.stringtotransfer.TabIndex = 4;
            this.stringtotransfer.Text = "String to transfer";
            //this.stringtotransfer.Click += new System.EventHandler(this.label1_Click);
            // 
            // SynchronizedMode
            // 
            this.SynchronizedMode.AutoSize = true;
            this.SynchronizedMode.Location = new System.Drawing.Point(297, 175);
            this.SynchronizedMode.Name = "SynchronizedMode";
            this.SynchronizedMode.Size = new System.Drawing.Size(120, 17);
            this.SynchronizedMode.TabIndex = 5;
            this.SynchronizedMode.Text = "Synchronized Mode";
            this.SynchronizedMode.UseVisualStyleBackColor = true;
            this.SynchronizedMode.CheckedChanged += new System.EventHandler(this.SynchronizedMode_CheckedChanged);
            // 
            // AsynchronizedMode
            // 
            this.AsynchronizedMode.AutoSize = true;
            this.AsynchronizedMode.Location = new System.Drawing.Point(297, 198);
            this.AsynchronizedMode.Name = "AsynchronizedMode";
            this.AsynchronizedMode.Size = new System.Drawing.Size(125, 17);
            this.AsynchronizedMode.TabIndex = 6;
            this.AsynchronizedMode.Text = "Asynchronized Mode";
            this.AsynchronizedMode.UseVisualStyleBackColor = true;
            this.AsynchronizedMode.CheckedChanged += new System.EventHandler(this.AsynchronizedMode_CheckedChanged);
            // 
            // RunningStatus
            // 
            this.RunningStatus.Location = new System.Drawing.Point(297, 414);
            this.RunningStatus.Name = "RunningStatus";
            this.RunningStatus.Size = new System.Drawing.Size(147, 88);
            this.RunningStatus.TabIndex = 7;
            this.RunningStatus.TabStop = false;
            this.RunningStatus.Click += new System.EventHandler(this.RunningStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Running Status";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(297, 508);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(91, 40);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RecivedString
            // 
            this.RecivedString.AutoSize = true;
            this.RecivedString.Location = new System.Drawing.Point(639, 628);
            this.RecivedString.Name = "RecivedString";
            this.RecivedString.Size = new System.Drawing.Size(77, 13);
            this.RecivedString.TabIndex = 10;
            this.RecivedString.Text = "Recived String";
            // 
            // TransmittedString
            // 
            this.TransmittedString.AutoSize = true;
            this.TransmittedString.Location = new System.Drawing.Point(24, 628);
            this.TransmittedString.Name = "TransmittedString";
            this.TransmittedString.Size = new System.Drawing.Size(92, 13);
            this.TransmittedString.TabIndex = 11;
            this.TransmittedString.Text = "Transmitted String";
            ///this.TransmittedString.Click += new System.EventHandler(this.TransmittedString_Click);
            // 
            // syncMode
            // 
            this.syncMode.AutoSize = true;
            this.syncMode.Location = new System.Drawing.Point(391, 305);
            this.syncMode.Name = "syncMode";
            this.syncMode.Size = new System.Drawing.Size(35, 13);
            this.syncMode.TabIndex = 12;
            this.syncMode.Text = "label2";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(450, 414);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 680);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.syncMode);
            this.Controls.Add(this.TransmittedString);
            this.Controls.Add(this.RecivedString);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunningStatus);
            this.Controls.Add(this.AsynchronizedMode);
            this.Controls.Add(this.SynchronizedMode);
            this.Controls.Add(this.stringtotransfer);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.StringToEnter);
            this.Controls.Add(this.listBoxRead);
            this.Controls.Add(this.listBoxWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RunningStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWrite;
        private System.Windows.Forms.ListBox listBoxRead;
        private System.Windows.Forms.TextBox StringToEnter;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label stringtotransfer;
        private System.Windows.Forms.CheckBox SynchronizedMode;
        private System.Windows.Forms.CheckBox AsynchronizedMode;
        private System.Windows.Forms.PictureBox RunningStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label RecivedString;
        private System.Windows.Forms.Label TransmittedString;
        private System.Windows.Forms.Label syncMode;
        private System.Windows.Forms.Label resultLabel;
    }
}

