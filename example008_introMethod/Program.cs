int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a = 1;
int b = 52;
int c = 6;
int d = 8;
int e = 34;
int f = 7;
int a1 = 12;
int b1 = 2;
int c1 = 63;

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(a1, b1, c1);
// int max = Max(max1, max2, max3);
int max = Max(Max(a, b, c), Max(d, e, f), Max(a1, b1, c1));

Console.Write($"{max}");
