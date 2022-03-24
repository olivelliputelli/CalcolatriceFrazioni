
namespace ClassiUtili
{
    public static class ClassA
    {
        public static int NumeroDiOccorrenzeCreate { get; set; } = 0;
        static ClassA()
        {
            NumeroDiOccorrenzeCreate++;
        }
    }
}
