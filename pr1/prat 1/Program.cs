using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать двумерный массив размерностью m на n элементов, заполнив его случайными числами в диапазоне от 0 до 9.Отсортировать элементы массива по возрастанию вначале по строкам, а затем по столбцам. 
            //    Вывести на экран исходный массив, массив отсортированный построчно, массив отсортированный по столбцам. Для сортировки применить метод пузырька.




            //int m = 5, n = 10;

            //Random rnd = new Random();

            //int[,] arr = new int[m, n];
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr[i, j] = rnd.Next(10);
            //    }
            //}

            //Console.WriteLine("Исходный массив:");
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n - 1; j++)
            //    {
            //        for (int k = j + 1; k < n; k++)
            //        {
            //            if (arr[i, j] > arr[i, k])
            //            {
            //                int temp = arr[i, j];
            //                arr[i, j] = arr[i, k];
            //                arr[i, k] = temp;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Массив, отсортированный по строкам:");
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int j = 0; j < n; j++)
            //{
            //    for (int i = 0; i < m - 1; i++)
            //    {
            //        for (int k = i + 1; k < m; k++)
            //        {
            //            if (arr[i, j] > arr[k, j])
            //            {
            //                int temp = arr[i, j];
            //                arr[i, j] = arr[k, j];
            //                arr[k, j] = temp;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Массив, отсортированный по столбцам:");
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //            }
            //        }
            //    }
            //}


            //2.Создать двумерный массив размерности 3x3, и заполнить его числами от 1 до 9, расположенными случайным образом.

            //            int[,] matrix = new int[3, 3];


            //            Random random = new Random();
            //            int[] numbers = Enumerable.Range(1, 9).OrderBy(x => random.Next()).ToArray();
            //            for (int i = 0; i < 3; i++)
            //            {
            //                for (int j = 0; j < 3; j++)
            //                {
            //                    matrix[i, j] = numbers[i * 3 + j];
            //                }
            //            }


            //            for (int i = 0; i < 3; i++)
            //            {
            //                for (int j = 0; j < 3; j++)
            //                {
            //                    Console.Write(matrix[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //}


            //            3.Создать программу конструктора бургеров, каждый запуск которой формирует случайный рецепт из возможных ингредиентов.

            //            string[] bun = { "Булочка для гамбургера" };
            //            string[] meat = { "Говяжий фарш", "Куриный фарш", "Свиной фарш" };
            //            string[] cheese = { "Сыр" };
            //            string[] vegetables = { "Салат", "Томаты", "Огурцы", "Лук" };
            //            string[] sauces = { "Кетчуп", "Майонез", "Горчица" };
            //            string[] extras = { "Бекон" };

            //            Random random = new Random();

            //            string[] burger = {bun[random.Next(bun.Length)],
            //                           meat[random.Next(meat.Length)],
            //                           cheese[random.Next(cheese.Length)],
            //                           vegetables[random.Next(vegetables.Length)],
            //                           sauces[random.Next(sauces.Length)]};

            //            if (random.NextDouble() < 0.5)
            //            {
            //                Array.Resize(ref burger, burger.Length + 1);
            //                burger[burger.Length - 1] = extras[random.Next(extras.Length)];
            //            }

            //            Console.WriteLine("Ваш случайный бургер:");
            //            foreach (string ingredient in burger)
            //            {
            //                Console.WriteLine("- " + ingredient);
            //            }
            //        }
            //    }
            //}

//            4.Написать программу рандомного вызова студентов своей группы.
//            {
//                string[] students =
//                    {
//                    "Акрамжанов",
//                    "Астафьев",
//                    "Булычев",
//                    "Вафин",
//                    "Воробьёв",
//                    "Гоциридзе",
//                    "Грималяк",
//                    "Груздев",
//                    "Ефремов",
//                    "Заказнов",
//                    "Ибрагимов",
//                    "Карташов",
//                    "Козуев",
//                    "Коноваленко",
//                    "Кулаков",
//                    "Курилов",
//                    "Лелари",
//                    "Лушин",
//                    "Малышев",
//                    "Минин",
//                    "Науменко",
//                    "Необердин",
//                    "Приходьтко",
//                    "Тарасов",
//                    "Умаров",
//                    "Хандилян",
//                    "Широков",};

//                Random random = new Random();

//                int index = random.Next(students.Length);

//                Console.WriteLine(" ОН " + students[index]);
//            }
//        }
//    }
//}




