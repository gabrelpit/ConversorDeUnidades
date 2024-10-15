using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("/nConversor De Unidades");
            Console.WriteLine("1 - Metros para Quilometros");
            Console.WriteLine("2 - Gramas para Quilos");
            Console.WriteLine("3 - Celsius para Fahrenheit");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Escolha uma opcao");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 4)
            {
                break;
            }

            Console.WriteLine("Digite o valor a ser convertido");
            double valor = double.Parse(Console.ReadLine());
            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = MetrosParaQuilometros(valor);
                    Console.WriteLine($"{valor} metros = {resultado} quilômetros");
                    break;
                case 2:
                    resultado = GramasParaQuilos(valor);
                    Console.WriteLine($"{valor} gramas =  {resultado} quilos");
                    break;
                case 3:
                    resultado = CelsiusParaFahrenheit(valor);
                    Console.WriteLine($"{valor} °C = {resultado} °F");
                    break;
                default:
                    Console.WriteLine("Opcao Invalida");
                    break;
            }
        }
    }

    static double MetrosParaQuilometros(double metros)
    {
        return metros / 1000;
    }

    static double GramasParaQuilos(double gramas)
    {
        return gramas / 1000;
    }

    static double CelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
