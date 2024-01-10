using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        // Laços condicionais => execução mediante determinada condição/situação satisfeita
        int hora = 18;
        
        //Laço if, else
        if (hora < 15) // Se a hora for maior ou igual a 15, será impressa a mensagem na tela!
            Console.WriteLine("São menos de 15 horas");
        else if (hora < 17)
            Console.WriteLine("A hora é menor ou igual a 17 horas");
        else //Garante a execução caso não passe em nenhum dos loops
        {
            if (hora == 18)
                Console.WriteLine("Agora são 18 horas!");
            else
                Console.WriteLine("Já se passaram das 18 horas");
        }

        //Laço switch ... case
        //Geralmente a expressão avaliada é uma constante
        switch (hora)
        {
            case 15://O teste condicional é exato.
                Console.WriteLine("São 15 horas!");
                break;
            case 18://O teste condicional é exato.
                Console.WriteLine("São 18 horas!");
                break;
            default://Caso não se enquadre nos demais cases
                Console.WriteLine("São " + hora + " horas!");
                break;
        }

        PrimeiroSemestre mes = PrimeiroSemestre.Maio;
        switch(mes)
        {
            case PrimeiroSemestre.Janeiro:
                Console.WriteLine("Estamos em Janeiro!");
                break;
            case PrimeiroSemestre.Fevereiro:
                Console.WriteLine("Estamos em Fevereiro!");
                break;
            case PrimeiroSemestre.Março:
                Console.WriteLine("Estamos em Março!");
                break;
            case PrimeiroSemestre.Abril:
                Console.WriteLine("Estamos em Abril!");
                break;
            case PrimeiroSemestre.Maio:
                Console.WriteLine("Estamos em Maio!");
                break;
            case PrimeiroSemestre.Junho:
                Console.WriteLine("Estamos em Junho!");
                break;
        }
    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Março, Abril, Maio, Junho
    }
}