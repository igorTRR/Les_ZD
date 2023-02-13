
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
} 
float[]DiffNum = GetArray(5, 101, 999);
Console.WriteLine(String.Join(", ",DiffNum));
 int maxV = 0;
 int minV = 0;

 for (i =0; i< DiffNum.Length; i++)
 {
    if (DiffNum[i] >maxV) maxV = DiffNum[i];
    if (DiffNum[i] <mixV) mixV = DiffNum[i];
 }
     for (int i = 0; i < d.Length; i++)
      Console.Write(" " +DiffNum[i]);
Console.WriteLine();
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " +min);
Console.WriteLine("Разница максимального и минимального:  "+(max - min));
Console.Write();