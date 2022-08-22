/*
int number = Convert.ToInt32(Console.ReadLine());
double testResult = Math.Pow (number,2);
Console.WriteLine("result " + testResult);


//на вход 2 числа, вывод - max и min 
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("max = " + num1 + " min = " + num2);
}
else
{
    Console.WriteLine("max = " + num2 + " min = " + num1);
}
*/

//Max из трех чисел
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (num1>num2)
{
    max = num1;
}
else
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}
System.Console.WriteLine("Max value = " + max);