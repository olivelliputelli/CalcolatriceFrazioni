using ClassiUtili;

//for (int i = 33; i < 126; i++)
//{
//    Console.WriteLine($"{i}\t{(char)i}");
//}

GeneratorePassword g1 = new(TipoPassword.Cifre) { LunghezzaMinima = 6 };
GeneratorePassword g2 = new(TipoPassword.Lettere) { LunghezzaMinima = 6};
GeneratorePassword g3 = new(TipoPassword.CaratteriSpeciali) { LunghezzaMinima = 6 };


Console.WriteLine(g1.Alfabeto);
Console.WriteLine(g2.Alfabeto);
Console.WriteLine(g3.Alfabeto);