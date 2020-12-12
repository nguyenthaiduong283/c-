using AppQLSV.DAL;
using AppQLSV.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridlophoc.AutoGenerateColumns = false;
            gridSinhVien.AutoGenerateColumns = false;
            LoadDanhSachLopHoc();
            LoadDanhSachSinhVien();
        }

        private void LoadDanhSachLopHoc()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            var ls = db.Classrooms.OrderBy(e => e.Name).ToList();
            bdsLopHoc.DataSource = ls;
            gridlophoc.DataSource = bdsLopHoc;
        }
        void LoadDanhSachSinhVien()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            var ls = db.Students.ToList();
            bdsSinhVien.DataSource = ls;
            gridSinhVien.DataSource = bdsSinhVien;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnthemlop_Click(object sender, EventArgs e)
        {
            var f = new frmLopchitiet();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachLopHoc();
            }
        }

        private void btnxoalop_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as Classroom;
            if (lopDangChon != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "chú ý"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //Xóa lớp đang chọn
                    var db = new AppQLSVDBContext();
                    var lop = db.Classrooms.Where(t => t.ID == lopDangChon.ID).FirstOrDefault();
                    if (lop != null)
                    {
                        db.Classrooms.Remove(lop);
                        db.SaveChanges();
                        LoadDanhSachLopHoc();
                    }
                } 
                
                
            }    
               
        }

        private void btnsualop_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as Classroom;
            if (lopDangChon != null)
            {

                var f = new frmLopchitiet(lopDangChon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachLopHoc();
                }
            }
        }

        private void bdsLopHoc_CurrentChanged(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as Classroom;
            if (lopDangChon != null)
            {
                var db = new AppQLSVDBContext();
                var dsSV = db.Students.Where(t => t.IDClassroom == lopDangChon.ID).ToList();
                bdsSinhVien.DataSource = dsSV;
                gridSinhVien.DataSource = bdsSinhVien;
            }
        }

        private void btnThemSv_Click(object sender, EventArgs e)
        {
                var f = new frmSinhVienChiTiet();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachSinhVien();
                }
            
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdsSinhVien.Current as Student;
            var ten = sinhVienDangChon.FirstName + sinhVienDangChon.LastName;
            if (sinhVienDangChon != null)
            {
                var rs = MessageBox.Show(string.Format("Bạn có thực sự muốn xóa sinh viên {0} không?", ten), "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var sv = db.Students.Where(a => a.ID == sinhVienDangChon.ID).FirstOrDefault();
                    if (sv != null)
                    {
                        db.Students.Remove(sv);
                        db.SaveChanges();
                        LoadDanhSachSinhVien();
                    }
                }
            }
        }

        private void bdsSinhVien_CurrentChanged(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdsSinhVien.Current as Student;
            if (sinhVienDangChon != null)
            {
                var db = new AppQLSVDBContext();

            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdsSinhVien.Current as Student;
            if (sinhVienDangChon != null)
            {
                var f = new frmSinhVienChiTiet(sinhVienDangChon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachSinhVien();
                }
            }
        }
    }
}
