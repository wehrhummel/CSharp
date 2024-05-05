int[] arr = {14, 45, 23, 12, 34};
int max = arr[0];
int i = 0;
while (i < arr.Length)  {
    if (arr[i] > max)   {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

int j = 0;
max = arr[0];
for (j = 0; j < arr.Length; j++)    {
    if (arr[j] > max)   {
        max = arr[j]; 
    }
}
Console.WriteLine(max);

max = arr[0];
foreach (int k in arr)    {
    if (k > max)   {
        max = k; 
    }
}
Console.WriteLine(max);