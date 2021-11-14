using System;
using Calculo;

var a = 9;
var b = 12;
var c = 11;
var cal = new Calculadora();


var mcd = cal.MaxCDiv(a, b);
var max = cal.Max(b,a,c);

Console.WriteLine($"El MCD es {mcd}");
Console.WriteLine($"El Max es {max}");
