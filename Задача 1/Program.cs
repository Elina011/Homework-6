// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int m = EnterData("Введите кол-во чисел, которые хотите указать ");
int[] array = new int[m];
int count = 0;
for (int i = 0; i < m; i++)
{
    array[i] = EnterData("Введите число ");
    if (array[i] > 0)
    {
       count ++; 
    }
}
 Console.WriteLine($"{String.Join(", ", array)} -> {count}");