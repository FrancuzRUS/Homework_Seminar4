// 5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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