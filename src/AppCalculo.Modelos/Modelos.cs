using System;

namespace Calculo.Modelos
{
    public class Fraccion
    {
        public int Numerador { get; init;}
        public int Denominador { get; init;}

        public bool EsPropia() => Numerador < Denominador;

        public override string ToString()=>$"{Numerador}/{Denominador}";
            
        public string ToStringP()
        {
            int entero = (Numerador / Denominador);
            if (entero == 0)
            {
                return ToString();
            }
            int numerador = Numerador - entero * Denominador;
            return $"{entero}⇸{numerador}/{Denominador}";
        }
    }

        public class Calificacion
        {
            public string Curso { get; }
            public string Nombre { get; }
            public char Sexo { get; }
            public decimal Nota { get; }

            public override string ToString() => $"{Curso} {Sexo}:{Nombre} {Nota}";
        }
    }
