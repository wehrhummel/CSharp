// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень,
// равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

int number = 254;
int second_digit = number / 10 % 10;
int third_digit = number % 10;
double result = Math.Pow(second_digit, third_digit);
Console.WriteLine(result);