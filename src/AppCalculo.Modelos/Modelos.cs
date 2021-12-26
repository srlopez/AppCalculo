using System;

namespace Calculo.Modelos
{
    public class Fraccion
    {
        public int Numerador { get; init; }
        public int Denominador { get; init; }

        public bool EsPropia() => Numerador < Denominador;

        public override string ToString() => $" {Numerador}/{Denominador}";

        public static Fraccion FromString(string s)
        {
            try
            {
                var valores = s.Split("/");
                var n = Int32.Parse(valores[0]);
                var d = Int32.Parse(valores[1]);
                return new Fraccion()
                {
                    Numerador = n,
                    Denominador = d
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string ToStringInt()
        {
            int entero = (Numerador / Denominador);
            int numerador = Numerador - entero * Denominador;

            if (entero == 0 || numerador == 0)
            {
                return ToString();
            }
            return $" {entero}+{numerador}/{Denominador}";
        }
    }

}
