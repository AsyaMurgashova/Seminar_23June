// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// ПРосим у пользователя ввести число, затем возводим его в квадрат и выводим его значение.
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int q = number * number;
// Console.WriteLine(number + " -> " + q);



// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.Write("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// if (number_1 == (number_2 * number_2))
// Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> " + "yes");
// else
// Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> " + "no");




Console.Write("введите день: ");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day == 1)
      Console.WriteLine("Monday");
    else if (day == 2)
      Console.WriteLine("Tessday");
    else if (day == 3)
      Console.WriteLine("Wednesday");
    else if (day == 4)
      Console.WriteLine("Thursday");
     else if (day == 5)
      Console.WriteLine("Friday");
    else if (day == 6)
      Console.WriteLine("Saturday");
    else if (day == 7)
      Console.WriteLine("Sunday");
    else
      Console.WriteLine("Incorrect day");
