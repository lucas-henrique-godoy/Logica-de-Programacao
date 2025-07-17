
Random randon = new Random();

bool jogarNovamente = true;
int min = 1;
int max = 100;
int chute;
int numero;
int tentativas;
string resposta;

while(jogarNovamente)
{
    chute = 0;
    tentativas = 0;
    numero = randon.Next(min, max + 1);
    resposta = "";

    while (chute != numero)
    {
        Console.WriteLine($"Adivinhe o número entre {min} e {max}: ");
        chute = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Chute: {chute}");

        if (chute > numero)
        {
            Console.WriteLine($"O número é menor que {chute}");
        }

        if (chute < numero)
        {
            Console.WriteLine($"O número é maior que {chute}");
        }

        tentativas++;
    }

    Console.WriteLine($"Número: {numero}");
    Console.WriteLine("Você venceu!");
    Console.WriteLine($"Tentativas:  {tentativas}");

    Console.WriteLine("Você gostaria de jogar novamente? (S/N): ");
    resposta = Console.ReadLine();
    resposta = resposta.ToUpper();

    if (resposta == "S")
    {
        jogarNovamente = true;
    }
    else if (resposta == "N") 
    {
        jogarNovamente = false;
    }
    else
    {
        Console.WriteLine("Você colocou uma opção errada,  digite S ou N");
    }
}

Console.WriteLine("Obrigado por jogar!");






Console.ReadKey();






















