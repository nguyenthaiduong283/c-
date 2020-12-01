using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileStudent.Entity
{
    public class Student
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string POB { get; set; }
        public SEXUAL Sexual { get; set; }
        public string PathAvatar { get; set; }
        public List<Learning_history> ListLearningHistory { get; set; }
        /// <summary>
        /// Tạo 1 sinh viên giả
        /// </summary>
        /// <returns></returns>
        public static Student CreateFakeStrudent()
        {
            Student student = new Student
            {
                ID = "17T1021291",
                FirstName = "Nguyễn Sanh",
                LastName = "Trưng",
                DOB = new DateTime(2020,03,16),
                POB = "Bốn bể là nhà",
                Sexual = SEXUAL.Male,
                PathAvatar= Application.StartupPath+"\\img\\idollll.jpg",
            };
            List<Learning_history> histories = new List<Learning_history>();
            for (int i=1; i<= 12; i++)
            {
                Learning_history history = new Learning_history
                {
                    ID = i.ToString(),
                    Lop = i.ToString(),
                    Truong = "trường quốc học",
                    Hocluc = "Giỏi",
                    Diachi = "tp huế"

                };
                histories.Add(history);
            }
            student.ListLearningHistory = histories;
            return student;
        }
        public enum SEXUAL
        {
            Male, Female, Other
        }
    }
}
