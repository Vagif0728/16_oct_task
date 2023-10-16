namespace H0meTask12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bakda neqeder benzin var : ");
            double fuel = double.Parse(Console.ReadLine());
            Console.WriteLine("Mawininn bakinin hecmi ne qederdir : ");
            double fuelCapacity = double.Parse(Console.ReadLine());
            Console.WriteLine("Mawinin 1000 km ne qeder benzin icir : ");
            double fuelConsumption = double.Parse(Console.ReadLine());

            Console.WriteLine("Secimi daxil edin : ")
                ;
            int choosee = int.Parse(Console.ReadLine());
            switch (choosee)
            {
                case 1:
                    Console.WriteLine("Sur");

                    break;

                case 2:
                    Console.WriteLine("Zapravkaya gir");

                    break;

                case 3:
                    Console.WriteLine("Benzini goster");

                    break;

                case 4:
                    Console.WriteLine("Getdiyimiz yolu goster :");

                    break;

                default:
                    Console.WriteLine("Duzgun daxil edin ");
                    break;

            }
        }

    }
}