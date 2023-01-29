int[] array = { 11, 22, 34, 64, 57, 36, 57, 98 };

int n = array.Length;
int find = 57;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}