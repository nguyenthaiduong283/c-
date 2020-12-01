﻿using ProfileStudent.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileStudent
{
    public partial class Form1 : Form
    {
        Student student;
        public Form1()
        {
            InitializeComponent();
            student = Student.CreateFakeStrudent();

            txtID.Text = student.ID;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtPlaceOfBirthday.Text = student.POB;
            txtBirthday.Value = student.DOB;
            switch (student.Sexual)
            {
                case Student.SEXUAL.Male:
                    rdbMale.Checked = true;break;
                case Student.SEXUAL.Female:
                    rdbFemale.Checked = true; break;
                case Student.SEXUAL.Other:
                    rdbOtherSexual.Checked = true; break;

            }
            if (!string.IsNullOrEmpty(student.PathAvatar))
                picAvata.ImageLocation = student.PathAvatar;
            gridHistory.AutoGenerateColumns = false;
            gridHistory.DataSource = student.ListLearningHistory;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void picAvata_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh |*.jpg;*.png";
            dialog.Title = "chọn ảnh sinh viên";
            if (dialog.ShowDialog()== DialogResult.OK)
            {
                picAvata.ImageLocation = dialog.FileName;
            }
        }
    }
}
