## Программа ввода и вывода данных

Описание:

Это консольное приложение на языке C# для ввода и вывода информации о пользователе, его соседе и их общей учебной группе. 

Функционал:

• Ввод данных:
  * Ввод имени, фамилии, отчества, роста, возраста и любимого предмета пользователя.
  * Ввод аналогичных данных для соседа пользователя.
  * Ввод названия колледжа, группы, ФИО куратора и количества студентов в группе.
• Вывод данных: 
  * Отображение всей введенной информации о пользователе, соседе и группе в удобочитаемом формате.
  * Приятное оформление вывода с использованием форматирования строк.

Использование:

1. Запустите приложение.
2. Введите запрашиваемые данные о себе и соседе, а также общие данные о группе.
3. Нажмите ENTER для отображения введенных данных.
4. Нажмите ENTER снова, чтобы закрыть приложение.

Пример работы:

```
О вас:

Введите своё имя: John
Введите свою фамилию: Doe
Введите своё отчество (если есть): 
Введите свой рост: 180
Введите свой возраст: 20
Введите свой любимый предмет: Math

О вашем соседе:

Введите имя соседа: Jane
Введите фамилию соседа: Doe
Введите отчество соседа (если есть): 
Введите рост соседа: 175
Введите возраст соседа: 21
Введите любимый предмет соседа: Literature

Об общем:

Введите название вашего колледжа: University of California
Введите вашу группу: CS101
Введите ФИО куратора: Professor Smith
Введите количество студентов в группе: 25

Готовы окунуться в мир наших итоговых данных? Если да, то нажмите на ENTER!

Ваше имя: John
Ваша фамилия: Doe
Ваше отчество: 
Ваш рост: 180
Ваш возраст: 20
Ваш любимый предмет: Math

Имя вашего соседа: Jane
Фамилия вашего соседа: Doe
Отчество вашего соседа: 
Рост вашего соседа: 175
Возраст вашего соседа: 21
Любимый предмет вашего соседа: Literature

Ваш колледж: University of California
Ваша группа: CS101
Ваш куратор: Professor Smith
Количество студентов в группе: 25

Чтобы закрыть программу нажмите на ENTER.
```

Комментарии:

• Приложение демонстрирует базовые операции с консольным вводом и выводом данных.
• Используются различные типы данных (string, float, short, int) для хранения информации.
• Приложение демонстрирует как использовать Console.ReadLine() для получения ввода от пользователя и Console.WriteLine() для вывода информации на экран.
• Приложение использует форматирование строк ($"{name}") для красивого и читаемого вывода.
• Приложение использует Console.Clear() для очистки консоли перед выводом данных.
