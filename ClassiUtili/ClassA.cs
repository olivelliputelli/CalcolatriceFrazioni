
namespace ClassiUtili
{
    public class A
    {
        public static int P1 { get; set; } = 0;
        private static int n1;
        private static string n2 = "";
        public static int N1
        {
            get { return n1; }
            set { n1 = value; }
        }
        static A()
        {
            n2 = File.ReadAllText("");
        }
        public static int M1() => 5 + P1;

    }

    public class ClassA
    {
        public int P1 { get; set; } = 1;
        private int p2 = 2;
        protected int P3 { get; set; } = 3;
        public ClassA(int p1) => P1 = p1;
        public void M1() => Console.WriteLine("M1");
    }

    class ClassB : ClassA
    {
        private int n1;

        public int N1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public ClassB(int p1, int n1) : base(p1)
        {
            N1 = n1;
        }
    }

}
