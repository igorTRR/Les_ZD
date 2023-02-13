 void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} ");
         }
    Console.WriteLine();
    }
}
int[,]matrix = new int[3, 4];
PrintArray(matrix);

 void FillArray(int[,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for(int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(1,10);
        }
   Console.WriteLine();
     }
 }
Console.Clear();

int Factorial(int n)

{
    if( n==1 ) return 1;
    else return n*Factorial(n-1);
}
Console.Write( "Введите число n: " );
int n =int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(Factorial(3));