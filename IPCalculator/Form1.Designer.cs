
namespace IPCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputIP = new System.Windows.Forms.TextBox();
            this.inputPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIPBinary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetzmaske = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ipNumbs = new System.Windows.Forms.TextBox();
            this.nutzbareIp = new System.Windows.Forms.TextBox();
            this.ipsLbl = new System.Windows.Forms.Label();
            this.nutzbareIps = new System.Windows.Forms.Label();
            this.txtBroadcast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bxNetId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstIp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastIp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(49, 51);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(120, 22);
            this.inputIP.TabIndex = 0;
            // 
            // inputPrefix
            // 
            this.inputPrefix.Location = new System.Drawing.Point(202, 51);
            this.inputPrefix.Name = "inputPrefix";
            this.inputPrefix.Size = new System.Drawing.Size(31, 22);
            this.inputPrefix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(600, 51);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "OK";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Addresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CIDR";
            // 
            // lblIPBinary
            // 
            this.lblIPBinary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIPBinary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIPBinary.Location = new System.Drawing.Point(272, 51);
            this.lblIPBinary.Name = "lblIPBinary";
            this.lblIPBinary.Size = new System.Drawing.Size(307, 23);
            this.lblIPBinary.TabIndex = 6;
            this.lblIPBinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP Binary";
            // 
            // txtNetzmaske
            // 
            this.txtNetzmaske.Location = new System.Drawing.Point(49, 129);
            this.txtNetzmaske.Name = "txtNetzmaske";
            this.txtNetzmaske.ReadOnly = true;
            this.txtNetzmaske.Size = new System.Drawing.Size(120, 22);
            this.txtNetzmaske.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Netzmaske";
            // 
            // ipNumbs
            // 
            this.ipNumbs.Location = new System.Drawing.Point(210, 129);
            this.ipNumbs.Name = "ipNumbs";
            this.ipNumbs.ReadOnly = true;
            this.ipNumbs.Size = new System.Drawing.Size(120, 22);
            this.ipNumbs.TabIndex = 10;
            // 
            // nutzbareIp
            // 
            this.nutzbareIp.Location = new System.Drawing.Point(378, 129);
            this.nutzbareIp.Name = "nutzbareIp";
            this.nutzbareIp.ReadOnly = true;
            this.nutzbareIp.Size = new System.Drawing.Size(120, 22);
            this.nutzbareIp.TabIndex = 11;
            // 
            // ipsLbl
            // 
            this.ipsLbl.AutoSize = true;
            this.ipsLbl.Location = new System.Drawing.Point(207, 95);
            this.ipsLbl.Name = "ipsLbl";
            this.ipsLbl.Size = new System.Drawing.Size(26, 17);
            this.ipsLbl.TabIndex = 12;
            this.ipsLbl.Text = "Ips";
            // 
            // nutzbareIps
            // 
            this.nutzbareIps.AutoSize = true;
            this.nutzbareIps.Location = new System.Drawing.Point(375, 95);
            this.nutzbareIps.Name = "nutzbareIps";
            this.nutzbareIps.Size = new System.Drawing.Size(88, 17);
            this.nutzbareIps.TabIndex = 13;
            this.nutzbareIps.Text = "Nutzbare Ips";
            // 
            // txtBroadcast
            // 
            this.txtBroadcast.Location = new System.Drawing.Point(210, 195);
            this.txtBroadcast.Name = "txtBroadcast";
            this.txtBroadcast.ReadOnly = true;
            this.txtBroadcast.Size = new System.Drawing.Size(120, 22);
            this.txtBroadcast.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Broadcast";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "NetID";
            // 
            // bxNetId
            // 
            this.bxNetId.Location = new System.Drawing.Point(49, 195);
            this.bxNetId.Name = "bxNetId";
            this.bxNetId.ReadOnly = true;
            this.bxNetId.Size = new System.Drawing.Size(120, 22);
            this.bxNetId.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fist Ip";
            // 
            // txtFirstIp
            // 
            this.txtFirstIp.Location = new System.Drawing.Point(378, 195);
            this.txtFirstIp.Name = "txtFirstIp";
            this.txtFirstIp.ReadOnly = true;
            this.txtFirstIp.Size = new System.Drawing.Size(120, 22);
            this.txtFirstIp.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Last Ip";
            // 
            // txtLastIp
            // 
            this.txtLastIp.Location = new System.Drawing.Point(555, 195);
            this.txtLastIp.Name = "txtLastIp";
            this.txtLastIp.ReadOnly = true;
            this.txtLastIp.Size = new System.Drawing.Size(120, 22);
            this.txtLastIp.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 273);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLastIp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFirstIp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bxNetId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBroadcast);
            this.Controls.Add(this.nutzbareIps);
            this.Controls.Add(this.ipsLbl);
            this.Controls.Add(this.nutzbareIp);
            this.Controls.Add(this.ipNumbs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNetzmaske);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIPBinary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPrefix);
            this.Controls.Add(this.inputIP);
            this.Name = "Form1";
            this.Text = "Ip Rechener 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.TextBox inputPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIPBinary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetzmaske;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ipNumbs;
        private System.Windows.Forms.TextBox nutzbareIp;
        private System.Windows.Forms.Label ipsLbl;
        private System.Windows.Forms.Label nutzbareIps;
        private System.Windows.Forms.TextBox txtBroadcast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bxNetId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstIp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastIp;
    }
}

