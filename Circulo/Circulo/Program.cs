using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circulo;


// Circulo

Console.WriteLine("Ingresa el readio de tu circulo");
int number = Int32.Parse(Console.ReadLine());
_CRadio o_CRadio = new _CRadio(number);

o_CRadio.Perimetro();
o_CRadio.Area();
o_CRadio.Volumen();

Console.ReadKey();