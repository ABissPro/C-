/*
int number = Convert.ToInt32(Console.ReadLine());
double testResult = Math.Pow (number,2);
Console.WriteLine("result " + testResult);
*/

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