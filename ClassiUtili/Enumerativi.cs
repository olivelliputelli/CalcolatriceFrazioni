
namespace ClassiUtili
{
    [Flags]
    public enum Stagione
    {
        Nessuna = 0b_0000,
        Primavera = 0b_0001, // 1
        Estate = 0b_0010, // 2
        Autunno = 0b_0100, 
        Inverno = 0b_1000,
        AutunnoInverno = Autunno | Inverno
    }
    public enum Genere { Maschio, Femmina, Fluido, Altro }
    public enum Sesso { Maschio, Femmina }

}
