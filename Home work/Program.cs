//Задача 2: 
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

void SayMax(int max)
{
    Console.WriteLine("Максимальное число = " + max);
}
Console.WriteLine("Задача 2");
int a = 5, b = 7;
int c = 2, d = 10;
int e = -9, f = -3;
if (a > b) SayMax(a);
else SayMax(b);
if (c > d) SayMax(c);
else SayMax(d);
if (e > f) SayMax(e);
else SayMax(f);

//Задача 4
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Задача 4");
int num1 = 2, num2 = 3, num3 = 7;
int num11 = 44, num22 = 5, num33 = 78;
int num111 = 22, num222 = 3, num333 = 9;
int Max1 = num1, Max2 = num11, Max3 = num111;
if (num2 > Max1) Max1 = num2;
if (num3 > Max1) Max1 = num3;
if (num22 > Max2) Max2 = num22;
if (num33 > Max2) Max2 = num33;
if (num222 > Max3) Max3 = num222;
if (num333 > Max3) Max3 = num333;

SayMax(Max1);
SayMax(Max2);
SayMax(Max3);

//Задача 6
//4 -> да, -3 -> нет, 7 -> нет
Console.WriteLine("Задача 6");
int number1 = 4, number2 = -3, number3 = 7;

if (number1 % 2 == 0) Console.WriteLine(number1 + " " + "является четным");
else Console.WriteLine(number1 + " " + "является нечетным");
if (number2 % 2 == 0) Console.WriteLine(number2 + " " + "является четным");
else Console.WriteLine(number2 + " " + "является нечетным");
if (number3 % 2 == 0) Console.WriteLine(number3 + " " + "является четным");
else Console.WriteLine(number3 + " " + "является нечетным");