
namespace ClassiUtili
{
    public class Frazione
    {
        public int Numeratore { get; private set; } = 0;

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
            int mcd = MCD(numeratore, denominatore);

            Numeratore = numeratore / mcd;
            Denominatore = denominatore / mcd;
        }

        public Frazione() : this(0, 1) { }

        public Frazione Somma(Frazione f)
        {
            return new Frazione(
                this.Numeratore * f.Denominatore + this.Denominatore * f.Numeratore,
                this.Denominatore * f.Denominatore);
        }
        public Frazione Prodotto(Frazione f)
        {
            return new Frazione(
                this.Numeratore * f.Numeratore,
                this.Denominatore * f.Denominatore);
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
