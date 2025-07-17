

//MÉTODOS COM PARÂMETROS

double num1;
double num2;

Console.Write("Digite o primeiro número: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual operação? (* ou /): ");
string operacao = Console.ReadLine();


if (operacao == "*")
{
    double result = Multiplicar(num1, num2);
    Console.WriteLine($"O resultado da multiplicação entre {num1} e {num2} é:  {result}");
}
else
{
    double result = Divisao(num1, num2);
    Console.WriteLine($"O resultado da divisão entre {num1} e {num2} é:  {result}");
}


    




static double Multiplicar(double num1, double num2)
{
  double resultado =  num1* num2;
  return resultado;
}


static double Divisao(double num1, double num2)
{
    double resultado = num1 / num2;
    return resultado;
}


Console.ReadKey();