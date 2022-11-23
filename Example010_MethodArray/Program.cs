int []array = {11, 32, 45, 23, 4, 23, 54, 6, 7, 5};
int n = array.Length;
int find = 23;

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