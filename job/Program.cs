using System.Data;
using System.Numerics;
string[] Matrix(int n)
{
    string[] strArr = new string[n];
    for (int i = 0; i < n; i++)
    {
    strArr[i] = Console.ReadLine()!;
    }
    return strArr;
}


string[] Filtr (int n, string[] strArr)
{
 string[] Arr = new string[n];
 for (int i = 0; i < n; i++) 
 {
    if (strArr[i].Length < 4)
    
    Arr[i] = strArr[i];
    
 }
  return Arr;
 }


Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine()!);
string[] kool = Matrix(n);
Filtr(n, kool);
string[] kool2 = Filtr(n, kool);
Console.Write("[{0}]  ", string.Join(", ", kool));
Console.Write("->  ");
Console.Write("[{0}]  ", string.Join(", ", kool2));