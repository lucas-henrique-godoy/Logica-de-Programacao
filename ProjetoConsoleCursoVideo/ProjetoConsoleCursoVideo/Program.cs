


/*
    nested loops
 
 */

Console.Write("Quantas linhas?: ");
int linhas = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantas colunas ?: ");
int colunas = Convert.ToInt32(Console.ReadLine());

Console.Write("Qua o símbolo?: ");
string simbolo = Console.ReadLine();


for (int i = 0; i < linhas; i++)
{
    for(int j= 0; j < colunas; j++)
    {
        Console.Write(simbolo);
    }

    Console.WriteLine();
}









Console.ReadKey();






















