using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public  class Method
    {
        static string str = "Data Source=.;DataBase=Education;Integrated security=SSPI";

        //得到课程集合
        public static string[] GetCourse()
        {
            string[] Course=new string[100];
            int temp = 0;
            using (SqlConnection scon = new SqlConnection(str))
            {
                using (SqlCommand scom = scon.CreateCommand())
                {
                    scon.Open();
                    scom.CommandText = "select Name from Course";
                    SqlDataReader read = scom.ExecuteReader();

                    while (read.Read())
                    {
                        Course[temp] = read["Name"].ToString().Trim();
                        temp++;
                    }
                    Course = Course.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                    
                }
            }
            return Course;
        }

        //得到教室集合
        public static string[] GetRoom()
        {
            string[] Room = new string[100];
            int temp = 0;
            using (SqlConnection scon = new SqlConnection(str))
            {
                using (SqlCommand scom = scon.CreateCommand())
                {
                    scon.Open();
                    scom.CommandText = "select RoomName from ClassRoom";
                    SqlDataReader read = scom.ExecuteReader();

                    while (read.Read())
                    {
                        Room[temp] = read["RoomName"].ToString().Trim();
                        temp++;
                    }
                    Room = Room.Where(s => !string.IsNullOrEmpty(s)).ToArray();

                }
            }
            return Room;
        }

        //得到班级集合
        public static string[] GetClass()
        {
            string[] Class = new string[100];
            int temp = 0;
            using (SqlConnection scon = new SqlConnection(str))
            {
                using (SqlCommand scom = scon.CreateCommand())
                {
                    scon.Open();
                    scom.CommandText = "select Name from Class";
                    SqlDataReader read = scom.ExecuteReader();

                    while (read.Read())
                    {
                        Class[temp] = read["Name"].ToString().Trim();
                        temp++;
                    }
                    Class = Class.Where(s => !string.IsNullOrEmpty(s)).ToArray();

                }
            }
            return Class;
        }


        //得到时间段集合
        public static string[] GetTime()
        {
            string[] Time = new string[100];
            int temp = 0;
            using (SqlConnection scon = new SqlConnection(str))
            {
                using (SqlCommand scom = scon.CreateCommand())
                {
                    scon.Open();
                    scom.CommandText = "select Name from CsTime";
                    SqlDataReader read = scom.ExecuteReader();

                    while (read.Read())
                    {
                        Time[temp] = read["Name"].ToString().Trim();
                        temp++;
                    }
                    Time = Time.Where(s => !string.IsNullOrEmpty(s)).ToArray();

                }
            }
            return Time;
        }

        //得到老师
        public static string[] GetTeacher()
        {
            string[] Teacher = new string[100];
            int temp = 0;
            using (SqlConnection scon = new SqlConnection(str))
            {
                using (SqlCommand scom = scon.CreateCommand())
                {
                    scon.Open();
                    scom.CommandText = "select Name from Teacher";
                    SqlDataReader read = scom.ExecuteReader();

                    while (read.Read())
                    {
                        Teacher[temp] = read["Name"].ToString().Trim();
                        temp++;
                    }
                    Teacher = Teacher.Where(s => !string.IsNullOrEmpty(s)).ToArray();

                }
            }
            return Teacher;
        }

        public static bool insertlesson(Mycourse le)
        {
            using (SqlConnection scon = new SqlConnection(str))
            {
                using (SqlCommand scom = scon.CreateCommand())
                {
                    scon.Open();
                    scom.CommandText = "insert into CSTable(Time,CourseName,Techaer,ClassRoom,Classm) values(@time,@course,@teacher,@classroom,@class)";
                    SqlParameter[] p = new SqlParameter[]
                        {
                            new SqlParameter("@time",le.Time),
                            new SqlParameter("course",le.Course),
                            new SqlParameter("@teacher",le.Teacher),
                            new SqlParameter("@classroom",le.Room),
                            new SqlParameter("@class",le.Classm)
                        };
                    scom.Parameters.AddRange(p);
                    return scom.ExecuteNonQuery()>0;


                }
            }
        }
    }
}
