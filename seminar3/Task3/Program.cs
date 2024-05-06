// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int size = 7;
int minVal = -15;
int maxVal = 10;
int [] array = new int [size];
int [] result = new int [array.Length / 2];

for (int i = 0; i < size; i++)  {
    array[i] = new Random().Next(minVal, maxVal + 1);
}

foreach (int a in array)   {
    Console.Write($"{a} ");
}

for (int i = 0; i < array.Length / 2; i++)  {
    result[i] = array[i] * array[array.Length - 1 - i];
}
Console.WriteLine();

foreach (int r in result)   {
    Console.Write($"{r} ");
}