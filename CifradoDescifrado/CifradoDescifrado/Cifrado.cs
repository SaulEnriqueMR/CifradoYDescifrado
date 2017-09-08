using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoDescifrado
{
    class Cifrado
    {

        public static string Cifrar(string original)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(original);
            var contrasenaCifrada = new StringBuilder();
            foreach (var byteASCII in asciiBytes)
            {
                contrasenaCifrada.Append(byteASCII.ToString());
                contrasenaCifrada.Append("l");
            }
            var contrasenaConvertida = contrasenaCifrada.ToString();
            contrasenaConvertida = Despistar(contrasenaConvertida);
            return contrasenaConvertida;
        }

        private static string Despistar(string original)
        {
            var contrasenaModificada = new StringBuilder();
            contrasenaModificada.Append("02l");
            contrasenaModificada.Append(original);
            contrasenaModificada.Append("03l");
            return contrasenaModificada.ToString();
        }

    }
}
