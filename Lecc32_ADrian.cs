internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Adrian Gonzalez\n" +
            "Grado: IVC- Clave:13\n" +
            "====Conversiones===");
        double metros, resultado;
        Console.WriteLine("Dame una medida en metros: ");
        metros = double.Parse(Console.ReadLine());

        Console.WriteLine("Menu principal");
        Console.WriteLine("1- Milimetros\n" +
            "2- Centrimetros\n" +
            "3- Decimetros\n" +
            "4- Hectómetros\n" +
            "5- Kilometros\n" +
            "6- Salir" +
            "Seleccione una Opcion []:");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Conversion a Milimetros");
                resultado = metros * 1000;
                Console.WriteLine("Los metros: " + metros + "En Milimitros es: " + resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Conversion a Centrimetos");
                resultado = metros * 100;
                Console.WriteLine("Los metros: " + metros + "En Centrimetros es: " + resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Conversion a Decimetros");
                resultado = metros * 10;
                Console.WriteLine("Los metros: " + metros + "En Decimetros es: " + resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Conversion a Hectometros");
                resultado = metros / 100;
                Console.WriteLine("Los metros: " + metros + "En Hectometros es: " + resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Conversion a Kilometros");
                resultado = metros / 1000;
                Console.WriteLine("Los metros: " + metros + "En Kilomtros es: " + resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Presione una tecla para salir");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opcion Invalida");
                break;
        }
    }
}
