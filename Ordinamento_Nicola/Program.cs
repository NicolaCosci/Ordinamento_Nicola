using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordinamento_Nicola
{ 
    class Program 
    {
        static void Main(string[] args)  
        { 
            int risuno = 0, riscinque = 0, risdue = 0, ristre = 0, risquattro = 0;  
             
            var PrimaOperazione = Task.Factory.StartNew(() =>
            {
                risuno = 2 * 6;

            });

            var SecondaOperazione = Task.Factory.StartNew(() =>
            {
                risdue = 1 + 4;


            });

            var TerzaOperazione = Task.Factory.StartNew(() =>
            {
                ristre = 5 - 2;

            });

            var QuartaOperazione = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(500);
                risquattro = ristre * risdue;

            });

            var QuintaOperazione = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                riscinque = risuno + risquattro;
                Console.WriteLine(riscinque);
            });




            Console.ReadLine();
        }
    }
}
