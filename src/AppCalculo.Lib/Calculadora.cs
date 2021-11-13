
using System;
using System.Diagnostics;

using Calculo.Modelos;

namespace Calculo
{
    public class Calculadora
    {
        public int MCD(int a, int b)
        // Máximo común divisor
        {

            Debug.Assert(a > 0 && b > 0, "Los parámetros deben ser mayor que 0");
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }

        public int Max(int a, int b, int c)
        // Máx de 3 números
        {
            var max = Int32.MinValue;
            if (a > b && a > c) { max = a; }
            else
            {
                if (a > b) { max = c; }
                else
                {
                    if (b > c) { max = b; }
                    else { max = c; }
                }
            }
            return max;
        }

        public string Ejemplo1(int[] valores){
        // Pruebas de Software Pág 130
        // Devolvemos el número de impares de valores en formato xx/nn
            var nImpar=0;
            var i=0;
            while(i<valores.Length){
                if(valores[i]%2==1) {
                    nImpar++;
                }
                i++;
            }
            return $"{nImpar}/{valores.Length}";
        }

        public string Ejemplo2(Calificacion[] calificaciones){
        // Pruebas de Software Pág 132
        // Devolvemos un informe de Hombres y Mujeres por curso HH/MM CURSO
            var i = 0;
            var nHombres = 0;
            var nMujeres = 0;
            var cursoActual = "";
            var informe = "";

            while(i<calificaciones.Length){
                nHombres = 0;
                nMujeres = 0;
                cursoActual = calificaciones[i].Curso;
                while(i<calificaciones.Length && calificaciones[i].Curso == cursoActual) {
                    if(calificaciones[i].Sexo == 'H') {
                        nHombres++;
                    }
                    i++;
                }
                informe+=$"{nHombres}/{nMujeres} {cursoActual}\n";
            }

            return informe;
        }

    }
}
