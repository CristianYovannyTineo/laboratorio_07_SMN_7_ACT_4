// See https://aka.ms/new-console-template for more information

Console.Write(" Ingrese un número: ");
string Pr = Console.ReadLine();
if (int.TryParse(Pr, out int numero) && numero > 0)
{
     for (int i = 0; i < numero; i++)
     {
        for (int j = 0; j < numero * 2; j++)
        {
        Console.Write("*");
        }
        Console.WriteLine();
     }
}
