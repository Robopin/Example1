int Max(int ag1, int ag2, int ag3)
{
    int result = ag1;
    if (ag2 > result) result = ag2;
    if (ag3 > result) result = ag3;
    return result;
}


int a1 = 17;
int b1 = 7;
int c1 = 1;
int a2 = 54;
int b2 = 71;
int c2 = 100;
int a3 = 27;
int b3 = 77;
int c3 = 13;

int max = Max(Max(a1,a2,a3), 
          Max(b1,b2,b3), 
          Max(c1,c2,c3));

Console.Write("max = ");
Console.WriteLine(max);