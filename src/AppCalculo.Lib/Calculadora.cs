
using System;
using System.Diagnostics;

using Calculo.Modelos;

namespace Calculo
{
    public class Calculadora
    {
        public int MaxCDiv(int a, int b)
        // Máximo común divisor, GreatestCD
        {

            Debug.Assert(a > 0 && b > 0, "Los parámetros deben ser mayor que 0");
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }

        public int MinCMult(int a, int b) => (a * b) / MaxCDiv(a, b);
        // Mínimo común múltiplo, LeastCM
        public Fraccion Suma(Fraccion f1, Fraccion f2)
        {
            var n = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador;
            var d = f1.Denominador * f2.Denominador;
            var mcd = MaxCDiv(n, d);
            return new Fraccion
            {
                Numerador = n / mcd,
                Denominador = d / mcd
            };
        }
        public int Max(int a, int b, int c)
        // Máx de 3 números
        {
            var max = Int32.MinValue;
            if (a > b && a > c)
            {
                max = a;
            }
            else
            {
                if (b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }
            return max;
        }
        public int ObtenerPosicionCaseInsensitive(string[] lista, string dato)
        // Devuelve la posicion de un string en un array
        {
            for (var i = 0; i < lista.Length; i++)
            {
                if (lista[i].ToLower() == dato.ToLower())
                {
                    return i;
                };
            }
            return -1;
        }
        public int SumaSiPosicionesYValorMatchMod2MenosResto(int[] lista, int mod2)
        {
            Debug.Assert(mod2>=0 && mod2<=1);
            var suma = 0;
            for (var i = 0; i < lista.Length; i++)
            {
                if ((i+1) % 2 == mod2 && lista[i] % 2 == mod2)
                {
                    suma += lista[i];
                }
                else
                {
                    suma -= lista[i];
                }
            }
            return suma;
        }
        public int[] FiltroParImpar(int[] lista, int resto2)
        {
            // Introducir collections
            return new int []{};
        }

    }
}
