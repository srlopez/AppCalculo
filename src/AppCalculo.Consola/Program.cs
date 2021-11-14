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
    Numerador = 23,
    Denominador = 11
};

Console.WriteLine($"f1 {f1.ToStringP()}");
