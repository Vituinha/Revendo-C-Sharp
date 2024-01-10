using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        // Laços iterativos => estruturas que recebem um bloco de código, determinado numero de vezes

        //laço For
        for(int i=0; i<5; i++)
        {
            Console.WriteLine("Valor de i é: " + i);
        }

        int contador = 3;

        //laço While
        while (contador < 10)
        {
            contador++;
            Console.WriteLine(contador);
        }

        //laço Do while
        //Execução garantida pelo menos uma vez
        double j = 10;
        do
        {
            Console.WriteLine(j);
            j = j * 1.5;
        } while (j < 100);

        //laço Foreach
        //Percorre todos os elementos de um conjunto
        int[] conjunto = { 1, 2, 3, 7 };
        foreach(int numero in conjunto)
        {
            Console.WriteLine("Esse elemento do conjunto possui valor " + numero + "! Somando esse número a 10 temos: " + (numero+10));
        }
    }
}