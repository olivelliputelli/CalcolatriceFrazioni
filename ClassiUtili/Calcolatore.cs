namespace ClassiUtili
{
    /// <summary>
    /// Tim Corei
    /// </summary>
    /// <seealso href="https://youtu.be/ub3P8c87cwk"/>
    public static class Calcolatore
    {
        public static double Più(double n1, double n2) => n1 + n2;
        public static double Meno(double n1, double n2) => n1 - n2;
        public static double Per(double n1, double n2) => n1 * n2;
        public static double Diviso(double n1, double n2)
        {
            if (n2 == 0) return 0;
            return n1 / n2;
        }
        public static double Modulo(double n)
        {
            if (n < 0) return -n;
            return n;
        }
    }
}
