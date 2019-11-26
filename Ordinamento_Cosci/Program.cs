using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordinamento_Cosci
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = 0;
            double Y = 0;
            double Z = 0;
            double K = 0;
            Console.WriteLine("Dai un valore a X Y e Z :");
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            Z = Convert.ToDouble(Console.ReadLine());
            var LeggiX = Task.Factory.StartNew(() =>
            {
                Console.WriteLine(X);

            });

            var LeggiY = Task.Factory.StartNew(() =>
            {
                Console.WriteLine(Y);

            });


            var LeggiZ = Task.Factory.StartNew(() =>
            {
                Console.WriteLine(Z);

            });


            var kmassimo1 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(500);
                if (X > Y)
                {
                    K = X;
                }
                else
                {
                    K = Y;
                }

            });
            var kmassimo2 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                if (K < Z)
                {
                    K = Z;
                }
            });



            var Stampa = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("il numero max è");
                Console.WriteLine(K);
            });
            Console.ReadLine();
        }
    }
}
