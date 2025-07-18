

//  TRY CATCH FINALLY


int num1;
int num2;
int num3;
int resultado;


try
{
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToInt32(Console.ReadLine());


    resultado = num1 / num2;

    Console.WriteLine($"  {num1} / {num2} = {resultado} ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Fim!");
}







Console.ReadKey();