void sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
}
int n;
Console.WriteLine("Введите число элементов массива");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
sort(array);
int length = 1;
int max_len = 1;
int start = 0;
int end = 0;
int max_start = 0;
int max_end = 0;
int k = 0;
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] == array[i + 1])
    {
        end = i + 1;
        continue;
    }
    if (array[i] == array[i + 1] - 1)
    {
        length++;
        end = i + 1;
    }
    else
    {
        if (max_len < length)
        {
            max_len = length;
            max_start = start;
            max_end = end;
        }
        length = 1;
        start = i + 1;
        k = 1;
    }
}
if (k == 0)
    max_end = end;
int[] array1 = { max_start, max_end };
for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}
