using System;
using Calculo;
using Calculo.Modelos;

var a = 9;
var b = 12;
var c = 11;
var cal = new Calculadora();


var mcd = cal.MaxCDiv(a, b);
var max = cal.Max(b,a,c);

Console.WriteLine($"El MCD es {mcd}");
Console.WriteLine($"El Max es {max}");

var f1 = new Fraccion(){
    Numerador = 5,
    Denominador = 15
};
var f2 = Fraccion.FromString("4/12");

var fr = cal.Suma(f1,f2);

Console.WriteLine($"f1={f1.ToStringInt()}");
Console.WriteLine($"f2={f2.ToStringInt()}");
Console.WriteLine($"fr={fr.ToStringInt()}");
