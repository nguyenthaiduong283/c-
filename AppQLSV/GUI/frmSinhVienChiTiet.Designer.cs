namespace AppQLSV.GUI
{
    partial class frmSinhVienChiTiet
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNgaySInh = new System.Windows.Forms.DateTimePicker();
            this.txtGioiTinh = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVNhom1DataSet = new AppQLSV.QLSVNhom1DataSet();
            this.classroomTableAdapter = new AppQLSV.QLSVNhom1DataSetTableAdapters.ClassroomTableAdapter();
            this.bdsTenLop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ đệm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nơi sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giới tính";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(114, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(137, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtHoDem
            // 
            this.txtHoDem.Location = new System.Drawing.Point(114, 68);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(137, 20);
            this.txtHoDem.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(416, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(143, 20);
            this.txtTen.TabIndex = 4;
            // 
            // txtNgaySInh
            // 
            this.txtNgaySInh.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.txtNgaySInh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySInh.Location = new System.Drawing.Point(114, 110);
            this.txtNgaySInh.Name = "txtNgaySInh";
            this.txtNgaySInh.Size = new System.Drawing.Size(213, 20);
            this.txtNgaySInh.TabIndex = 5;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(114, 224);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(45, 20);
            this.txtGioiTinh.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(355, 261);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(460, 261);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 55);
            this.textBox1.TabIndex = 6;
            // 
            // cboLop
            // 
            this.cboLop.DataSource = this.classroomBindingSource;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(416, 21);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(143, 21);
            this.cboLop.TabIndex = 2;
            this.cboLop.ValueMember = "ID";
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataMember = "Classroom";
            this.classroomBindingSource.DataSource = this.qLSVNhom1DataSet;
            // 
            // qLSVNhom1DataSet
            // 
            this.qLSVNhom1DataSet.DataSetName = "QLSVNhom1DataSet";
            this.qLSVNhom1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomTableAdapter
            // 
            this.classroomTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinhVienChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 307);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtNgaySInh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVienChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker txtNgaySInh;
        private System.Windows.Forms.NumericUpDown txtGioiTinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboLop;
        private QLSVNhom1DataSet qLSVNhom1DataSet;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private QLSVNhom1DataSetTableAdapters.ClassroomTableAdapter classroomTableAdapter;
        private System.Windows.Forms.BindingSource bdsTenLop;
    }
}