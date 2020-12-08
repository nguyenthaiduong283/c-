using AppQLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV.GUI
{
    public partial class frmLopchitiet : Form
    {
        private Classroom lopHoc;

        public frmLopchitiet()
        {
            InitializeComponent();
            this.Text = "Thêm Mới Lớp Học";
        }
        public frmLopchitiet(Classroom lopHoc)
        {
            InitializeComponent();
            this.Text = "Chỉ Sửa Lớp Học";
            this.lopHoc = lopHoc;
            txtTenLop.Text = this.lopHoc.Name;
            txtPhongHoc.Text = this.lopHoc.Room;
        }


      

       

        private void frmLopchitiet_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var tenLop = txtTenLop.Text;
            var phongHoc = txtPhongHoc.Text;
            //thêm lớp ở đây
            if (this.lopHoc == null)
            {

                var lop = new Classroom
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = tenLop,
                    Room = phongHoc
                };
                var db = new AppQLSVDBContext();
                db.Classrooms.Add(lop);
                db.SaveChanges();
                //nếu thêm thành công thì trả về ok
                DialogResult = DialogResult.OK;
            }
            else
            {
                var db = new AppQLSVDBContext();
                var lop = db.Classrooms.Where(t => t.ID == lopHoc.ID).FirstOrDefault();
                lop.Name = tenLop;
                lop.Room = phongHoc;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
