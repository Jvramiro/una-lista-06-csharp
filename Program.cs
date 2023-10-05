int[] vetor = new int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine($"Primeiro valor da sequência: {vetor[0]}");

int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

Console.WriteLine($"\nPrimeiro valor da matriz: {matriz[0,0]}");
Console.WriteLine($"Primeiro valor da segunda linha da matriz: {matriz[1,0]}");

int[,,] cubo = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

Console.WriteLine($"\nPrimeiro valor do cubo: {cubo[0,0,0]}");
Console.WriteLine($"Primeiro valor da segunda altura do cubo: {cubo[1,0,0]}");
Console.WriteLine($"Primeiro valor da segunda profundidade do cubo: {cubo[0,1,0]}");