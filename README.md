1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);


2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];

int length = array.Length;
int index = 0;
int sum = 0;

while (index < length)
{
    array[index] = new Random().Next(0,10);
    Console.WriteLine(array[index]);
    sum = sum + array[index];
    index++;
}

Console.WriteLine($"Сумма положительных элементов массива = {sum}");


3. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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


4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] mass = new int[10];

int i = 0;
int count = 0;
int lenght = mass.Length;

while (i < lenght)
{
    mass[i] = new Random().Next(0,123);
    Console.WriteLine(mass[i]);
    if (mass[i] > 10 && mass[i] < 99) count = count + 1;
    i++;
}
Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");


5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] mass = new int[10];

int i = 0;
int A = 0; 
int lenght = mass.Length;

while (i < lenght)
{
    mass[i] = new Random().Next(0,10);
    Console.WriteLine(mass[i]);
    i++;
}

for (i = 0; i < lenght/2; i++) 
{
 A = mass[i] * (mass[lenght - i - 1]);
 Console.WriteLine($"Произведение пар числе в массиве равно = {A}");
}