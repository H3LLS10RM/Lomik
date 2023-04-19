/* Вариант 24 */
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

dynamic vneurochka = new System.Dynamic.ExpandoObject();
    Console.Write("Отметка: ");
    vneurochka.Otmetka = Console.ReadLine();
    Console.Write("Дата: ");
    vneurochka.Data = Console.ReadLine();
    Console.Write("Преподаватель: ");
    vneurochka.Prepod = Console.ReadLine();
    Console.Write("Студент: ");
    vneurochka.Student = Console.ReadLine();
pp(vneurochka);
    
    Console.Write($"\nВывод:\nОтметка: {vneurochka.Otmetka}\nДата: {vneurochka.Data}\nПреподаватель: {vneurochka.Prepod}\nСтудент: {vneurochka.Student}\nИмя дисциплины: {vneurochka.Name}\nСокращённо: {vneurochka.Sokr}");

/* Вариант 1 */

dynamic zanyatie = new System.Dynamic.ExpandoObject();
Console.Write("Время: ");
zanyatie.Time = Console.ReadLine();
pp(zanyatie);

Console.Write($"Время: {zanyatie.Time}\nИмя дисциплины: {vneurochka.Name}\nСокращённо: {vneurochka.Sokr}");



/* Вариант 2 */
dynamic Auditory = new System.Dynamic.ExpandoObject();
Console.Write("Название аудитории: ");
Auditory.Name = Console.ReadLine();
Console.Write("Количество посадочных мест: ");
Auditory.Kolvo = Console.ReadLine();
Console.Write("Колличество окон: ");
Auditory.Okna = Console.ReadLine();
Console.WriteLine(Auditory.Name, Auditory.Kolvo, Auditory.Okna);
/* Вариант 3 */
dynamic Disciple = new System.Dynamic.ExpandoObject();
Console.Write("Название: ");
Disciple.Name = Console.ReadLine();
Console.Write("Сокращение: ");
Disciple.Sokr = Console.ReadLine();
Console.WriteLine(Disciple.Name, Disciple.Sokr);

void pp(dynamic vv)
{
    Console.Write("Название: ");
    vv.Name = Console.ReadLine();
    Console.Write("Сокращение: ");
    vv.Sokr = Console.ReadLine();
}