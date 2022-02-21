using ClassiUtili;

Frazione f1 = new ("2 / 3"); 
Frazione f2 = new ("3"); 

// 2/3 -> 3/2
Frazione f5 = Frazione.Reciproca(f1);

Console.WriteLine($"{f5.Numeratore}/{f5.Denominatore}"); // 11/6

