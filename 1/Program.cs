using System;

public class Answer
{

public static int WriteNumber(string message)
{
Console.WriteLine(message);
string result= Console.ReadLine();
int res;
bool isnumber = int.TryParse( result , out res);
if (!isnumber)
{
    Console.WriteLine("Введено не число");
    return 0;
}
return res;
}

public static void ReturnNaturalNumber(int M, int N)
{
 int i=1;
 if (M>1) 
 {
    i=M;
 }
 for (int q =i; q<=N; q++)
 {
    Console.Write($"{q}");
    if (q<N)
    {
        Console.Write(", ");
    }
 }

}
    public static void Main(string[] args)
    {
        int M=WriteNumber("Введите M" );
        int N=WriteNumber("Введите N" );
        ReturnNaturalNumber(M, N);
    }
}