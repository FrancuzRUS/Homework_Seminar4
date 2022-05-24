// 2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

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
