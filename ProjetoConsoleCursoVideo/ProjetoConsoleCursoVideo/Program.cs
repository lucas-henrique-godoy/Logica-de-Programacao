

Console.WriteLine("Qual é o dia da semana?");
string dia = Console.ReadLine();

switch(dia)
{
    case "Segunda":
        Console.WriteLine("Hoje é Segunda");
        break;
    case "Terça":
        Console.WriteLine("Hoje é Terça");
        break;
    case "Quarta":
        Console.WriteLine("Hoje é Quarta");
        break;
    case "Quinta":
        Console.WriteLine("Hoje é  Quinta");
        break;
    case "Sexta":
        Console.WriteLine("Hoje é Sexta");
        break;
    case "Sabado":
        Console.WriteLine("Hoje é Sábado");
        break;
    case "Domingo":
        Console.WriteLine("Hoje é Domingo");
        break;
    default:
        Console.WriteLine($"{dia} não é um dia da semana!");
        break;
}


Console.ReadKey();






















