using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TSPDATA
    {

        public static  int SPECIES_Num = 50; //种群数
        public static readonly int Develop_Num = 50; //进化代数
        public static readonly float pcl = 0.7f, pch = 0.95f;//交叉概率
        public static readonly float pm = 0.1f; //变异概率
        public static readonly string[] Course = Method.GetCourse();
        public static readonly string[] Room= Method.GetRoom(); //教室集合
        public static  string[] Classm= Method.GetClass(); //班级集合
        public static readonly string[] Teacher= Method.GetTeacher(); //教师集合
        public static readonly string[] Time =Method.GetTime(); //时间集合
        public static readonly int LessonNum = Room.Length * Time.Length;
       
        
    }

    public class Lesson
    {
        private int course;
        private int room;
        private int classm;
        private int time;
        private int teacher;

        public int Course { get => course; set => course = value; }
        public int Room { get => room; set => room = value; }
        public int Classm { get => classm; set => classm = value; }
        public int Time { get => time; set => time = value; }
        public int Teacher { get => teacher; set => teacher = value; }

        public static string Getstr(Lesson lesson)
        {
            string str = lesson.Time.ToString() + lesson.Room.ToString() + lesson.Teacher.ToString() + lesson.Course.ToString() + lesson.Classm.ToString();
            return str;
        }

        public static Lesson GetLesson(string str)
        {
            Lesson l = new Lesson();
            
            l.Time= int.Parse(str.Substring(0, 1));
            l.Room = int.Parse(str.Substring(1, 1));
            l.Teacher = int.Parse(str.Substring(2, 1));
            l.Course = int.Parse(str.Substring(3, 1));
            l.Classm = int.Parse(str.Substring(4, 1));
            return l;
        }
    }

}
