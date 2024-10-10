namespace bai4wdf
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
            this.txtTS = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.txtPS1 = new System.Windows.Forms.TextBox();
            this.txtPS2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.rdPS1 = new System.Windows.Forms.RadioButton();
            this.rdPS2 = new System.Windows.Forms.RadioButton();
            this.btNhapPS = new System.Windows.Forms.Button();
            this.btCongPS = new System.Windows.Forms.Button();
            this.btTruPS = new System.Windows.Forms.Button();
            this.btNhanPS = new System.Windows.Forms.Button();
            this.btchiaPS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(134, 45);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(100, 22);
            this.txtTS.TabIndex = 0;
            this.txtTS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(134, 132);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(100, 22);
            this.txtMS.TabIndex = 0;
            this.txtMS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPS1
            // 
            this.txtPS1.Location = new System.Drawing.Point(609, 61);
            this.txtPS1.Name = "txtPS1";
            this.txtPS1.Size = new System.Drawing.Size(100, 22);
            this.txtPS1.TabIndex = 0;
            this.txtPS1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPS2
            // 
            this.txtPS2.Location = new System.Drawing.Point(609, 132);
            this.txtPS2.Name = "txtPS2";
            this.txtPS2.Size = new System.Drawing.Size(100, 22);
            this.txtPS2.TabIndex = 0;
            this.txtPS2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(609, 228);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 22);
            this.txtKQ.TabIndex = 0;
            this.txtKQ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdPS1
            // 
            this.rdPS1.AutoSize = true;
            this.rdPS1.Location = new System.Drawing.Point(107, 216);
            this.rdPS1.Name = "rdPS1";
            this.rdPS1.Size = new System.Drawing.Size(80, 20);
            this.rdPS1.TabIndex = 1;
            this.rdPS1.TabStop = true;
            this.rdPS1.Text = "phanso1";
            this.rdPS1.UseVisualStyleBackColor = true;
            // 
            // rdPS2
            // 
            this.rdPS2.AutoSize = true;
            this.rdPS2.Location = new System.Drawing.Point(263, 216);
            this.rdPS2.Name = "rdPS2";
            this.rdPS2.Size = new System.Drawing.Size(83, 20);
            this.rdPS2.TabIndex = 1;
            this.rdPS2.TabStop = true;
            this.rdPS2.Text = "phanso 2";
            this.rdPS2.UseVisualStyleBackColor = true;
            // 
            // btNhapPS
            // 
            this.btNhapPS.Location = new System.Drawing.Point(202, 308);
            this.btNhapPS.Name = "btNhapPS";
            this.btNhapPS.Size = new System.Drawing.Size(75, 23);
            this.btNhapPS.TabIndex = 2;
            this.btNhapPS.Text = "nhập ";
            this.btNhapPS.UseVisualStyleBackColor = true;
            this.btNhapPS.Click += new System.EventHandler(this.btNhapPS_Click);
            // 
            // btCongPS
            // 
            this.btCongPS.Location = new System.Drawing.Point(91, 341);
            this.btCongPS.Name = "btCongPS";
            this.btCongPS.Size = new System.Drawing.Size(99, 42);
            this.btCongPS.TabIndex = 3;
            this.btCongPS.Text = "Cộng(+)";
            this.btCongPS.UseVisualStyleBackColor = true;
            this.btCongPS.Click += new System.EventHandler(this.btCongPS_Click);
            // 
            // btTruPS
            // 
            this.btTruPS.Location = new System.Drawing.Point(282, 351);
            this.btTruPS.Name = "btTruPS";
            this.btTruPS.Size = new System.Drawing.Size(75, 32);
            this.btTruPS.TabIndex = 4;
            this.btTruPS.Text = "trừ(-)";
            this.btTruPS.UseVisualStyleBackColor = true;
            this.btTruPS.Click += new System.EventHandler(this.btTruPS_Click);
            // 
            // btNhanPS
            // 
            this.btNhanPS.Location = new System.Drawing.Point(502, 351);
            this.btNhanPS.Name = "btNhanPS";
            this.btNhanPS.Size = new System.Drawing.Size(75, 32);
            this.btNhanPS.TabIndex = 5;
            this.btNhanPS.Text = "nhân(*)";
            this.btNhanPS.UseVisualStyleBackColor = true;
            this.btNhanPS.Click += new System.EventHandler(this.btNhanPS_Click);
            // 
            // btchiaPS
            // 
            this.btchiaPS.Location = new System.Drawing.Point(662, 344);
            this.btchiaPS.Name = "btchiaPS";
            this.btchiaPS.Size = new System.Drawing.Size(75, 39);
            this.btchiaPS.TabIndex = 6;
            this.btchiaPS.Text = "chia(/)";
            this.btchiaPS.UseVisualStyleBackColor = true;
            this.btchiaPS.Click += new System.EventHandler(this.btchiaPS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "nhap tu so:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "nhap mau so";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "phan so 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "phanso 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "ketqua";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btchiaPS);
            this.Controls.Add(this.btNhanPS);
            this.Controls.Add(this.btTruPS);
            this.Controls.Add(this.btCongPS);
            this.Controls.Add(this.btNhapPS);
            this.Controls.Add(this.rdPS2);
            this.Controls.Add(this.rdPS1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtPS2);
            this.Controls.Add(this.txtPS1);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.txtTS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.TextBox txtPS1;
        private System.Windows.Forms.TextBox txtPS2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.RadioButton rdPS1;
        private System.Windows.Forms.RadioButton rdPS2;
        private System.Windows.Forms.Button btNhapPS;
        private System.Windows.Forms.Button btCongPS;
        private System.Windows.Forms.Button btTruPS;
        private System.Windows.Forms.Button btNhanPS;
        private System.Windows.Forms.Button btchiaPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

