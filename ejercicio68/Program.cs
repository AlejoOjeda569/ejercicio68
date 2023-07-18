namespace ejercicio68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = CrearMetodo("Ingrese un numero=");
            int factorial = calcularFactorial(numero);

            if (numero<0)
            {
                Console.WriteLine("Numero no es valido");
            }
            else
            {
                Console.WriteLine($"El factorial de {numero} es {factorial} ");
            }
           
        }

        private static int calcularFactorial(int numero)
        {
            int contador = 1;
            int factor = 1;
            do
            {
                factor = factor * contador;
                contador++;
            } while (contador<=numero);
            return factor;
        }

        private static int CrearMetodo(string Mensaje)
        {
            int Nro = 0;

            do
            {
                Console.Write(Mensaje);
                string  strconsole= Console.ReadLine();
                if (!int.TryParse(strconsole,out Nro))
                {
                    Console.WriteLine("NUMERO mal ingresado");
                }
                else
                {
                    break;
                }
            } while (true);
            return Nro;
        }
    }
}