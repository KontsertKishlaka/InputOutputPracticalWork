using System;

namespace InputOutputPracticalWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Вводим свои значения
            Console.WriteLine("О вас:\n\nВведите своё имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите своё отчество (если есть): ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите свой рост: ");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите свой возраст: ");
            short age = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите свой любимый предмет: ");
            string favoriteSubject = Console.ReadLine();

            // Вводим значения соседа 
            Console.WriteLine("\nО вашем соседе:\n\nВведите имя соседа: ");
            string neighbourName = Console.ReadLine();
            Console.WriteLine("Введите фамилию соседа: ");
            string neighbourSurname = Console.ReadLine();
            Console.WriteLine("Введите отчество соседа (если есть): ");
            string neighbourPatronymic = Console.ReadLine();
            Console.WriteLine("Введите рост соседа: ");
            float neighbourHeight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите возраст соседа: ");
            short neighbourAge = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите любимый предмет соседа: ");
            string neighbourFavoriteSubject = Console.ReadLine();

            // Вводим общие значения
            Console.WriteLine("\nОб общем:\n\nВведите название вашего колледжа: ");
            string college = Console.ReadLine();
            Console.WriteLine("Введите вашу группу: ");
            string group = Console.ReadLine();
            Console.WriteLine("Введите ФИО куратора: ");
            string curatorFullName = Console.ReadLine();
            Console.WriteLine("Введите количество студентов в группе: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            // Экран подготовки вывода данных + ожидание когда введут любую клавишу
            Console.WriteLine("\n\nГотовы окунуться в мир наших итоговых данных? Если да, то нажмите на ENTER!");
            Console.ReadLine();

            // Очищаем консоль для красоты, а затем выводим все данные
            Console.Clear();

            Console.WriteLine(
                $"Ваше имя: {name}\n" +
                $"Ваша фамилия: {surname}\n" +
                $"Ваше отчество: {patronymic}\n" +
                $"Ваш рост: {height}\n" +
                $"Ваш возраст: {age}\n" +
                $"Ваш любимый предмет: {favoriteSubject}\n\n" +
                $"Имя вашего соседа: {neighbourName}\n" +
                $"Фамилия вашего соседа: {neighbourSurname}\n" +
                $"Отчество вашего соседа: {neighbourPatronymic}\n" +
                $"Рост вашего соседа: {neighbourHeight}\n" +
                $"Возраст вашего соседа: {neighbourAge}\n" +
                $"Любимый предмет вашего соседа: {neighbourFavoriteSubject}\n\n" +
                $"Ваш колледж: {college}\n" +
                $"Ваша группа: {group}\n" +
                $"Ваш куратор: {curatorFullName}\n" +
                $"Количество студентов в группе: {studentCount}\n\nЧтобы закрыть программу нажмите на ENTER.");

            // Ждёи, когда введут любую клавишу для закрытия программы
            Console.ReadLine();
        }
    }
}