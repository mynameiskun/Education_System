using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class SpeciesIndividual
    {
        public string[,] genes;//基因序列
        public int[] fitness;//适应度


        public SpeciesIndividual()
        {
            //初始化
            this.genes = new string[TSPDATA.SPECIES_Num, TSPDATA.LessonNum];
            this.fitness = new int[TSPDATA.SPECIES_Num];

            for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            {

                this.fitness[i] = 100;
            }

        }

        //初始物种基因(随机)
        public void CreateByRandomGenes()
        {

            int temp;
            Random rand = new Random();
            for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            {
                temp = 0;
                for (int j = 0; j < TSPDATA.Time.Length; j++)
                {
                    for (int k = 0; k < TSPDATA.Room.Length; k++)
                    {

                        Lesson lesson = new Lesson();

                        lesson.Classm = rand.Next(TSPDATA.Classm.Length);
                        lesson.Course = rand.Next(TSPDATA.Course.Length);
                        lesson.Room = k;
                        lesson.Teacher = rand.Next(TSPDATA.Teacher.Length);
                        lesson.Time = j;
                        genes[i, temp] = Lesson.Getstr(lesson);
                        temp++;
                    }

                }
            }
        }

        public void Deletect()
        {
            

            for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            {
                for (int j = 0; j < TSPDATA.LessonNum - 1; j++)
                {

                    Lesson le = Lesson.GetLesson(genes[i, j]);
                    Lesson lec = Lesson.GetLesson(genes[i, j + 1]);
                    if (le.Time.Equals(lec.Time))
                    {
                        if (le.Teacher.Equals(lec.Teacher) || le.Course.Equals(lec.Course) || le.Classm.Equals(lec.Classm))
                        {
                            le.Course = 9;
                            genes[i, j] = Lesson.Getstr(le);
                        }
                    }

                }
            }
        }
        //适应度函数
        public void CalFitness()
        {
            
            for (int j = 0; j < fitness.Length; j++)
            {
                fitness[j] = 100;
            }

            for(int i=0;i<TSPDATA.SPECIES_Num;i++)
            {
                for (int j = 0; j < TSPDATA.LessonNum-1;j++)
                {
                   
                        Lesson le = Lesson.GetLesson(genes[i, j]);
                        Lesson lec = Lesson.GetLesson(genes[i, j+ 1]);
                        if(le.Time.Equals(lec.Time)&&le.Course!=9)
                        {
                            if(le.Teacher.Equals(lec.Teacher)||le.Course.Equals(lec.Course)||le.Classm.Equals(lec.Classm))
                            {
                                fitness[i]--;
                            
                            }
                        }
                    
                }
            }
            //int flag = 0;
            //string[] tempa = new string[TSPDATA.Room.Length];


            //遍历种群
            //for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            //{
            //    int temp = 0;
            //    //遍历种群中一个个体的课程
            //    for (int j = 0; j < TSPDATA.LessonNum; j++)
            //    {
            //        string str = genes[i, j];
            //        string time = str.Substring(0, 1);
            //        //如果时间相等
            //        if (time.Equals(TSPDATA.Time[temp]))
            //        {
            //            //取得时间相同的课的集合
            //            tempa[flag] = str;
            //            flag++;
            //        }
            //        else
            //        {
            //            temp++;

            //            //遍历时间相同的课
            //            for (int q = 0; q < tempa.Length; q++)
            //            {
            //                for (int w = tempa.Length - 1; w > q; w--)
            //                {
            //                    string teacher1 = tempa[q].Substring(7, 3);
            //                    string teacher2 = tempa[w].Substring(7, 3);
            //                    string course1 = tempa[q].Substring(10, 5);
            //                    string course2 = tempa[w].Substring(10, 5);
            //                    string clss1 = tempa[q].Substring(15, 3);
            //                    string clss2 = tempa[w].Substring(15, 3);
            //                    if (teacher1.Equals(teacher2) || course1.Equals(course2) || clss1.Equals(clss2))
            //                    {
            //                        fitness[i]--;
            //                    }
            //                    //if(course1.Equals(course2))
            //                    //{
            //                    //    fitness[i]--;
            //                    //}
            //                    //if (clss1.Equals(clss2))
            //                    //{
            //                    //    fitness[i]--;
            //                    //}
            //                }
            //            }

            //            flag = 0;
            //            break;
            //        }
        //} 

            

        }

        //选择优秀物种（轮盘赌）
        public void Select()
        {
            string[,] demogenes = new string[TSPDATA.SPECIES_Num, TSPDATA.LessonNum];//存储新的genes

            int u = Convert.ToInt32(TSPDATA.SPECIES_Num * 0.7);
            Random rand = new Random(); 
            //最大适应度
            int cal_temp = Convert.ToInt32(fitness[0]);
            int cal_flag = 0;
            double[] temp = new double[fitness.Length];
            double sum = 0.0d;
            for (int i = 0; i < fitness.Length; i++)
            {
                sum += fitness[i];
            }
            //由适应度计算概率
            for (int j = 0; j < fitness.Length; j++)
            {
                //找到适应度最高
                if (Convert.ToInt32(fitness[j]) > cal_temp)
                {
                    cal_temp = Convert.ToInt32(fitness[j]);
                    cal_flag = j;
                }
                temp[j] = fitness[j] / sum;
            }

            //复制优秀物种
            for (int e = 0; e < TSPDATA.SPECIES_Num; e++)
            {
                for (int y = 0; y < TSPDATA.LessonNum; y++)
                {
                    demogenes[e, y] = genes[cal_flag, y];
                }
            }

            //轮盘赌:选择30%的个体加入新种群
            //for(int k=0;k<TSPDATA.SPECIES_Num-u;k++)
            //{
            //    double ran = rand.NextDouble();

            //    double tem = 0.0d;
            //    for(int w=0;w<TSPDATA.SPECIES_Num;w++)
            //    {
            //        tem += temp[w];
            //        if(tem>ran)
            //        {
            //            for (int y = 0; y < TSPDATA.LessonNum; y++)
            //            {
            //                demogenes[u, y] = genes[w, y];
            //            }
            //            break;
            //        }
            //    }
            //}

            //将得到的新种群赋值到种群
            for (int i = 0; i < TSPDATA.SPECIES_Num ; i++)
            {
                for (int j = 0; j < TSPDATA.LessonNum; j++)
                {
                    genes[i, j] = demogenes[i, j];
                }
            }
        }

        //交叉
        public void Crossover()
        {
            Random rand = new Random();

            for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            {
                float rate = (float)rand.NextDouble();
                for (int j = 0; j < TSPDATA.LessonNum-1; j++)
                {
                    if (rate > TSPDATA.pcl && rate < TSPDATA.pch)
                    {
                        //string str = genes[i+1, j];
                        Lesson le1 = Lesson.GetLesson(genes[i, j]);
                        Lesson le2 = Lesson.GetLesson(genes[i, j+1]);
                        if (le1.Time != -1 && le2.Time != -1)
                        {
                            int s, k, g;
                            s = le1.Teacher;
                            k = le1.Course;
                            g = le1.Classm;
                            le1.Teacher = le2.Teacher;
                            le1.Course = le2.Course;
                            le1.Classm = le2.Classm;
                            le2.Classm = g;
                            le2.Course = k;
                            le2.Teacher = s;
                            genes[i, j] = Lesson.Getstr(le1);
                            genes[i, j + 1] = Lesson.Getstr(le2);
                        }
                    }
                }
            }

        }

        //变异
        public void Mutate()
        {
            Random rand = new Random();
            float rate = (float)rand.NextDouble();
            for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            {
                for (int j = 0; j < TSPDATA.LessonNum - 1; j++)
                {
                    if (rate < TSPDATA.pm)
                    {

                        Lesson l1 = Lesson.GetLesson(genes[i, j]);
                        l1.Teacher = rand.Next(TSPDATA.Teacher.Length);
                        l1.Course = rand.Next(TSPDATA.Course.Length);
                        l1.Classm = rand.Next(TSPDATA.Classm.Length);
                        genes[i, j] = Lesson.Getstr(l1);
                    }
                }
            }
        }

        public int GetBest()
        {
            int cal_temp = Convert.ToInt32(fitness[0]);
            int cal_flag = 0;
            for (int j = 0; j < fitness.Length; j++)
            {
                //找到适应度最高
                if (Convert.ToInt32(fitness[j]) > cal_temp)
                {
                    cal_temp = Convert.ToInt32(fitness[j]);
                    cal_flag = j;
                }

            }


            return cal_flag;
        }

        //交换冲突
        public void Range()
        {
            //int flag = 0;
            //string[] tempa = new string[TSPDATA.Room.Length];


            ////遍历种群
            //for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            //{
            //    int temp = 0;
            //    //遍历种群中一个个体的课程
            //    for (int j = 0; j < TSPDATA.LessonNum-1; j++)
            //    {
            //        string str = genes[i, j];
            //        string time = str.Substring(0, 2);
            //        //如果时间相等
            //        if (time.Equals(TSPDATA.Time[temp]))
            //        {
            //            //取得时间相同的课的集合
            //            tempa[flag] = str;
            //            flag++;
            //        }
            //        else
            //        {
            //            temp++;

            //            //遍历时间相同的课
            //            for (int q = 0; q < tempa.Length; q++)
            //            {
            //                for (int w = tempa.Length - 1; w > q; w--)
            //                {
            //                    string teacher1 = tempa[q].Substring(7, 3);
            //                    string teacher2 = tempa[w].Substring(7, 3);
            //                    string course1 = tempa[q].Substring(10, 5);
            //                    string course2 = tempa[w].Substring(10, 5);
            //                    string clss1 = tempa[q].Substring(15, 3);
            //                    string clss2 = tempa[w].Substring(15, 3);
            //                    if (teacher1.Equals(teacher2) || course1.Equals(course2))
            //                    {
                                   
            //                        string str1 = genes[i, j];
            //                        string str2 = genes[i, j+1];
            //                        Lesson l1 = Lesson.GetLesson(str1);
            //                        Lesson l2 = Lesson.GetLesson(str2);
            //                        string str4 = l1.Course;
            //                        l1.Course = l2.Course;
            //                        l2.Course = str4;
            //                        string str3 = l1.Teacher;
            //                        l1.Teacher = l2.Teacher;
            //                        l2.Teacher = str3;
            //                        genes[i, j ] = Lesson.Getstr(l1);
            //                        genes[i, j + 1] = Lesson.Getstr(l2);
            //                    }
            //                    //if (course1.Equals(course2))
            //                    //{
            //                    //    string str1 = genes[i, j];
            //                    //    string str2 = genes[i, j + 1];
            //                    //    Lesson l1 = Lesson.GetLesson(str1);
            //                    //    Lesson l2 = Lesson.GetLesson(str2);
            //                    //    string str3 = l1.Course;
            //                    //    l1.Course = l2.Course;
            //                    //    l2.Course = str3;
            //                    //    genes[i, j] = Lesson.Getstr(l1);
            //                    //    genes[i, j + 1] = Lesson.Getstr(l2);
            //                    //}
            //                    if (clss1.Equals(clss2))
            //                    {
            //                        string str1 = genes[i, j];
            //                        string str2 = genes[i, j + 1];
            //                        Lesson l1 = Lesson.GetLesson(str1);
            //                        Lesson l2 = Lesson.GetLesson(str2);
            //                        string str3 = l1.Classm;
            //                        l1.Classm = l2.Classm;
            //                        l2.Classm = str3;
            //                        genes[i, j] = Lesson.Getstr(l1);
            //                        genes[i, j + 1] = Lesson.Getstr(l2);
            //                    }
            //                }
            //            }

            //            flag = 0;
            //            break;
            //        }
            //    }
            //}
        }

        //删除冲突
        public void DeleteRe()
        {
            int flag = 0;
            string[] tempa = new string[TSPDATA.Room.Length];


            //遍历种群
            for (int i = 0; i < TSPDATA.SPECIES_Num; i++)
            {
                int temp = 0;
                //遍历种群中一个个体的课程
                for (int j = 0; j < TSPDATA.LessonNum - 1; j++)
                {
                    string str = genes[i, j];
                    string time = str.Substring(0, 2);
                    //如果时间相等
                    if (time.Equals(TSPDATA.Time[temp]))
                    {
                        //取得时间相同的课的集合
                        tempa[flag] = str;
                        flag++;
                    }
                    else
                    {
                        temp++;

                        //遍历时间相同的课
                        for (int q = 0; q < tempa.Length; q++)
                        {
                            for (int w = tempa.Length - 1; w > q; w--)
                            {
                                string teacher1 = tempa[q].Substring(7, 3);
                                string teacher2 = tempa[w].Substring(7, 3);
                                string course1 = tempa[q].Substring(10, 5);
                                string course2 = tempa[w].Substring(10, 5);
                                string clss1 = tempa[q].Substring(15, 3);
                                string clss2 = tempa[w].Substring(15, 3);
                                if (teacher1.Equals(teacher2) || course1.Equals(course2)|| clss1.Equals(clss2))
                                {
                                    
                                }
                               
                               
                            }
                        }

                        flag = 0;
                        break;
                    }
                }
            }

        }


        //得到Lesson列表
        public List<Lesson> GetAll(string[] Ls)
        {
            List<Lesson> l1 = new List<Lesson>();
            foreach(string str in Ls)
            {
                l1.Add(Lesson.GetLesson(str));
            }
            return l1;
        }
    }
}
