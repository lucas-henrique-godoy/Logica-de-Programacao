
/*
 Operadores Lógicos

&& (AND)
|| (OR)
!  (NOT)
 
 */

Console.WriteLine("Digite sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você é administrador?");
bool admin = Convert.ToBoolean(Console.ReadLine());

if (idade >= 18 || admin)
{
    Console.WriteLine("Você pode entrar no sistema!");
}
else
{
    Console.WriteLine("Você não pode entrar no sistema!");
}

    Console.ReadKey();






















