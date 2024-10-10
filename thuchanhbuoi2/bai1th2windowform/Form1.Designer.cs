namespace bai1th2windowform
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
            this.txthoanhdo = new System.Windows.Forms.TextBox();
            this.txttungdo = new System.Windows.Forms.TextBox();
            this.txtToado = new System.Windows.Forms.TextBox();
            this.txtcaodo = new System.Windows.Forms.TextBox();
            this.thucthi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txthoanhdo
            // 
            this.txthoanhdo.Location = new System.Drawing.Point(364, 75);
            this.txthoanhdo.Name = "txthoanhdo";
            this.txthoanhdo.Size = new System.Drawing.Size(292, 22);
            this.txthoanhdo.TabIndex = 0;
            this.txthoanhdo.Text = "2";
            this.txthoanhdo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txttungdo
            // 
            this.txttungdo.Location = new System.Drawing.Point(365, 121);
            this.txttungdo.Name = "txttungdo";
            this.txttungdo.Size = new System.Drawing.Size(292, 22);
            this.txttungdo.TabIndex = 0;
            this.txttungdo.Text = "3";
            // 
            // txtToado
            // 
            this.txtToado.Location = new System.Drawing.Point(364, 226);
            this.txtToado.Name = "txtToado";
            this.txtToado.Size = new System.Drawing.Size(292, 22);
            this.txtToado.TabIndex = 0;
            // 
            // txtcaodo
            // 
            this.txtcaodo.Location = new System.Drawing.Point(365, 177);
            this.txtcaodo.Name = "txtcaodo";
            this.txtcaodo.Size = new System.Drawing.Size(292, 22);
            this.txtcaodo.TabIndex = 0;
            this.txtcaodo.Text = "2";
            // 
            // thucthi
            // 
            this.thucthi.Location = new System.Drawing.Point(389, 295);
            this.thucthi.Name = "thucthi";
            this.thucthi.Size = new System.Drawing.Size(75, 23);
            this.thucthi.TabIndex = 1;
            this.thucthi.Text = "thucthi";
            this.thucthi.UseVisualStyleBackColor = true;
            this.thucthi.Click += new System.EventHandler(this.thucthi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "nhaphoanhdo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "nhaptungdo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "nhapcaodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "nhaptoado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thucthi);
            this.Controls.Add(this.txtToado);
            this.Controls.Add(this.txtcaodo);
            this.Controls.Add(this.txttungdo);
            this.Controls.Add(this.txthoanhdo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthoanhdo;
        private System.Windows.Forms.TextBox txttungdo;
        private System.Windows.Forms.TextBox txtToado;
        private System.Windows.Forms.TextBox txtcaodo;
        private System.Windows.Forms.Button thucthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

