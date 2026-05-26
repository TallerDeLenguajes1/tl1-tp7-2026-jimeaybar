using System.Net;
using EspacioCalculadora;

Console.WriteLine("Hello, World!");

Calculadora calculadora1= new Calculadora();
Console.WriteLine(calculadora1.Resultado);
string? entrada="";
//calculadora1.SetDato(10);
while(entrada.ToLower() != "0")
{
    Console.WriteLine("Elija la operacion (+, -, *, /, limpiar), para salir precione '0'");
    entrada = Console.ReadLine();
    if (entrada.ToLower() == "0") break;
    if (entrada.ToLower() == "limpiar")
    {
        calculadora1.Limpiar();
        continue;
    }
    Console.WriteLine("Ingrese el numero:");
    if (double.TryParse(Console.ReadLine(), out double numero) && double.TryParse(Console.ReadLine(), out double numero2))
    {
        calculadora1.SetDato(numero);
        switch (entrada)
        {
            case "+": 
                calculadora1.Sumar(numero2);
                break;
        
            case "-":
                calculadora1.Restar(numero2);
                break;

            case "*":
                calculadora1.Multiplicar(numero2);
                break;

            case "/":
                calculadora1.Dividir(numero2);
                break;

            default:
                Console.WriteLine("Operacion no valida");
                break;

        }
    }
}

Console.WriteLine(calculadora1.Resultado);

//calculadora1.SetDato(10);
//calculadora1.Sumar(5);
//Console.WriteLine("Suma:" + calculadora1.Resultado);
//Console.WriteLine("Ingrese el numero");
//calculadora1.Restar(5);
//Console.WriteLine("Resta:" + calculadora1.Resultado);

//calculadora1.Multiplicar(2);
//Console.WriteLine("Producto:" + calculadora1.Resultado);

//calculadora1.Dividir(10);
//Console.WriteLine("Division:" + calculadora1.Resultado);



