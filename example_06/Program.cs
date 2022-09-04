int A = 3;
int B = 5;
int C = 8;
int D = 1;
int E = 4;

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;
if (D > max) max = D;
if (E > max) max = E;

Console.Write("max = ");
Console.WriteLine(max);
