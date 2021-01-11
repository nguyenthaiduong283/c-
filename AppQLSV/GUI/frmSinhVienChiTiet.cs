using AppQLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV.GUI
{
    public partial class frmSinhVienChiTiet : Form
    {
        private Student sinhVien;
        /*private object txtNgaySinh;
        private object txtNoiSinh;*/

        public frmSinhVienChiTiet()
        {
            InitializeComponent();
            LoadNameClassroom();
            this.Text = "Thêm mới sinh viên";
        }

        public frmSinhVienChiTiet(Student sinhVien)
        {
            InitializeComponent();
            LoadNameClassroom();
            this.Text = "Chỉnh sửa nhân viên";
            this.sinhVien = sinhVien;
            txtMaSV.Text = this.sinhVien.ID;
            txtHoDem.Text = this.sinhVien.FirstName;
            txtTen.Text = this.sinhVien.LastName;
            //Parse DateTime to String
            DateTime dateOfBirth = (DateTime)this.sinhVien.DateOfBirth;
            String DOBstr = dateOfBirth.ToString();
            txtNgaySInh.Text = DOBstr;
            textBox1.Text = this.sinhVien.PlaceOfBirth;
            txtGioiTinh.Text = this.sinhVien.Gender.ToString();

            var db = new AppQLSVDBContext();
            var lopHoc = db.Classrooms.Where(d => d.ID == this.sinhVien.IDClassroom).FirstOrDefault();
            cboLop.Text = lopHoc.Name;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            var dbc = new AppQLSVDBContext();
            var maSv = txtMaSV.Text;
            var hoDem = txtHoDem.Text;
            var ten = txtTen.Text;
            DateTime ngaySinh = DateTime.Parse(txtNgaySInh.Text);
            var noiSinh = textBox1.Text;
            int gioiTinh = (int)txtGioiTinh.Value;
            var tenLopHoc = cboLop.SelectedValue.ToString();
            /*if(lopHoc == null)
            {
                MessageBox.Show("Không có lớp học này!");
            } else 
            { */
            var maSvDuplicate = dbc.Students.Where(t => t.ID == maSv).FirstOrDefault();
                if (sinhVien == null)
                {
                    if(maSvDuplicate == null)
                    {
                        var student = new Student
                        {
                            ID = maSv,
                            FirstName = hoDem,
                            LastName = ten,
                            DateOfBirth = ngaySinh,
                            PlaceOfBirth = noiSinh,
                            Gender = gioiTinh,
                            IDClassroom = tenLopHoc
                        };
                        AppQLSVDBContext db = new AppQLSVDBContext();
                        db.Students.Add(student);
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    } else
                    {
                        MessageBox.Show("Mã sinh viên đã bị trùng!");
                    }
                    // Thêm mới sinh viên

                }
                else
                {
                    var db = new AppQLSVDBContext();
                    var sv = db.Students.Where(c => c.ID == sinhVien.ID).FirstOrDefault(); // Truy xuất sinh viên đang chọn dưới DB
                    sv.ID = maSv; // chỉnh sửa id ở DB thành txtMaSV
                    sv.FirstName = hoDem;
                    sv.LastName = ten;
                    sv.DateOfBirth = ngaySinh;
                    sv.PlaceOfBirth = noiSinh;
                    sv.Gender = gioiTinh;
                    sv.IDClassroom = tenLopHoc;
                    // Lưu dữ liệu xuống DB
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            /*}*/
        }



        private void domainLopHoc_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        List<Classroom> listTenLop;
        void LoadNameClassroom()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            listTenLop = db.Classrooms.OrderBy(t => t.Name).ToList();
            bdsTenLop.DataSource = listTenLop;
            cboLop.DataSource = bdsTenLop;
            cboLop.DisplayMember = "Name";
        }
    }
}
