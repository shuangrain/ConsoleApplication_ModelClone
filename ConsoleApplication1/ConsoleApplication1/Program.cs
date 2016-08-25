using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Model cp_model = new Model();

            model.year = 1;
            model.month = 2;
            model.day = 3;
            Console.WriteLine("model||year:{0}, month:{1}, day:{2}.", model.year, model.month, model.day);
            Console.WriteLine("cp_model||year:{0}, month:{1}, day:{2}.", cp_model.year, cp_model.month, cp_model.day);

            Console.WriteLine("=== 分隔線 ===");

            model.year = 1;
            model.month = 2;
            model.day = 3;
            cp_model = model;
            cp_model.year = 4;
            cp_model.month = 5;
            cp_model.day = 6;
            Console.WriteLine("model||year:{0}, month:{1}, day:{2}.", model.year, model.month, model.day);
            Console.WriteLine("cp_model||year:{0}, month:{1}, day:{2}.", cp_model.year, cp_model.month, cp_model.day);

            Console.WriteLine("=== 分隔線 ===");

            model.year = 1;
            model.month = 2;
            model.day = 3;
            cp_model = (Model)model.Clone();
            cp_model.year = 4;
            cp_model.month = 5;
            cp_model.day = 6;
            Console.WriteLine("model||year:{0}, month:{1}, day:{2}.", model.year, model.month, model.day);
            Console.WriteLine("cp_model||year:{0}, month:{1}, day:{2}.", cp_model.year, cp_model.month, cp_model.day);

            Console.WriteLine("=== 分隔線 ===");

            List<Model> list_1 = new List<Model>();
            List<Model> list_2 = new List<Model>();

            list_1.Clear();
            list_2.Clear();

            list_1.Add(new Model()
            {
                year = 1,
                month = 2,
                day = 3
            });


            for (int i = 0; i < list_1.Count; i++)
            {
                Console.WriteLine("list_1 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_1[i].year,
                    list_1[i].month,
                    list_1[i].day,
                    i);
            }

            Console.WriteLine("=== 分隔線 ===");

            list_1.Clear();
            list_2.Clear();

            list_1.Add(new Model()
            {
                year = 1,
                month = 2,
                day = 3
            });
            list_2 = list_1;
            list_2[0].year = 4;
            list_2[0].month = 5;
            list_2[0].day = 6;

            for (int i = 0; i < list_1.Count; i++)
            {
                Console.WriteLine("list_1 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_1[i].year,
                    list_1[i].month,
                    list_1[i].day,
                    i);
                Console.WriteLine("list_2 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_2[i].year,
                    list_2[i].month,
                    list_2[i].day,
                    i);
            }

            Console.WriteLine("=== 分隔線 ===");

            list_1.Clear();
            list_2.Clear();

            list_1.Add(new Model()
            {
                year = 1,
                month = 2,
                day = 3
            });
            list_2 = new List<Model>(list_1);
            list_2[0].year = 4;
            list_2[0].month = 5;
            list_2[0].day = 6;

            for (int i = 0; i < list_1.Count; i++)
            {
                Console.WriteLine("list_1 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_1[i].year,
                    list_1[i].month,
                    list_1[i].day,
                    i);
                Console.WriteLine("list_2 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_2[i].year,
                    list_2[i].month,
                    list_2[i].day,
                    i);
            }

            Console.WriteLine("=== 分隔線 ===");

            list_1.Clear();
            list_2.Clear();

            list_1.Add(new Model()
            {
                year = 1,
                month = 2,
                day = 3
            });
            list_2 = list_1.ToList();
            list_2[0].year = 4;
            list_2[0].month = 5;
            list_2[0].day = 6;

            for (int i = 0; i < list_1.Count; i++)
            {
                Console.WriteLine("list_1 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_1[i].year,
                    list_1[i].month,
                    list_1[i].day,
                    i);
                Console.WriteLine("list_2 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_2[i].year,
                    list_2[i].month,
                    list_2[i].day,
                    i);
            }

            Console.WriteLine("=== 分隔線 ===");

            list_1.Clear();
            list_2.Clear();

            list_1.Add(new Model()
            {
                year = 1,
                month = 2,
                day = 3
            });
            list_2 = list_1.Select(item => (Model)item.Clone()).ToList();
            list_2[0].year = 4;
            list_2[0].month = 5;
            list_2[0].day = 6;

            for (int i = 0; i < list_1.Count; i++)
            {
                Console.WriteLine("list_1 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_1[i].year,
                    list_1[i].month,
                    list_1[i].day,
                    i);
                Console.WriteLine("list_2 - {3}||year:{0}, month:{1}, day:{2}.",
                    list_2[i].year,
                    list_2[i].month,
                    list_2[i].day,
                    i);
            }


            Console.ReadLine();
        }
    }

    class Model : ICloneable
    {
        public int year { get; set; }

        public int month { get; set; }

        public int day { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
