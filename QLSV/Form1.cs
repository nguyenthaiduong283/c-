using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.DAL;

namespace QLSV
{
    public partial class Form1 : Form
    {
        private object txtKeyWord;

        public Form1()
        {
            InitializeComponent();
            LoadClassrom();
            /*AddClassroom();*/
        }
        /// <summary>
        /// Lấy danh sách lớp học có trong csdl
        /// </summary>
        void LoadClassrom()
        {
            var db = new QLSVDBContext();
            var ls = db.Classrooms.
               /* Where(e => e.Room == "Lab1").
                Select(e=> 
                new 
                { 
                    TenLop =e.Name, 
                    PhongHoc= e.Room,
                    Siso=e.Students.Count,
                    GVCV="ABC"
                
                }).*/ToList();
            dataGridView1.DataSource = ls;
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var keyWord = textBox1.Text;
                var db = new QLSVDBContext();
                var ls = db.Classrooms.
                    Where(d => d.Name.Contains(keyWord) || d.Room.Contains(keyWord)).ToList();
                dataGridView1.DataSource = ls;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new frmThemLop();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadClassrom();
            }
            
        }
    }
}
