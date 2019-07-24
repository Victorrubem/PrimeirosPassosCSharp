using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta gabriele = new Conta();
            gabriele.Titular = "Gabriela";
            gabriele.NumeroAgencia = 7795;
            gabriele.NumeroConta = 145635;
            gabriele.SaldoConta = 5000.95;

            if (gabriele.Sacar(5040.95))
            {
                Console.WriteLine(gabriele.ToString());
            }
            else {
                Console.WriteLine("Desculpe, você não possui saldo suficiente! ");
            }

            gabriele.Depositar(20);
            Console.WriteLine("");
            Console.WriteLine(gabriele.ToString());


            Console.ReadLine();
        }
    }
}
