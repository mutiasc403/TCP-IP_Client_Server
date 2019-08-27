namespace WindowsFormsApp2
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
            this.Conn = new System.Windows.Forms.Button();
            this.Disc = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Conn
            // 
            this.Conn.Location = new System.Drawing.Point(68, 91);
            this.Conn.Name = "Conn";
            this.Conn.Size = new System.Drawing.Size(75, 23);
            this.Conn.TabIndex = 0;
            this.Conn.Text = "Connect";
            this.Conn.UseVisualStyleBackColor = true;
            this.Conn.Click += new System.EventHandler(this.Conn_Click);
            // 
            // Disc
            // 
            this.Disc.Location = new System.Drawing.Point(152, 91);
            this.Disc.Name = "Disc";
            this.Disc.Size = new System.Drawing.Size(75, 23);
            this.Disc.TabIndex = 1;
            this.Disc.Text = "Disconnect";
            this.Disc.UseVisualStyleBackColor = true;
            this.Disc.Click += new System.EventHandler(this.Disc_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(92, 287);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(21, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 161);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "(Type here...)";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtIp
            // 
            this.TxtIp.Location = new System.Drawing.Point(58, 42);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(179, 20);
            this.TxtIp.TabIndex = 5;
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(58, 66);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(179, 20);
            this.TxtPort.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.TxtStatus.Location = new System.Drawing.Point(256, 13);
            this.TxtStatus.Multiline = true;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(153, 297);
            this.TxtStatus.TabIndex = 9;
            this.TxtStatus.Text = "(Message from server)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(89, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "CLIENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtIp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Disc);
            this.Controls.Add(this.Conn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conn;
        private System.Windows.Forms.Button Disc;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label label4;
    }
}

