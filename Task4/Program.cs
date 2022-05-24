// 4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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
