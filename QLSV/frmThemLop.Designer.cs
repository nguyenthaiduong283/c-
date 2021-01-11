namespace QLSV
{
    partial class frmThemLop
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
            this.txtTenlop = new System.Windows.Forms.Label();
            this.txtPhonghoc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenlop
            // 
            this.txtTenlop.AutoSize = true;
            this.txtTenlop.Location = new System.Drawing.Point(132, 27);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(47, 13);
            this.txtTenlop.TabIndex = 0;
            this.txtTenlop.Text = "Tên Lớp";
            // 
            // txtPhonghoc
            // 
            this.txtPhonghoc.AutoSize = true;
            this.txtPhonghoc.Location = new System.Drawing.Point(135, 62);
            this.txtPhonghoc.Name = "txtPhonghoc";
            this.txtPhonghoc.Size = new System.Drawing.Size(59, 13);
            this.txtPhonghoc.TabIndex = 1;
            this.txtPhonghoc.Text = "Phòng học";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPhonghoc);
            this.Controls.Add(this.txtTenlop);
            this.Name = "frmThemLop";
            this.Text = "frmThemLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTenlop;
        private System.Windows.Forms.Label txtPhonghoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}