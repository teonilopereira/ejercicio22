namespace ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            Console.WriteLine("conversion de temperaturas");
            Console.Write("Ingrese el valor pemperatura");
            var temperatura = double.Parse(Console.ReadLine());
            Console.Write("seleccione la escala de temperatura (C)elsius o (F)ahrenheit");
            var escala = Console.ReadLine();
            if (escala.ToLower() == "c")
            {
                fahrenheit = 1.8 * temperatura + 32;
                Console.WriteLine($"{temperatura}=celsius quivalen a{fahrenheit}grado fahrenheit");

            }
            else
            {
                if (escala.ToLower() == "f")
                {
                    celsius = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"{temperatura} fahrenheit equivalen a {celsius} grado celsius");
                }
                else
                {
                    Console.WriteLine("escala no valida");
                }
            }
        }
    }
}