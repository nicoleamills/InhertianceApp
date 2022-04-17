namespace InhertianceApp
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpNum = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(348, 134);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 0;
            this.txtEmpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(205, 134);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(84, 13);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name";
            this.lblEmpName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmpNum
            // 
            this.lblEmpNum.AutoSize = true;
            this.lblEmpNum.Location = new System.Drawing.Point(208, 174);
            this.lblEmpNum.Name = "lblEmpNum";
            this.lblEmpNum.Size = new System.Drawing.Size(96, 13);
            this.lblEmpNum.TabIndex = 2;
            this.lblEmpNum.Text = "Employee Number:";
            this.lblEmpNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(208, 214);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(31, 13);
            this.lblShift.TabIndex = 3;
            this.lblShift.Text = "Shift:";
            this.lblShift.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(208, 255);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(54, 13);
            this.lblPayRate.TabIndex = 4;
            this.lblPayRate.Text = "Pay Rate:";
            this.lblPayRate.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Location = new System.Drawing.Point(348, 174);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(100, 20);
            this.txtEmpNum.TabIndex = 5;
            this.txtEmpNum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(348, 214);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 20);
            this.txtShift.TabIndex = 6;
            this.txtShift.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(348, 255);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtPayRate.TabIndex = 7;
            this.txtPayRate.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(348, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblEmpNum);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpNum;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Button btnSubmit;
    }
}

