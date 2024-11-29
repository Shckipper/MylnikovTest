using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace MylnikovTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса FunctionInsp
            FunctionInsp insp = new FunctionInsp();
            // Вывод названия автоинспекции
            Console.WriteLine("Название автоинспекции: " + insp.GetCarInspection());

            // Вывод ФИО главного инспектора
            Console.WriteLine("Главный инспектор: " + insp.GetInspector());
            
            // Вывод списка сотрудников
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Изменение ФИО главного инспектора
            Console.WriteLine("Изменение главного инспектора...");
            bool result = insp.SetInspector("Иванов И.И.");
            Console.WriteLine(result ? "Инспектор изменен." : "Ошибка изменения инспектора.");
            Console.WriteLine("Новый главный испектор:" + insp.GetInspector());

            // Добавление нового сотрудника
            Console.WriteLine("Добавление нового сотрудника...");
            insp.AddWorker("Новиков Н.Н.");
            Console.WriteLine("Список сотрудников после добавления:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Генерация государственного номера автомобиля
            Console.WriteLine("Сгенерированный номер: " + insp.GenerateNumber(123, 'A'));
            Console.ReadKey();
        }
    }
}
