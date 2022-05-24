// 3. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] mass = new int[10];

int i = 0;
int even = 0; 
int count = 0; 
int lenght = mass.Length;

while (i < lenght)
{
    mass[i] = new Random().Next(100,999);
    Console.WriteLine(mass[i]);
    if (mass[i] % 2 == 0) even = even + 1;
    else count = count + 1; 
    i++;
}

Console.WriteLine($"Количество четных числе в массиве = {even}");
Console.WriteLine($"Количество НЕ четных числе в массиве = {count}");

