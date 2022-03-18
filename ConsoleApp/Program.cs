using ClassiUtili;


GeneratorePassword g = new() { LunghezzaMinima = 6 };

Console.WriteLine(g.NuovaPassword(12));