using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero1 = 10; // Variável que declara o número 10 nela
        int numero2 = 20;
        var soma = numero1 + numero2; // Um var define dinâmicamente o tipo da variável
        Console.WriteLine("10 + 20 = " + soma);

        int copiaDeNumero1 = numero1; // Copia o valor da variável de número 1
        copiaDeNumero1 = 11; // Será que o valor da variável número1 foi alterado?
        Console.WriteLine(numero1);
        Console.WriteLine(copiaDeNumero1);

        var quadrado1 = new Quadrado(); //Cria o quadrado
        quadrado1.lado = 10; // Quadrado1 terá o valor de lado = 10
        var quadrado2 = quadrado1; // Será que a cópia do quadrado foi completa ou copiamos apenas a referência?
        //quadrado2.lado = 11;
        Console.WriteLine(quadrado1.lado);// quadrado1 deveria ter o lado = 10
        Console.WriteLine(quadrado2.lado);// quadrado2 deveria ter o lado = 11
    }

    class Quadrado // Define uma classe chamada Quadrado
    {
        public int lado;// Define um atributo inteiro chamado lado na classe Quadrado
    }
}