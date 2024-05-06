// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/Нет.
 
int [] array = new int [] {2, 5, 0, -4, 20, 24, 10, 17};
int elemToFind = 20;
// bool isFound = false;
string flag = "Нет";
foreach (int e in array)    {
    if (e == elemToFind)    {
        flag = "Да";
        break;
    }
}
Console.WriteLine(flag);