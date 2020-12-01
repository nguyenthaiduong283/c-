using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmThemLop : Form
    {
        public frmThemLop()
        {
            InitializeComponent();
            
        }

        void AddClassroom()
        {
            Classroom classroom = new Classroom
            {
                ID = Guid.NewGuid().ToString(),
                Name = txtTenlop.Text,
                Room = txtPhonghoc.Text
            };
            var db = new QLSVDBContext();
            var obj = db.Classrooms.Where(t
                => t.Name == classroom.Name).FirstOrDefault();//trả về biến đầu tiên nếu ko có là null
            if (obj == null)
            {
                db.Classrooms.Add(classroom);
                db.SaveChanges();
                MessageBox.Show("Bạn đã thêm thành công");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Bạn không thể thêm lớp này");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClassroom();
        }
    }
}
