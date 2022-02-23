using System;

namespace FrequenciaNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 10, 8, 8, 260, 260, 270, 1, 2, 4, 4, 4, 10, 10, 9 };

            //ordenar o array
            Array.Sort(array);            

            int i = 0;
            int j = 0;

            //percorrer os números da sequencia
            while (i < array.Length)
            {
                int numero = array[i];
                int quantidadeVezes = 0;

                while (array[i] == array[j])
                {
                    quantidadeVezes++;
                    j++;
                    
                    if (j == array.Length) //se é o ultimo elemento
                        break;
                }

                //verificar concordância
                string sufixo = (quantidadeVezes > 1) ? " vezes" : " vez";

                Console.WriteLine(numero + " apareceu " + quantidadeVezes + sufixo);

                //em algum lugar modificar o valor de "i"
                i = j;
            }

            //percorer os números repetidos            

            Console.ReadLine(); 

        }

    }
}
