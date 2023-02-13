double Factorial(int n)

{
    if( n==1 ) return 1;
    else return n*Factorial(n-1);
}
for (int i=1; i<20; i++)
{

}
Console.Write( "Введите число n: " );
int n =int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"{n}! = {Factorial(n)}");