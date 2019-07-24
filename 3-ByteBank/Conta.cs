using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    public class Conta
    {
        private static double LIMITE_LINS = 100;
        public string Titular;
        public int NumeroAgencia;
        public int NumeroConta;
        public double SaldoConta;
        public double LimiteLins = LIMITE_LINS;

        public Conta() { }

        public Conta(string titular, int numeroAgencia, int numeroConta, double saldo) {
            this.Titular = titular;
            this.NumeroConta = numeroConta;
            this.NumeroAgencia = numeroAgencia;
            this.SaldoConta = saldo;
        }

        public bool Sacar(double valor) {
            if (this.SaldoConta > valor)
            {
                this.SaldoConta -= valor;
                return true;
            }
            else if (this.SaldoConta + this.LimiteLins >= valor) {
                this.LimiteLins -= valor - this.SaldoConta;
                this.SaldoConta = 0;
                return true;
            }
            return false;
        }

        public void Depositar(double valor) {
            if (this.SaldoTotal() < LIMITE_LINS) {
                valor += this.LimiteLins - LIMITE_LINS;
                if (valor > 0) {
                    this.LimiteLins = LIMITE_LINS;
                    this.SaldoConta += valor;
                }else {
                    this.LimiteLins = (LIMITE_LINS + valor); 
                }
            }

        }

        public double SaldoTotal() {
            return  this.SaldoConta + this.LimiteLins;
        }
        
        public override string ToString() {
            return string.Format(" Nome {0} \n Número agência {1} \n Número conta {2} \n Saldo em conta R$ {3} \n Limite Lins R$ {4} \n Saldo Total R$ {5} \n", this.Titular,this.NumeroAgencia,this.NumeroConta,this.SaldoConta,this.LimiteLins, this.SaldoTotal());
        }

    }
}
