using App.Dal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridLopHoc.AutoGenerateColumns = false;
            LoadDanhSachLop();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadDanhSachLop()
        {
            var db = new AppQLSVDBContext();

            var ls = db.Classrooms.ToList();
            gridLopHoc.DataSource = ls;


        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnthemlop_Click(object sender, EventArgs e)
        {
            var f = new ThemLop();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachLop();
            }    
        }

        private void btnXoalop_Click(object sender, EventArgs e)
        {

        }
    }
}
