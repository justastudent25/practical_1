using System.Runtime.InteropServices;


Console.WriteLine("1. Сложить 2 числа\r\n" +
    "2. Вычесть первое из второго\r\n" +
    "3. Перемножить два числа\r\n" +
    "4. Разделить первое на второе\r\n" +
    "5. Возвести в степень N первое число\r\n" +
    "6. Найти квадратный корень из числа\r\n" +
    "7. Найти 1 процент от числа\r\n" +
    "8. Найти факториал из числа\r\n" +
    "9. Выйти из программы");


bool isListening = true;
do
{
    ;
    Console.WriteLine("Введите команду:");
    int otvet = Convert.ToInt16(Console.ReadLine());
    if (otvet == 1)
    {
        Console.WriteLine("Введите первое число:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine(chislo + chislo2);
        continue;
    }
    else if (otvet == 2)
    {
        Console.WriteLine("Введите первое число:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine(chislo - chislo2);
        continue;
    }
    else if (otvet == 3)
    {
        Console.WriteLine("Введите первое число:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine(chislo * chislo2);
        continue;
    }
    else if (otvet == 4)
    {
        Console.WriteLine("Введите первое число:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine(chislo / chislo2);
        continue;
    }
    else if (otvet == 5)
    {
        Console.WriteLine("Введите первое число:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень в которую будет возводиться первое число:");
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine(Math.Pow(chislo, chislo2));
        continue;
    }
    else if (otvet == 6)
    {
        Console.WriteLine("Введите число из которого будем искать квадратный корень:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine(Math.Sqrt(chislo));
        continue;
    }
    else if (otvet == 7)
    {
        Console.WriteLine("Введите число из которого будем искать 1 процент:");
        float chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычесления:");
        Console.WriteLine((chislo * 1) / 100);
        continue;
    }
    else if (otvet == 8)
    {
        Console.WriteLine("Введите число, которое будет переведено в факториал:");
        int chislo = Convert.ToInt32(Console.ReadLine());
        int f = 1;
        Console.WriteLine("Результат вычесления:");
        while (chislo > 1)
        {
            f *= chislo;
            chislo -= 1;
        }
        Console.WriteLine(f);
        continue;
    }
    else if (otvet == 9)
    {
        isListening = false;
    }
    else
    {
        Console.WriteLine("Вы ввели неправильную команду. Попробуйте ещё раз.");
        continue;
    }
}
while (isListening == true);

