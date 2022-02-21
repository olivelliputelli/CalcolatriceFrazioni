using ClassiUtili;

Frazione f1 = new Frazione("2 / 3"); // 12/8
Frazione f2 = new Frazione("3"); // 2/6

// 2/3 -> 3/2
Frazione f5 = Frazione.Reciproca(f1);

Console.WriteLine($"{f5.Numeratore}/{f5.Denominatore}"); // 11/6

