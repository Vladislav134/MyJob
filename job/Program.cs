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

void PrintMatrix (string[] strArr)
{
    for (int i = 0; i < strArr.Length; i++)
    Console.Write($"\"{strArr[i]}\"  ");
}