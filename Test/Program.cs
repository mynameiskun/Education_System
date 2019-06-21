using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Timers;
using System.Threading;
using System.Data.SqlClient;
namespace Test
{
    
    class Program
    {

        static void Main(string[] args)
        {
            SpeciesIndividual sp = new SpeciesIndividual();
            sp.CreateByRandomGenes();

            for (int i = 0; i < 5; i++)
            {
                sp.Select();
                sp.Crossover();
                sp.Mutate();
                

                sp.CalFitness();
                for (int j = 0; j< TSPDATA.SPECIES_Num; j++)
                {
                    Console.WriteLine("存在{0}节课,适应度为{0}", sp.genes.Length, sp.fitness[j]);

                }

            }

            sp.Deletect();

            for (int j = 0; j < TSPDATA.LessonNum; j++)
            {
                Lesson le = Lesson.GetLesson(sp.genes[sp.GetBest(), j]);
                if (le.Course != 9)
                {
                    Mycourse mc = new Mycourse();
                    mc.Time = TSPDATA.Time[le.Time];
                    mc.Course = TSPDATA.Course[le.Course];
                    mc.Classm = TSPDATA.Classm[le.Classm];
                    mc.Room = TSPDATA.Room[le.Room];
                    mc.Teacher = TSPDATA.Teacher[le.Teacher];
                    Console.WriteLine("时间：{0}，教师：{1}，教室：{2},课程：{3}，班级：{4}", mc.Time, mc.Teacher, mc.Room, mc.Course, mc.Classm);
                    if (Method.insertlesson(mc))
                    {
                        Console.WriteLine("插入第{0}节课成功", j);
                    }
                }
            }
            


            Console.ReadKey();

        }
    }
}
