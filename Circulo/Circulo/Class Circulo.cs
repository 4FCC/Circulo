using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{

    public class _CRadio
    {

        public double pi = Math.PI;
        public double _Radio { get; set;} 
        
        public _CRadio(double _Radio)
        {

            this._Radio = _Radio;

        }

        public void Perimetro()
        {

            Console.WriteLine("Su Perimetro es " + (2 * _Radio * pi));

        }

        public void Area()
        {

            double potencia = Math.Pow(_Radio, 2);
            Console.WriteLine("Su area es " + (pi * potencia));

        }

        public void Volumen()
        {

            double potencia = Math.Pow(_Radio, 3);
            Console.WriteLine("Su volumen es " + ((4 * pi * potencia) / (3)));

        }

    }

}

