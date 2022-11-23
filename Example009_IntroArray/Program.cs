int Max(int ag1, int ag2, int ag3)
{
    int result = ag1;
    if (ag2 > result) result = ag2;
    if (ag3 > result) result = ag3;
    return result;
}
int []array = {13,22,32,4,65,64,7,98,93};
array[0] = 6;
Console.WriteLine(array[0]);

int res = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );
    Console.WriteLine(res);