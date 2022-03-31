﻿
namespace ClassiUtili
{
    /// <summary>
    /// Classe principale <c>Frazione</c>.
    /// Contiene metodi per svolgere operazioni sulle frazioni.
    /// </summary>
    /// <seealso href="https://youtu.be/WDTLHUvrZp4"/>
    /// <seealso href="https://youtu.be/DCtb8NVnBQM"/>
    /// <seealso href="https://youtu.be/1uGNUOTxp7o"/>
    /// <seealso href="https://youtu.be/Rv-16CYT65U"/>
    /// <seealso href="https://youtu.be/BA96EyQZESI"/>
    public class Frazione
    {
        /// <summary>
        /// Numeratore della frazione
        /// </summary>
        public int Numeratore { get; set; } = 0;
        private int _denominatore = 1;
        /// <summary>
        /// Denominatore della frazione
        /// </summary>
        /// <exception cref="System.ArgumentException">
        /// Lanciata quando il denominatore è 0.
        /// </exception>
        public int Denominatore
        {
            get => _denominatore;
            private set
            {
                if (value == 0)
                    throw new ArgumentException("Denominatore ZERO!");
                _denominatore = value;
            }
        }

        /// <summary>
        /// Costruire una frazione da due numeri.
        /// </summary>
        /// <param name="numeratore">Il Numeratore della frazione.</param>
        /// <param name="denominatore">Il Denominatore della frazione.</param>
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }
        /// <summary>
        /// Costruisce una frazione a partire da un numero intero.
        /// </summary>
        /// <param name="numero">Un numero intero.</param>
        public Frazione(int numero) : this(numero, 1) { }
        /// <summary>
        /// Costruire una frazione da una stringa.
        /// </summary>
        /// <param name="s">La stringa che rappresenta la frazione.</param>
        public Frazione(string s)
        {
            if (String.IsNullOrWhiteSpace(s)) return;

            string[] elementi = s.Split('/'); // ["2","7"] oppure ["5"]

            Numeratore = int.Parse(elementi[0]);

            if (elementi.Length == 1) // "5"
                Denominatore = 1;
            else
                Denominatore = int.Parse(elementi[1]); // "2/7"
        }
        /// <summary>
        /// Costruisce la frazione 0/1.
        /// </summary>
        public Frazione() { }

        /// <summary>
        /// Operatore + unario.
        /// </summary>
        /// <param name="f">Una frazione.</param>
        /// <returns>La frazione</returns>
        public static Frazione operator +(Frazione f) => f;
        /// <summary>
        /// Operatore - unario.
        /// </summary>
        /// <param name="f">Una frazione.</param>
        /// <returns>Restituisce la frazione opposta.</returns>
        public static Frazione operator -(Frazione f) => new(-f.Numeratore, f.Denominatore);
        /// <summary>
        /// Somma due frazioni <paramref name="f1"/> e <paramref name="f2"/> 
        /// e restituisce il risultato.
        /// es. <c>var f = f1 + f2;</c>
        /// </summary>
        /// <param name="f1">Una frazione.</param>
        /// <param name="f2">Una frazione.</param>
        /// <returns>La somma di due frazioni.</returns>
        /// <example>
        /// <code>
        /// var a = new Frazione(5);
        /// var b = new Frazione(6, 2);
        /// var c = a + b;
        /// </code>
        /// </example>
        /// <see href = "https://github.com" > GitHub </see>
        public static Frazione operator +(Frazione f1, Frazione f2)
        {
            return new Frazione(
               f1.Numeratore * f2.Denominatore + f1.Denominatore * f2.Numeratore,
               f1.Denominatore * f2.Denominatore);
        }

