namespace ClassiUtili
{
    /// <summary>
    /// La classe <c>GeneraPassword</c>.
    /// Contiene metodi per generare password a partire da un vocabolario.
    /// </summary>
    /// <seealso href="https://youtu.be/gXyESsIHPyE"/>
    /// <seealso href="https://youtu.be/n6R2AE3Htj0"/>
    public class GeneratorePassword
    {
        // le const sono sempre anche static.
        // mantenere la parte finale dopo la 'A' costante..
        private const string Caratteri = "!#$%&'()*+,-./:;<=>?[]^_{|}~ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly Random g = new Random();
        private string alfabeto = "0123456789";
        public string PathAlfabeto { get; set; } = "AlfabetoPersonalizzato.txt";
        public string Alfabeto
        {
            get => alfabeto;
            set
            {
                if (value.Length == 0)
                    throw new GeneratorePasswordException("Almeno un carattere.");
                else
                    alfabeto = value;
            }
        }
        private int lunghezzaMinima = 3;
        public int LunghezzaMinima
        {
            get => lunghezzaMinima;
            set
            {
                if (value < 3)
                    throw new GeneratorePasswordException("Lunghezza minima 3 simboli.");
                else
                    lunghezzaMinima = value;
            }
        }

        public GeneratorePassword(TipoPassword tipoPassword = TipoPassword.Lettere)
        {
            SetTipoPassword(tipoPassword);
        }
        public void SetTipoPassword(TipoPassword tipoPassword = TipoPassword.Lettere)
        {
            if (tipoPassword == TipoPassword.AlfabetoPersonalizzato)
                Alfabeto = File.ReadAllText(PathAlfabeto);
            else if (tipoPassword == TipoPassword.Cifre)
                Alfabeto = Caratteri.Substring(Caratteri.IndexOf('0'));
            else if (tipoPassword == TipoPassword.Lettere)
                Alfabeto = Caratteri.Substring(Caratteri.IndexOf('A'));
            else if (tipoPassword == TipoPassword.CaratteriSpeciali)
                Alfabeto = Caratteri;
        }
        public string NuovaPassword(int lunghezza = 0)
        {
            if (lunghezza == 0) lunghezza = LunghezzaMinima;

            if (lunghezza < LunghezzaMinima)
                throw new GeneratorePasswordException($"Password troppo corta. Almeno {LunghezzaMinima} caratteri.");
            string psw = "";
            for (int i = 0; i < lunghezza; i++)
                psw += alfabeto[g.Next(0, alfabeto.Length)];
            return psw;
        }
        public static bool AlmenoUnaLetteraMaiuscola(string str)
        {
            foreach (var c in str)
                if (char.IsUpper(c)) return true;
            return false;
        }
        public static bool AlmenoUnCarattereSpeciale(string str)
        {
            string cc = Caratteri[0..Caratteri.IndexOf('~')]; // "!#$%&'()*+,-./:;<=>?[]^_{|}~";
            foreach (var c in str)
                if (cc.Contains(c)) return true;
            return false;
        }
    }
    public enum TipoPassword
    {
        AlfabetoPersonalizzato, // alfabeto modificabile salvato in un file.
        Cifre,
        Lettere, // lettere + cifre.
        CaratteriSpeciali // lettere + cifre + caratteri speciali.
    }
    class GeneratorePasswordException : Exception
    {
        public GeneratorePasswordException(string messaggio) : base(messaggio)
        { }
    }
}
