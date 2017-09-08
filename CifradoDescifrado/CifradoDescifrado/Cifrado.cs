using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoDescifrado
{
    class Cifrado
    {

        /// <summary>
        /// Método que se encarga de mandar a llamar al método Despistar y posteriormente cifrar
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método que agregará carácteres al inicio y al final
        /// </summary>
        /// <param name="original">Recibe la contraseña original que se va a cifrar</param>
        /// <returns>Regresa la contraseña en "sucio" para proseguir con el cifrado</returns>
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