        /// <summary>
        /// Sottrae da una frazione <paramref name="f1"/> una frazione <paramref name="f2"/> 
        /// e restituisce il risultato.
        /// </summary>
        /// <param name="f1">Una frazione.</param>
        /// <param name="f2">Una frazione.</param>
        /// <returns>La differenza di due frazioni.</returns>
        public static Frazione operator -(Frazione f1, Frazione f2) => f1 + (-f2);
        /// <summary>
        /// Moltiplica due frazioni <paramref name="f1"/> e <paramref name="f2"/> 
        /// e restituisce il risultato.
        /// </summary>
        /// <param name="f1">Una frazione.</param>
        /// <param name="f2">Una frazione.</param>
        /// <returns>Il prodotto di due frazioni.</returns>
        public static Frazione operator *(Frazione f1, Frazione f2)
        {
            return new Frazione(
                f1.Numeratore * f2.Numeratore,
                f1.Denominatore * f2.Denominatore);
        }
        /// <summary>
        /// Divide due frazioni <paramref name="f1"/> e <paramref name="f2"/> 
        /// e restituisce il risultato.
        /// </summary>
        /// <param name="f1">Una frazione.</param>
        /// <param name="f2">Una frazione</param>
        /// <returns>Il rapporto di due frazioni.</returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown quando il denominatore è 0.
        /// </exception>
        public static Frazione operator /(Frazione f1, Frazione f2)
        {
            if (f2.Numeratore == 0) throw new DivideByZeroException("Divisione per ZERO!");
            return new Frazione(f1.Numeratore * f2.Denominatore, f1.Denominatore * f2.Numeratore);
        }
        public static Frazione operator ++(Frazione f) => f + 1;
        public static Frazione operator --(Frazione f) => f - 1;
        public static implicit operator Frazione(int n) => new Frazione(n);
        public static explicit operator Frazione(string n) => new Frazione(n);
        public static bool operator ==(Frazione f1, Frazione f2)
            => f1.Numeratore * f2.Denominatore == f2.Numeratore * f1.Denominatore;
        public override bool Equals(object? obj)
        {
            return (Frazione)obj == this;    
        }
        public static bool operator !=(Frazione f1, Frazione f2) => !(f1 == f2);
        public static bool operator <(Frazione f1, Frazione f2)
        {
            if (f1.Numeratore * f2.Denominatore < f2.Numeratore * f1.Denominatore) return true;
            return false;
        }
        public static bool operator >(Frazione f1, Frazione f2)
        {
            if (f1 == f2) return false;
            return !(f1 < f2);
        }
        /// <summary>
        /// Confronta <paramref name="f1" /> e <paramref name="f2" />. 
        /// </summary>
        /// <param name="f1">Una frazione.</param>
        /// <param name="f2">Una frazione.</param>
        /// <returns>true se f1 &lt;= f2 false altrimenti.</returns>
        public static bool operator <=(Frazione f1, Frazione f2) => !(f1 > f2);
        public static bool operator >=(Frazione f1, Frazione f2) => !(f1 < f2);
        /// <summary>
        /// Necessario per poter operare sulla forma come numero razionale 
        /// delle frazioni.
        /// </summary>
        /// <param name="n"></param>
        public static explicit operator double(Frazione n)
            => n.Numeratore / (double)n.Denominatore;
        /// <summary>
        /// Restituisce la frazione reciproca di <paramref name="f"/>.
        /// </summary>
        /// <returns>La frazione reciproca.</returns>
        public Frazione Reciproca() => new(this.Denominatore, this.Numeratore);
        public static Frazione Reciproca(Frazione f) => new(f.Denominatore, f.Numeratore);
        /// <summary>
        /// Semplifica ai minimi termini una frazione.
        /// </summary>
        /// <returns>Restituisce una frazione <paramref name="f"/> semplificata.</returns>
        public Frazione Semplifica()
        {
            int mcd = Mcd(Numeratore, Denominatore);
            return new Frazione(Numeratore / mcd, Denominatore / mcd);
        }
        /// <summary>
        /// Il segno della frazione.
        /// </summary>
        /// <returns>+1 positiva, -1 negativa oppure 0</returns>
        public int Segno() => Math.Sign(this.Numeratore * this.Denominatore);
        /// <summary>
        /// <see href="https://it.wikipedia.org/wiki/Algoritmo_di_Euclide">Algoritmo di Euclide</see> per calcolare il massimo comune divisore tra due interi <paramref name="n1"/> e <paramref name="n2"/>.
        /// </summary>
        /// <param name="n1">Un intero.</param>
        /// <param name="n2">Un intero.</param>
        /// <returns>Il MCD di n1 e n2</returns>
        /// <seealso cref="Frazione.Mcm(int, int)"/>
        private static int Mcd(int n1, int n2)
        {
            int temp;
            while (n2 != 0)
            {
                temp = n2; n2 = n1 % n2; n1 = temp;
            }
            return n1;
        }
        /// <summary>
        /// Calcola il minimo comune multiplo tra due interi <paramref name="n1"/> e <paramref name="n2"/>
        /// </summary>
        /// <param name="n1">Un intero.</param>
        /// <param name="n2">Un intero.</param>
        /// <returns>Il mcm di n1 e n2</returns>
        /// <seealso cref="Frazione.Mcd(int, int)"/>
        private static int Mcm(int n1, int n2)
        {
            for (int i = Math.Max(n1, n2); i < n1 * n2; i++)
                if (i % n1 == 0 && i % n2 == 0) return i;
            return n1 * n2;
        }
        /// <summary>
        /// Overload del metodo.
        /// </summary>
        /// <returns>Rappresentazione di una frazione come stringa.</returns>
        public override string ToString()
        {
            Mcd(3, 4);
            if (Numeratore == 0) return "0";
            return String.Concat((this.Segno() < 0) ? "-" : "", (Denominatore == 1) ? $"{Math.Abs(Numeratore)}"
                : $"{Math.Abs(Numeratore)}/{Math.Abs(Denominatore)}");
        }
    }
}
