using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Net4._5_
{/// <summary>
/// Владимир Грачев Домашнее задание 2
/// </summary>
    class Program
    {
        /// <summary>
        /// Определение минимального числа
        /// </summary>
        static void Task1()
        {
            double min;

            Console.Write("Укажите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Укажите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Укажите третье число: ");
            double c = double.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                min = a;

                Console.WriteLine($"{min} наименьшее число из 3 указанных");
            }

            else if (b < a && b < c)
            {
                min = b;

                Console.WriteLine($"{min} наименьшее число из 3 указанных");


            }
            else
            {
                min = c;

                Console.WriteLine($"{min} наименьшее число из 3 указанных");

            }

            Console.WriteLine("для продолжения нажмите Enter");

            Console.ReadLine();
        }
        /// <summary>
        /// Метод подсчета суммы чисел заданного числа числа
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Укажите любое целое чилсо: ");
            long a = long.Parse(Console.ReadLine());

            long s = 0;

            while (a > 0)
            {

                s = s + a % 10; //Записываем в память крайнее правое число
                a = a / 10; //отбрасываем крайнее правое число
            }

            Console.WriteLine($"Сумма чисел указанного числа равна {s}");

            Console.WriteLine("для продолжения нажмите Enter");

            Console.ReadLine();

        }
        /// <summary>
        /// Считаем сумму всех указанных нечетных чисел
        /// </summary>
        static void Task3()
        {
            int number = 0; //число указанное пользователем
            int counter = 0; //счетчик нечетных числе
            int x = 0; //сумма не чентных числе в перспективе

            do
            {
                Console.Write("Введите число от 1 до 1000: "); //просто ограничил максимальное количество вводов
                number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (number % 2 != 0) //если указанное число не четное, то
                {
                    counter++; //мы увеличиваем счетчик нечетных числе
                    x = x + number; //а само нечетное число прибывляем к сумме уже имеющихся не четных чисел
                }

            }
            while (number >= 1 && number <= 1000); //ограничения на количество выполнений цикла

            Console.WriteLine($"Вы указали {counter} нечетных чисел ввода.\n Их сумма равана {x}");
            Console.WriteLine("для продолжения нажмите Enter");
            Console.ReadLine();
        }
        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        static void Task4()
        {
            string login = "root"; //логин
            string password = "GeekBrains";//пароль
            int count = 0;//количество попыток

            do
            {
                Console.WriteLine("Введите логин: ");
                string checkLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string checkPassword = Console.ReadLine();


                if (login == checkLogin && password == checkPassword) //проверяем корректность указынных значений
                {

                    Console.WriteLine("Добро пожаловать, юзер!"); //выдаем приветсвие

                    break;
                }
                Console.WriteLine("Неверно введен логин или пароль"); //сообщение о не правильном указании логина или пароля

                ++count;//увеличение счетчика попыток

            } while (count < 3); //ограничение на количество попыток
           
            Console.WriteLine("для продолжения нажмите Enter");
            Console.ReadLine();
        }

        /// <summary>
        /// Индекс массы тела
        /// а) Определить ИМТ и дать ответ о норме веса
        /// б) Дать рекомендации
        /// </summary>
        static void Task5()
        {

            Console.WriteLine("Предупреждение!\n" +
                "Данная программа не учитывает:\n возраст\n пол\n " +
                "уровень мышечной массы\n В русской версии ОС рост пишите через ','\n" +
                "в английской версии через '.'");
            Console.Write("Рост в метрах(OS.ru 1,85; OS.en 1.85): ");//Русская и Английская версия ОС требует указания либо "," либо "."
            var a = float.Parse(Console.ReadLine());
            Console.Write("вес в кг (пример 85): ");
            var b = float.Parse(Console.ReadLine());


            var z = b / (a * a);
            var c = a * 100 - 100;


            Console.WriteLine($"Ваш ИМТ равен {z:f2}");

            if (z < 18.5)
            {
                Console.WriteLine($"Вам необходимо набрать вес");
                c = c - b;

                Console.WriteLine($"Вам неоходимо набрать около {c} кг.");
            }

            else if (z >= 18.5 && z < 25)
            {
                Console.WriteLine("Ваш вес в норме");

            }
            else if (z >= 25 && z < 30)
            {
                Console.WriteLine("У вас избыточный вес");
                c = b - c;
                Console.WriteLine($"Вам необходимо сбросить около {c} кг.");
            }
            else
            {

                Console.WriteLine("У вас ожирение");
                c = b - c;
                Console.WriteLine($"Вам необходимо сбросить около {c} кг.");

            }



            Console.WriteLine("для продолжения нажмите Enter");
            Console.ReadLine();
        }
        /// <summary>
        ///Не думаю что я понял эту задачу.....
        /// </summary>
        static void Task6()

        {
            DateTime start = DateTime.Now;
            int tk = 0;
            for (int i = 2; i < 1000000; i++)
                if (Tests(i))
                {
                    tk++;
                    Console.WriteLine("{0} {1}", tk, i);
                }
            Console.WriteLine(tk);
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("для продолжения нажмите Enter");
            Console.ReadLine();
        }
        /// <summary>
        /// Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        /// </summary>
        static void Task7()
        {
             Console.WriteLine("Укажите два числа");
             Console.Write("Укажите первое число: ");
             var a = int.Parse(Console.ReadLine());
             Console.Write("Укажите второе число: ");
             var b = int.Parse(Console.ReadLine());
             Ryad(a, b);
                  
            Console.WriteLine("для продолжения нажмите Enter");
            Console.ReadLine();
        }
        /// <summary>
        /// *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// </summary>
        static void Task7b()
        {


            Console.WriteLine("для продолжения нажмите Enter");
            Console.ReadLine();
        }
        #region Вспомогательный метод Tests
        static bool Tests(int x)
        {
            for (int i = 2; i <= Math.Sqrt(x) / 2; i++)
                if (x % i == 0) return false;
            return true;
        }
        #endregion
        #region Вспомогательный метод Ryad
        static void Ryad (int a, int b)
        {
            Console.Write("{0} ", a);
            if (a < b) Ryad(a + 1, b);

        }
        #endregion
        #region Основное меню ДЗ
        static void Main(string[] args)
        {

            bool F = true;


            while (F)
            {

                Console.WriteLine("1 - Задача 1");
                Console.WriteLine("2 - Задача 2");
                Console.WriteLine("3 - Задача 3");
                Console.WriteLine("4 - Задача 4");
                Console.WriteLine("5 - Задача 5");
                Console.WriteLine("6 - Задача 6");
                Console.WriteLine("7 - Задача 7a");
                Console.WriteLine("8 - Задача 7b");
                Console.WriteLine("0 - выход из программы");
                Console.Write("Укажите номер: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 8:
                        Console.WriteLine("Запускаю задачу 7b: ");
                        Task7b();
                        break;

                    case 0:
                        F = false;
                        break;

                    case 1:
                        Console.WriteLine("Запускаю задачу 1: ");
                        Task1();
                        break;
                    case 2:
                        Console.WriteLine("Запускаю задачу 2: ");
                        Task2();
                        break;
                    case 3:
                        Console.WriteLine("Запускаю задачу 3: ");
                        Task3();
                        break;
                    case 4:
                        Console.WriteLine("Запускаю задачу 4: ");
                        Task4();
                        break;
                    case 5:
                        Console.WriteLine("Запускаю задачу 5: ");
                        Task5();
                        break;
                    case 6:
                        Console.WriteLine("Запускаю задачу 6: ");
                        Task6();
                        break;
                    case 7:
                        Console.WriteLine("Запускаю задачу 7: ");
                        Task7();
                        break;

                    default:

                        Console.Write("Введен не корректный номер.\nПовторите попытку: \n");
                        break;

                }

            }
            Console.WriteLine("для выхода нажмите Enter");
            Console.ReadKey();
            #endregion
        }

    }
}
        
    
