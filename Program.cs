using parkovka;
internal class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<CarClass> Parking = new List<CarClass>();
        bool a = true;
        while (a)
        {
            Console.WriteLine("Меню: \n 1 - Добавить машину \n 2 - Поиск по базе \n 3 - Угнать машину \n 4 - Показать все машины в базе \n 5 - Выход из программы");
            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();
            switch (key)
            {
                case ConsoleKey.D1:
                    parkovka.UI.AddCar(ref Parking);
                    break;
                case ConsoleKey.D2:
                    parkovka.UI.SearchCar(ref Parking);
                    break;
                case ConsoleKey.D3:
                    parkovka.UI.RemoveCar(ref Parking);
                    break;
                case ConsoleKey.D4:
                    parkovka.UI.PrintInfo(ref Parking);
                    break;
                case ConsoleKey.D5:
                    a = false;
                    Console.WriteLine("Выход из программы");
                    break;

                default:
                    Console.WriteLine("Вы ввели неверную клавишу");
                    break;
            }
        }
    }
}