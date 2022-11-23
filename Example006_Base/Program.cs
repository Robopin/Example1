int a = 1;
int b = 10;
int c = 4;
int d = 6;
int e = 4;
int maxnumber = a;
if (a > maxnumber)
{
    maxnumber = a;
}
if (b > maxnumber)
{
    maxnumber = b;
}
if (c > maxnumber)
{
    maxnumber = c;
}
if (d > maxnumber)
{
    maxnumber = d;
}
if (e > maxnumber)
{
    maxnumber = e;
}
Console.Write("Максимальное число: ");
Console.WriteLine(maxnumber);