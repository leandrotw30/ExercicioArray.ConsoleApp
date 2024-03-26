using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;

namespace ExemplosArray.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            EncontrarMaiorValor(valores);
            
            EncontrarMenorValor(valores);

            CalcularMédia(valores);

            EncontrarTrêsMaioresValores(valores);

            EncontrarValoresNegativos(valores);

            MostrarValoresSequencia(valores);

            RemoverItemSequencia(valores);
        }
        static void EncontrarMaiorValor(int[] valores)
        {
            int maiorValor = 0;

            for (int valor = 0; valor < valores.Length; valor++)
            {
                if (valores[valor] > maiorValor) //se o número maior estiver na variável valor e este for maior que a variável maiorNumero (que é zero)
                {
                    maiorValor = valores[valor]; // então este maiorNumero vai receber o valor dos valores
                }
            }
        }
        static void EncontrarMenorValor(int[] valores)
        {
            int menorValor = 0;

            for (int valor = 0; valor < valores.Length; valor++)
            {
                if (valores[valor] < menorValor)
                {
                    menorValor = valores[valor];
                }
            }
        }
        static void CalcularMédia(int[] valores)
        {
            int soma = 0;
            int media = 0;

            for (int valor = 0; valor < valores.Length; valor++)
            {
                soma += valores[valor];
            }
            media = soma / valores.Length;
        }
        static void EncontrarTrêsMaioresValores(int[] valores)
        {
            int primeiroMaiorValor = 0;
            int segundoMaiorValor = 0;
            int terceiroMaiorValor = 0;

            foreach (int valor in valores)
            {
                if (valor > primeiroMaiorValor)
                {
                    terceiroMaiorValor = segundoMaiorValor;
                    segundoMaiorValor = primeiroMaiorValor;
                    primeiroMaiorValor = valor;
                }
                else if (valor > segundoMaiorValor)
                {
                    terceiroMaiorValor = segundoMaiorValor;
                    segundoMaiorValor = valor;
                }
                else if (valor > terceiroMaiorValor)
                {
                    terceiroMaiorValor = valor;
                }

            }
        }
        static void EncontrarValoresNegativos(int[] valores)
        {
            int contadorNegativo = 0;

            foreach (int valor in valores) //para cada valor no array valores
            {
                if (valor < 0)
                {
                    contadorNegativo++;
                }
            }
            int[] valoresNegativos = new int[contadorNegativo];

            int contadorArray = 0;

            foreach (int valor in valores)
            {
                if (valor < 0)
                {
                    valoresNegativos[contadorArray] = valor;
                    contadorArray++;
                }
            }
        }
        static void MostrarValoresSequencia(int[] valores)
        {
            foreach (int valor in valores)
            {
                Console.Write($"{valor} ");
            }
        }
        static void RemoverItemSequencia(int[] valores)
        {
            int[] valoresIncopletos = new int[15];

            Array.Copy(valores, valoresIncopletos, 15);
        }
    }
}
