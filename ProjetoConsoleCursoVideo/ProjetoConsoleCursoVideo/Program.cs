
string nomeCompleto = "Lucas Godoy";
string numeroTelefone = "11-96862-0740";

//nomeCompleto = nomeCompleto.ToUpper();
//nomeCompleto = nomeCompleto.ToLower();
//Console.WriteLine(nomeCompleto);

//numeroTelefone = numeroTelefone.Replace("-", "");
//Console.WriteLine(numeroTelefone);

//Console.WriteLine(nomeCompleto.Length);

string primeroNome = nomeCompleto.Substring(0,6);
string ultimoNome = nomeCompleto.Substring(6, 5);

Console.WriteLine(primeroNome);
Console.WriteLine(ultimoNome);

Console.ReadKey();






















