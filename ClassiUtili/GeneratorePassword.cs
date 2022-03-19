﻿namespace ClassiUtili
{
    /// <summary>
    /// La classe <c>GeneraPassword</c>.
    /// Contiene metodi per generare password a partire da un vocabolario.
    /// </summary>
    /// <seealso href="https://youtu.be/gXyESsIHPyE"/>
    /// <seealso href="https://youtu.be/n6R2AE3Htj0"/>
    public class GeneratorePassword
    {
        private static readonly Random g = new Random();
        private string alfabeto = "0123456789";
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
            Alfabeto = "0123456789";
            if (tipoPassword == TipoPassword.Lettere)
            {
                Alfabeto = "0123456789";
                for (char i = 'A'; i <= 'Z'; i++) Alfabeto += $"{(char)i}{(char)(i + 32)}";
            }
            else if (tipoPassword == TipoPassword.CaratteriSpeciali)
            {
                alfabeto = "";
                for (int i = 32; i <= 126; i++) Alfabeto += $"{(char)i}";
            }
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
    }
    public enum TipoPassword
    {
        Cifre,
        Lettere, // lettere + cifre
        CaratteriSpeciali // lettere + cifre + caratteri speciali
    }
    class GeneratorePasswordException : Exception
    {
        public GeneratorePasswordException(string messaggio) : base(messaggio)
        { }
    }
}