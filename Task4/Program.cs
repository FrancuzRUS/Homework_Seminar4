// 4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] mass = new int[123];

int i = 0;
int count = 0;
int lenght = mass.Length;

while (i < lenght)
{
    mass[i] = new Random().Next(0,100);
    Console.WriteLine(mass[i]);
    if (mass[i] > 9 && mass[i] < 100) count = count + 1;
    i++;
}
Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");
