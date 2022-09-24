Console.Clear();


void task1()
{
  Console.Clear ();
  Console.WriteLine ("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
  Console.WriteLine ("Введите трехзначное число...");
  int Number = int.Parse(Console.ReadLine() ?? "0");
  if ((Number >= 999) || (Number <= 99))
  {
    Console.WriteLine ("ОШИБКА: Вы ввели не трехзначное число");
  }
  else
  {
    Console.WriteLine ($"Ответ: {Number / 10 % 10}");
  }
}
       

void task2()
{
  Console.Clear ();
  Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
  Console.WriteLine("Введите число...");
  int Num = Convert.ToInt32(Console.ReadLine());
  int Number2;
  if (Num < 0) Num=-Num;
  if (Num < 100) Console.WriteLine("ОШИБКА: Третьей цифры нет!");
  else
  {
    while (Num > 1000)
    {
      Num = Num/10;
    }
    Number2 = Num%10;
    Console.WriteLine($"ОТВЕТ: {Number2}");
  }
}


void task3()
{
  Console.Clear ();
  Console.WriteLine ("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
  Console.WriteLine ("Введите день недели...");
  int dayofweek = int.Parse (Console.ReadLine() ?? "0");
  if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("ОТВЕТ: Выходной день.");
  else if (dayofweek <= 5) Console.WriteLine ("ОТВЕТ: Будний день.");
  else if (dayofweek > 7) Console.WriteLine ("ОШИБКА: В неделе всего 7 дней!");
}

//Реализация методов-задач
Console.WriteLine ("Введите номер задачи от 1 до 3");
int Num = int.Parse(Console.ReadLine() ?? "0"); //int.Parse тот же Convert.ToInt32, только вроде бы работает быстрее
if (Num == 1) task1();
if (Num == 2) task2();
if (Num == 3) task3();
if (Num != 1 && Num != 2 && Num != 3) Console.WriteLine("Неверное значение. Введите только цифру 1, 2 или 3.");