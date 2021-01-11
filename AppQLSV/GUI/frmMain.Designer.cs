namespace AppQLSV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridlophoc = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoalop = new System.Windows.Forms.ToolStripButton();
            this.btnsualop = new System.Windows.Forms.ToolStripButton();
            this.btnthemlop = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridSinhVien = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaSV = new System.Windows.Forms.ToolStripButton();
            this.btnSuaSV = new System.Windows.Forms.ToolStripButton();
            this.btnThemSv = new System.Windows.Forms.ToolStripButton();
            this.bdsLopHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridlophoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridlophoc);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 450);
            this.panel1.TabIndex = 0;
            // 
            // gridlophoc
            // 
            this.gridlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column2});
            this.gridlophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridlophoc.Location = new System.Drawing.Point(0, 25);
            this.gridlophoc.Name = "gridlophoc";
            this.gridlophoc.Size = new System.Drawing.Size(368, 425);
            this.gridlophoc.TabIndex = 0;
            this.gridlophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridlophoc_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnxoalop,
            this.btnsualop,
            this.btnthemlop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(368, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "Danh Sách Lớp Học";
            // 
            // btnxoalop
            // 
            this.btnxoalop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnxoalop.Image = ((System.Drawing.Image)(resources.GetObject("btnxoalop.Image")));
            this.btnxoalop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoalop.Name = "btnxoalop";
            this.btnxoalop.Size = new System.Drawing.Size(47, 22);
            this.btnxoalop.Text = "Xóa";
            this.btnxoalop.Click += new System.EventHandler(this.btnxoalop_Click);
            // 
            // btnsualop
            // 
            this.btnsualop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsualop.Image = ((System.Drawing.Image)(resources.GetObject("btnsualop.Image")));
            this.btnsualop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsualop.Name = "btnsualop";
            this.btnsualop.Size = new System.Drawing.Size(46, 22);
            this.btnsualop.Text = "Sửa";
            this.btnsualop.Click += new System.EventHandler(this.btnsualop_Click);
            // 
            // btnthemlop
            // 
            this.btnthemlop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnthemlop.Image = ((System.Drawing.Image)(resources.GetObject("btnthemlop.Image")));
            this.btnthemlop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemlop.Name = "btnthemlop";
            this.btnthemlop.Size = new System.Drawing.Size(58, 22);
            this.btnthemlop.Text = "Thêm";
            this.btnthemlop.Click += new System.EventHandler(this.btnthemlop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridSinhVien);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(368, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 450);
            this.panel2.TabIndex = 1;
            // 
            // gridSinhVien
            // 
            this.gridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gridSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSinhVien.Location = new System.Drawing.Point(0, 25);
            this.gridSinhVien.Name = "gridSinhVien";
            this.gridSinhVien.Size = new System.Drawing.Size(690, 425);
            this.gridSinhVien.TabIndex = 0;
            this.gridSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSinhVien_CellContentClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnXoaSV,
            this.btnSuaSV,
            this.btnThemSv});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(690, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabel2.Text = "Danh Sách Sinh Viên";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.Image")));
            this.btnXoaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(47, 22);
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSV.Image")));
            this.btnSuaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(46, 22);
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnThemSv
            // 
            this.btnThemSv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemSv.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSv.Image")));
            this.btnThemSv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSv.Name = "btnThemSv";
            this.btnThemSv.Size = new System.Drawing.Size(58, 22);
            this.btnThemSv.Text = "Thêm";
            this.btnThemSv.Click += new System.EventHandler(this.btnThemSv_Click);
            // 
            // bdsLopHoc
            // 
            this.bdsLopHoc.CurrentChanged += new System.EventHandler(this.bdsLopHoc_CurrentChanged);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.CurrentChanged += new System.EventHandler(this.bdsSinhVien_CurrentChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên Lớp";
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "TotalStudent";
            this.Column9.HeaderText = "TSSV";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "TotalMale";
            this.Column10.HeaderText = "TSSV Nam";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "TotalFemale";
            this.Column11.HeaderText = "TSSV Nữ";
            this.Column11.Name = "Column11";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Room";
            this.Column2.HeaderText = "Phòng Học";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ID";
            this.Column3.HeaderText = "Mã Sinh Viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "FullName";
            this.Column4.HeaderText = "Họ Tên";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "DateOfBirth";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "PlaceOfBirth";
            this.Column7.HeaderText = "Nơi Sinh";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "GenderString";
            this.Column8.HeaderText = "Giới Tính";
            this.Column8.Name = "Column8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridlophoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridlophoc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnxoalop;
        private System.Windows.Forms.ToolStripButton btnsualop;
        private System.Windows.Forms.ToolStripButton btnthemlop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridSinhVien;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnXoaSV;
        private System.Windows.Forms.ToolStripButton btnSuaSV;
        private System.Windows.Forms.ToolStripButton btnThemSv;
        private System.Windows.Forms.BindingSource bdsLopHoc;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

