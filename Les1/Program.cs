//Console.WriteLine("hello world1");

/*
int value = 100;
Console.WriteLine(value);

double d = 5.55;
char c = '!';
bool b = true;
Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(b);
*/
/*
int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);

long l1 = 6;
long sum2 = l1 + i1;
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 + i1;

int product1 = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;

Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);


int quotient = i1 / i2;
 Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1;
 Console.WriteLine(quotient2);
 */

/*
int a = 5;
int b = 7;

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
*/
/*
int a = 5;
int b = 7;
int c = 9;
int d = 4;
int e = 10;

int max = a;

if (b > max) { max = b; }
if (c > max) { max = c; }
if (d > max) { max = d; }
if (e > max) { max = e; }
Console.WriteLine(max);
*/
/*
int n = 100;
int i = 1;

while (i <= n) { Console.Write(i); Console.Write(' '); i = i + 1; }
*/

//дополнительно
/*
Console.WriteLine("введите ваше имя: ");
string username = Console.ReadLine();
Console.WriteLine("Привет, ");
Console.WriteLine(username);
*/
/*
int numberA = 70;
int numberB = 5;
//Console.WriteLine(numberA + numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/
/*
double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA / numberB);
*/
/*
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/

/*
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура это же МАША");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
*/

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");
Console.WriteLine(max);