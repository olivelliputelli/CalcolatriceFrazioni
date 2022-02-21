using ClassiUtili;

Frazione f1 = new Frazione(12,8); // 12/8
Frazione f2 = new Frazione(2,6); // 2/6

Frazione f3 = f1.Prodotto(f2);

Console.WriteLine($"{f3.Numeratore}/{f3.Denominatore}"); // 11/6


