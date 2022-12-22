// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int DataEntry(string str)
{
    System.Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] FillArray(int num)
{
    Console.WriteLine($"Заполните массив");
    int[] nums = new int[num];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = int.Parse(Console.ReadLine());
    }
    return nums;
}

void CheckNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    System.Console.WriteLine(count);
}

int number = DataEntry("Введите количество чисел: ");
int[] array = FillArray(number);
System.Console.WriteLine($"[{string.Join(", ", array)}] -> ");
CheckNumbers(array);