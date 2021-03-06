﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CifradoDescifrado
{
    class Descifrado
    {

        /// <summary>
        /// Método que manda a llamar a los métodos "Aclarar", separar la cadena cifrada en un arreglo y mandarselo al método "ConvertirACaracter"
        /// </summary>
        /// <param name="cifrado"></param>
        /// <returns></returns>
        public static string Descifrar(string cifrado)
        {
            cifrado = Aclarar(cifrado);
            var cifradoEnArreglo = new String[cifrado.Length];
            var indiceArreglo = 0;
            var strBuilder = new StringBuilder();
            foreach(var caracter in cifrado)
            {
                if(!caracter.Equals('l') && !caracter.Equals(null))
                {
                    strBuilder.Append(caracter);
                }
                else
                {
                    cifradoEnArreglo[indiceArreglo] = strBuilder.ToString();
                    strBuilder.Clear();
                    indiceArreglo++;
                }
            }
            var resultado = ConvertirACaracter(cifradoEnArreglo);
            return resultado;
        }

        /// <summary>
        /// Método que convierte el arreglo de strings a carácteres para ser mostrados
        /// </summary>
        /// <param name="arreglo">Arreglo que se va a convertir a carácteres</param>
        /// <returns>Regresa la cadena descifrada</returns>
        private static string ConvertirACaracter(String[] arreglo)
        {
            var contrasenaDescifrada = new StringBuilder();
            var i = 0;
            while(arreglo[i] != null)
            {
                var numerosParaConvertir = Int32.Parse(arreglo[i]);
                contrasenaDescifrada.Append(/*Encoding.ASCII.GetString(new byte[] { numerosParaConvertir });*/(Convert.ToChar(numerosParaConvertir)));
                i++;
            }
            return contrasenaDescifrada.ToString();
        }

        /// <summary>
        /// Método que quita el incio y el fin para poder comenzar el descifrado
        /// </summary>
        /// <param name="cifrado">Recibe la cadena cifrada</param>
        /// <returns>Regresa la cadena cifrada "limpia" para proseguir con el descifrado</returns>
        private static string Aclarar(string cifrado)
        {
            var arregloCaracteres = cifrado.ToCharArray();
            var arregloLimpio = new char[arregloCaracteres.Length - 4];
            var indiceSubarreglo = 0;
            for (var i = 3; i < arregloCaracteres.Length-2; i++)
            {
                arregloLimpio[indiceSubarreglo] = arregloCaracteres[i];
                indiceSubarreglo++;
            }
            var resultado = new StringBuilder();
            foreach(var caracter in arregloLimpio)
            {
                resultado.Append(caracter);
            }
            return resultado.ToString();
        }

    }
}
