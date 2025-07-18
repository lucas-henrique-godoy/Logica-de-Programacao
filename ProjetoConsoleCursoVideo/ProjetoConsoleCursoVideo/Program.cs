

//  Array multidimensional = array com duas dimensões;
//  Array bidimensional;



int[,] numeros = new int[3, 6]
{
    { 1,2,3, 11, 22, 33 },
    { 4,5,6, 55, 66, 77 },
    { 7,8,9, 76, 85, 99 },
    
};

for (int i = 0; i < 3; i++)
{
   for (int j = 0; j < 6; j++)
   {
        Console.Write(numeros[i,j] + " ");
   }

    Console.WriteLine();
}




Console.ReadKey();