// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]
int [] array = new int [10];
for (int i = 0; i < 10; i++)  {
    array[i] = new Random().Next(-10, 11);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)    {
    // array[j] = - array[j];
    array[j] *= -1;
    Console.Write($"{array[j]} ");
}
 
