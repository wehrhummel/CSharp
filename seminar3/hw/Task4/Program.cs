// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться 
// на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// 425 => [4 2 5] 8741 => [8 7 4 1] 4 => [4]

int N = 425;
int nTemp = N;
int degree = 1;
while (nTemp / 10 > 0)  {
    nTemp /= 10;
    degree += 1;
}

int [] array = new int[degree];
for (int i = degree - 1; i >= 0; i--)    {
    array[i] = N % 10;
    N /= 10;
}
Console.Write('[');
for (int i = 0; i < array.Length; i++)    {
    if (i < array.Length - 1 && array.Length > 1)   {
        Console.Write($"{array[i]} ");
    }
    else    {
    Console.Write($"{array[i]}");
    }
}
Console.Write(']');