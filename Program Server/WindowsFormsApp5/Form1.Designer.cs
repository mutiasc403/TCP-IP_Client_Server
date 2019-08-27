namespace WindowsFormsApp5
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
            this.lblPORT = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.txtkirim = new System.Windows.Forms.TextBox();
            this.btnkirim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPORT
            // 
            this.lblPORT.AutoSize = true;
            this.lblPORT.Location = new System.Drawing.Point(17, 52);
            this.lblPORT.Name = "lblPORT";
            this.lblPORT.Size = new System.Drawing.Size(37, 13);
            this.lblPORT.TabIndex = 0;
            this.lblPORT.Text = "PORT";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(168, 48);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(82, 23);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open Port";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click_1);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(60, 49);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(100, 20);
            this.txtport.TabIndex = 2;
            this.txtport.TextChanged += new System.EventHandler(this.txtport_TextChanged);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.TxtStatus.Location = new System.Drawing.Point(270, 12);
            this.TxtStatus.Multiline = true;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(150, 260);
            this.TxtStatus.TabIndex = 3;
            this.TxtStatus.Text = "(Message from client)";
            // 
            // txtkirim
            // 
            this.txtkirim.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkirim.Location = new System.Drawing.Point(20, 78);
            this.txtkirim.Multiline = true;
            this.txtkirim.Name = "txtkirim";
            this.txtkirim.Size = new System.Drawing.Size(230, 163);
            this.txtkirim.TabIndex = 4;
            this.txtkirim.Text = "(Type here...)";
            // 
            // btnkirim
            // 
            this.btnkirim.Location = new System.Drawing.Point(96, 249);
            this.btnkirim.Name = "btnkirim";
            this.btnkirim.Size = new System.Drawing.Size(75, 23);
            this.btnkirim.TabIndex = 5;
            this.btnkirim.Text = "Send";
            this.btnkirim.UseVisualStyleBackColor = true;
            this.btnkirim.Click += new System.EventHandler(this.btnkirim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "SERVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkirim);
            this.Controls.Add(this.txtkirim);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.lblPORT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPORT;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox txtkirim;
        private System.Windows.Forms.Button btnkirim;
        private System.Windows.Forms.Label label1;
    }
}

