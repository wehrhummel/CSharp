// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

int number = 891;
int first_digit = number / 100;
int third_digit = number % 10;
int number_after = first_digit * 10 + third_digit;
Console.WriteLine(number_after);
