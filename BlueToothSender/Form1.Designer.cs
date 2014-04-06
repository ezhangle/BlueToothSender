namespace WindowsFormsApplication1
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
            this.ComPortTxt = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectTxt = new System.Windows.Forms.TextBox();
            this.DataTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DataBitsCMB = new System.Windows.Forms.ComboBox();
            this.StopBitsCMB = new System.Windows.Forms.ComboBox();
            this.ParityCMB = new System.Windows.Forms.ComboBox();
            this.BaudRateCMB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ComPortTxt
            // 
            this.ComPortTxt.BackColor = System.Drawing.Color.White;
            this.ComPortTxt.Location = new System.Drawing.Point(12, 230);
            this.ComPortTxt.Name = "ComPortTxt";
            this.ComPortTxt.Size = new System.Drawing.Size(100, 20);
            this.ComPortTxt.TabIndex = 0;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(152, 230);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(111, 23);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send Message";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Structure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data To Send";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // SubjectTxt
            // 
            this.SubjectTxt.Location = new System.Drawing.Point(134, 26);
            this.SubjectTxt.Name = "SubjectTxt";
            this.SubjectTxt.Size = new System.Drawing.Size(100, 20);
            this.SubjectTxt.TabIndex = 6;
            // 
            // DataTxt
            // 
            this.DataTxt.Location = new System.Drawing.Point(134, 53);
            this.DataTxt.Name = "DataTxt";
            this.DataTxt.Size = new System.Drawing.Size(100, 20);
            this.DataTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OutGoing Com Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "BaudRate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "DataBits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "StopBits";
            // 
            // DataBitsCMB
            // 
            this.DataBitsCMB.FormattingEnabled = true;
            this.DataBitsCMB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBitsCMB.Location = new System.Drawing.Point(134, 140);
            this.DataBitsCMB.Name = "DataBitsCMB";
            this.DataBitsCMB.Size = new System.Drawing.Size(121, 21);
            this.DataBitsCMB.TabIndex = 13;
            // 
            // StopBitsCMB
            // 
            this.StopBitsCMB.FormattingEnabled = true;
            this.StopBitsCMB.Location = new System.Drawing.Point(134, 167);
            this.StopBitsCMB.Name = "StopBitsCMB";
            this.StopBitsCMB.Size = new System.Drawing.Size(121, 21);
            this.StopBitsCMB.TabIndex = 14;
            // 
            // ParityCMB
            // 
            this.ParityCMB.FormattingEnabled = true;
            this.ParityCMB.Location = new System.Drawing.Point(134, 110);
            this.ParityCMB.Name = "ParityCMB";
            this.ParityCMB.Size = new System.Drawing.Size(121, 21);
            this.ParityCMB.TabIndex = 15;
            // 
            // BaudRateCMB
            // 
            this.BaudRateCMB.FormattingEnabled = true;
            this.BaudRateCMB.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BaudRateCMB.Location = new System.Drawing.Point(134, 79);
            this.BaudRateCMB.Name = "BaudRateCMB";
            this.BaudRateCMB.Size = new System.Drawing.Size(121, 21);
            this.BaudRateCMB.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BaudRateCMB);
            this.Controls.Add(this.ParityCMB);
            this.Controls.Add(this.StopBitsCMB);
            this.Controls.Add(this.DataBitsCMB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataTxt);
            this.Controls.Add(this.SubjectTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.ComPortTxt);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ComPortTxt;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubjectTxt;
        private System.Windows.Forms.TextBox DataTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox DataBitsCMB;
        private System.Windows.Forms.ComboBox StopBitsCMB;
        private System.Windows.Forms.ComboBox ParityCMB;
        private System.Windows.Forms.ComboBox BaudRateCMB;
    }
}

