using System;

namespace Calculo.Modelos
{
    public class Fraccion
    {
        int Numerador {get;}
        int Denominador{get;}

        public bool EsPropia() => Numerador<Denominador;
    }

    public class Calificacion
    {
        public string Curso {get;}
        public string Nombre {get;}
        public char Sexo {get;}
        public decimal Nota {get;}

        public  override string ToString() => $"{Curso} {Sexo}:{Nombre} {Nota}";
    }
}
