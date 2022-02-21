﻿
namespace ClassiUtili
{
    public class Frazione
    {
        public int Numeratore { get; set; } = 0;
        private int denominatore = 1;
        public int Denominatore
        {
            get { return denominatore; }
            private set
            {
                if (value == 0)
                    throw new ArgumentException("Denominatore ZERO!");
                denominatore = value;
            }
        }
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }
        public Frazione(int numeratore) : this(numeratore, 1) { }
        public Frazione(string s)
        {
            if (String.IsNullOrWhiteSpace(s)) return;

            string[] elementi = s.Split('/'); // "2/7" "5"

            Numeratore = int.Parse(elementi[0]);

            if (elementi.Length > 1)
                Denominatore = int.Parse(elementi[1]);
            else
                Denominatore = 1;
        }
        public Frazione() { }
        public static Frazione operator +(Frazione f1, Frazione f2)
        {
            return new Frazione(
               f1.Numeratore * f2.Denominatore + f1.Denominatore * f2.Numeratore,
               f1.Denominatore * f2.Denominatore);
        }
        public static Frazione operator *(Frazione f1, Frazione f2)
        {
            return new Frazione(
                f1.Numeratore * f2.Numeratore,
                f1.Denominatore * f2.Denominatore);
        }
        public static Frazione Reciproca(Frazione f) => new Frazione(f.Denominatore, f.Numeratore);
        public Frazione Semplifica()
        {
            int mcd = MCD(Numeratore, Denominatore);
            return new Frazione(Numeratore / mcd, Denominatore / mcd);
        }
        public int Segno() => Math.Sign(this.Numeratore * this.Denominatore);
        private int MCD(int n1, int n2)
        {
            for (int i = Math.Min(n1, n2); i > 1; i--)
                if (n1 % i == 0 && n2 % i == 0) return i;
            return 1;
        }
        private int MCM(int n1, int n2)
        {
            for (int i = Math.Max(n1, n2); i < n1 * n2; i++)
                if (i % n1 == 0 && i % n2 == 0) return i;
            return n1 * n2;
        }
    }
}
