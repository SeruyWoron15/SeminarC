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

static int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

    public static void Main(string[] args)
    {
        int M=WriteNumber("Введите M" );
        int N=WriteNumber("Введите N" );
        Console.WriteLine(A(N, M));
    }
}