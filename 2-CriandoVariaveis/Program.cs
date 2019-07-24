using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean
            bool verdadeiro = true;
            bool falso = false;
            bool? nulo = null; //Para aceitar Nulo é necessário inserir o ? em seguida

            //Tipos numéricos do tipo Inteiros
            sbyte inteiro8bitsComSinal = -127;                          // -128 à 127
            byte inteiro8bitsSemSinal = 255;                            // 0 à 255
            short inteiro16bitsComSinal = -32767;                       // -32768 à 32768
            ushort inteiro16bitsSemSinal = 65535;                       // 0 à 35535
            int inteiro32bitsComSinal = -2147483647;                    // -2147483647 à 2147483647
            uint inteiro32bitsSemSinal = 4294967295;                    // - 4294967295 à 4294967295
            long inteiro64bitsComSinal = -9223372036854775807;          // -9223372036854775807 à 9223372036854775807
            ulong inteiro64bitsSemSinal = 18446744073709551615;         // 0 à 18446744073709551615

            //Tipos numéricos de ponto flutuante
            float pontoFlutuantePequeno = 123456.789F;                  //Aproximadamente de 6 à 9 digitos
            double pontoFlutuanteMedio = 123456789.12345678D;           //Aproximadamente de 15 a 17 dígitos
            decimal pontoFlutuanteGrande = 123456789.10111213141516m;   //Aproximadamente de 28 a 29 digitos
            
            char caractere = 'a';

            //String no C# pode ser escrita com "s" minúsculo ou "S" maiúsculo
            String sTring = "String é uma coleção de caracteres, ou seja, frase ou palavra";
            string sByte = "Inteiro de 8 bits com sinal sbyte = ";
            string bYte = "Inteiro de 8 bits sem sinal byte = ";
            string sHort = "Inteiro de 16 bits com sinal short = ";
            string uShort = "Inteiro de 16 bits sem sinal ushort = ";
            string inT = "Inteiro de 32 bits com sinal int = ";
            string uInt = "Inteiro de 32 bits sem sinal uint = ";
            string lOng = "Inteiro de 64 bits com sinal long = ";
            string uLong = "Inteiro de 64 bits sem sinal ulong = ";
            string cHar = "Apenas um caracter, char = ";


            Console.WriteLine("Boolean é um tipo lógico podendo ser: "+verdadeiro + " verdadeiro "+falso + " falso \n");

            Console.WriteLine("Para que um tipo aceite valor nulo, é necessário inserir ? no final do tipo. Ex: bool? = "+nulo +" \n");

            Console.WriteLine("Tipos numéricos do tipo Inteiros \n");

            Console.WriteLine(sByte+inteiro8bitsComSinal);
            Console.WriteLine(bYte+ inteiro8bitsSemSinal);
            Console.WriteLine(sHort+inteiro16bitsComSinal);
            Console.WriteLine(uShort + inteiro16bitsSemSinal);
            Console.WriteLine(inT+inteiro32bitsComSinal);
            Console.WriteLine(uInt+inteiro32bitsSemSinal);
            Console.WriteLine(lOng+inteiro64bitsComSinal);
            Console.WriteLine(uLong+inteiro64bitsSemSinal + "\n");

            Console.WriteLine(cHar+caractere + "\n");

            Console.WriteLine(sTring + "\n");

            Console.WriteLine("Tipos numéricos de ponto flutuante \n");

            Console.WriteLine("Aproximadamente de 6 à 9 digitos float = "+pontoFlutuantePequeno+"\n");
            Console.WriteLine("Aproximadamente de 15 a 17 dígitos double = " + pontoFlutuanteMedio+"\n");
            Console.WriteLine("Aproximadamente de 28 a 29 digitos decimal = " + pontoFlutuanteGrande+"\n");

            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
