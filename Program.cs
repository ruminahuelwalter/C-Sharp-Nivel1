using System;

namespace TPFinal_Ruminahuel
{
    class Program
    {
        /**
        Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

        a. El mayor de los números pares.
        b. La cantidad de números impares.
        c. El menor de los números primos.

        Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
        
        */
        static void Main(string[] args)
        {
            int n, modulo, mayorPares = -1, cantidadImpares = 0, menorPrimos = -1;
            bool banderaMayorPares = true, banderaMenorPrimos = true;

            Console.WriteLine("Ingrese una lista de numeros. Para finalizar ingrese 0.");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                modulo = n%2;
                if (modulo == 0){
                    if (banderaMayorPares)
                    {
                        mayorPares = n;
                        banderaMayorPares = false;
                    }
                    else if (n > mayorPares)
                    {
                        mayorPares = n;
                    }
                }
                else{
                    cantidadImpares++;
                }
              
                if(esPrimo(n)){
                    if (banderaMenorPrimos)
                    {
                        menorPrimos = n;
                        banderaMenorPrimos = false;
                    }
                    else if(n < menorPrimos){
                        menorPrimos = n;
                    }
                }
            n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------------------------------");
            if(mayorPares == -1){
                Console.WriteLine("No ingresó números pares");
            }
            else{
                Console.WriteLine("El mayor de los números pares es: " + mayorPares);
            }

            Console.WriteLine("Cantidad de números impares: " + cantidadImpares);

            if(menorPrimos == -1){
                Console.WriteLine("No ingresó números primos");
            }
            else{
                Console.WriteLine("El menor de los números primos es: " + menorPrimos);
            }
        }
           static bool esPrimo(int numero){
            int i = 1;
            int modulo;
            int contador = 0;
            while (i <= numero){
                modulo = numero%i;
                if (modulo == 0){
                    contador++;
                }
                i++;
            }
            if (contador == 2){
                return true;
            }
            else{
                return false;
            }
        } 
    }
}
