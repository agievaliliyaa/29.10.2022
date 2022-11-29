using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            string[] tasks = { "Разработать мобильное приложение", "Сделать алгоритм для видеохостинга",
            "Обновить устаревшее ПО", "Сделать сайт для заказчика" };
            StreamReader info = new StreamReader(@"C:\Users\farra\source\repos\HomeWork_05.11\HomeWork_05.11\staff.txt");
            Console.WriteLine(info.ReadToEnd());
            Console.WriteLine($"Список задач перед компанией: \n 1 - {tasks[0]} \n 2 - {tasks[1]} \n 3 - {tasks[2]} \n " +
                $"4 - {tasks[3]} \n");
            Console.WriteLine("Введите номер задачи, которую хотите дать одному из работников компании");
            string task = tasks[int.Parse(Console.ReadLine()) - 1];
            Console.WriteLine($"Кому дать задачу <<{task}>>");
            var person1 = EmployeeStaff.ReturnEmployee(Console.ReadLine());
            Console.WriteLine($"Кому {person1.name} перенаправит задачу?");
            var person2 = EmployeeStaff.ReturnEmployee(Console.ReadLine());


            Console.WriteLine($"\n{person1.name} дает задачу <<{task}>>, которую исполнит {person2.name} \n");
            if ((person2.ID - 1 == person1.ID) && ((person1.property == person2.property) || ((person1.property == "management") && (person2.property == "management")) || ((person1.property == "management") && (person2.property == "development"))))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person2.name} берет эту задачу");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{person2.name} не берет эту задачу");
                Console.ResetColor();
            }
        }
    }
}
