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

            double valorSaque = 5040.95;
            double valorDeposito = 20;

            Console.WriteLine("*********** Conta ***********\n");
            Console.WriteLine(gabriele.ToString());

            Console.WriteLine("Sacando... R$ "+ valorSaque+"\n");


            if (gabriele.Sacar(valorSaque))
            {
                Console.WriteLine(gabriele.ToString());
            }
            else {
                Console.WriteLine("Desculpe, você não possui saldo suficiente! ");
            }

            Console.WriteLine("Depositando... R$ " + valorDeposito + "\n");

            gabriele.Depositar(valorDeposito);
            Console.WriteLine(gabriele.ToString());


            Console.ReadLine();
        }
    }
}
