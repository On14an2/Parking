namespace parkovka
{
    internal class UI
    {
        public static void AddCar(ref List<CarClass> Parking)
        {
            Console.WriteLine("Введите информацию о машине");
            Console.WriteLine("Марка:");
            string inMark = Console.ReadLine();
            Console.WriteLine("Модель:");
            string inModel = Console.ReadLine();
            Console.WriteLine("Цвет:");
            string inColor = Console.ReadLine();
            Console.WriteLine("Номер:");
            string inNumber = Console.ReadLine();
            Console.WriteLine("Время прибытия");
            string inTime = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine(inTime);

            CarClass car = new CarClass(inMark, inModel, inColor, inNumber, inTime);
            Parking.Add(car);
        }

        public static void SearchCar(ref List<CarClass> Parking)
        {
            Console.WriteLine("Введите информацию о машине которую хотите найти:");
            string findcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            int i = 0;
            foreach (var item in Parking)
            {
                if (item.mark == findcar || item.model == findcar || item.color == findcar || item.number == findcar ||
                    item.time == findcar)
                {
                    Console.WriteLine(
                        $"1. марка: {item.mark}\n2. модель: {item.model}\n3. цвет: {item.color}\n4. номер: {item.number}\n5.Время прибытия: {item.time}\n6.Номер машины в базе: {i} \nЭто та машина которую вы искали?\n Y - да, любая другая клавиша - нет");

                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        found = true;
                        break;
                        Console.WriteLine();
                    }

                    else
                    {
                        flag = true;
                        continue;
                        Console.WriteLine();
                    }
                }

                i++;
            }

            if (found == false)
            {
                Console.WriteLine("\n Такой машины не найдено");
            }

            if (flag == true)
            {
                Console.WriteLine("\n Больше машин с таким описанием не найдено");
            }
        }

        public static void RemoveCar(ref List<CarClass> Parking)
        {
            Console.WriteLine("Какую машину вы хотите угнать?");
            Console.WriteLine("Напишите номер из базы:");
            int delnumber = int.Parse(Console.ReadLine());
            Parking.RemoveAt(delnumber);
            Console.WriteLine("Машина угнана!");

        }

        public static void PrintInfo(ref List<CarClass> Parking)
        {
            int i = 0; //
            foreach (CarClass item in Parking)
            {
                Console.WriteLine("Машина номер " + i);
                Console.WriteLine(
                    $"1. марка: {item.mark}\n2. модель: {item.model}\n3. цвет: {item.color}\n4. номер: {item.number}\n5. Время прибытия: {item.time}\n");
                i++;
            }
        }
    }
}