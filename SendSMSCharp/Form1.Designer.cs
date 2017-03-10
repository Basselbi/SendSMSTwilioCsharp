namespace SendSMSCharp
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
            this.sendMsg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.twilioSSIDBox = new System.Windows.Forms.TextBox();
            this.twilioTokenBox = new System.Windows.Forms.TextBox();
            this.twilioNumberBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.msgBOX = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(94, 238);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(75, 23);
            this.sendMsg.TabIndex = 0;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twilio SSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Twilio Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Twilio Number";
            // 
            // twilioSSIDBox
            // 
            this.twilioSSIDBox.Location = new System.Drawing.Point(94, 80);
            this.twilioSSIDBox.Name = "twilioSSIDBox";
            this.twilioSSIDBox.Size = new System.Drawing.Size(100, 20);
            this.twilioSSIDBox.TabIndex = 4;
            this.twilioSSIDBox.Text = "ACd0dfdee5cbece2e6b4226715cc1b7312";
            // 
            // twilioTokenBox
            // 
            this.twilioTokenBox.Location = new System.Drawing.Point(94, 112);
            this.twilioTokenBox.Name = "twilioTokenBox";
            this.twilioTokenBox.Size = new System.Drawing.Size(100, 20);
            this.twilioTokenBox.TabIndex = 5;
            this.twilioTokenBox.Text = "f3ddb423d44f0158ffdf245d0f865c47";
            // 
            // twilioNumberBox
            // 
            this.twilioNumberBox.Location = new System.Drawing.Point(94, 140);
            this.twilioNumberBox.Name = "twilioNumberBox";
            this.twilioNumberBox.Size = new System.Drawing.Size(100, 20);
            this.twilioNumberBox.TabIndex = 6;
            this.twilioNumberBox.Text = "+19022004649";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Upload Excel File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // msgBOX
            // 
            this.msgBOX.AcceptsTab = true;
            this.msgBOX.Location = new System.Drawing.Point(245, 12);
            this.msgBOX.Multiline = true;
            this.msgBOX.Name = "msgBOX";
            this.msgBOX.Size = new System.Drawing.Size(183, 301);
            this.msgBOX.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 343);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.msgBOX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.twilioNumberBox);
            this.Controls.Add(this.twilioTokenBox);
            this.Controls.Add(this.twilioSSIDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox twilioSSIDBox;
        private System.Windows.Forms.TextBox twilioTokenBox;
        private System.Windows.Forms.TextBox twilioNumberBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox msgBOX;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

