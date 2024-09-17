namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();
            bool openDoor = false;
            bool isKey = false;
            int o1 = 1;
            int o2 = 2;
            int o3 = 3;
            int tr = 0;
            Console.WriteLine("Вы в комнате.Найдя 3 отмычки. Активируйте ключ,чтобы открыть дверь.");
            while (isKey == false)
            {
                Console.WriteLine("Вы можете: 1.Открыть шкаф 2.Поискать под столом 3.Посмотреть в кровати 4.Посмотреть под котом 5.Активировать ключ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    if (o1 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли отмычку");
                        o1 = 0;
                        tr++;
                    }

                }
                if (choice == 2)
                {

                    if (o2 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли отмычку");
                        o2 = 0;
                        tr++;
                    }
                }
                if (choice == 3)
                {

                    if (o3 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли отмычку");
                        o3 = 0;
                        tr++;
                    }
                }
                if (choice == 4)
                {
                    Console.WriteLine("Здесь пусто");
                }
                if (choice == 5)
                {
                    if (tr == 3)
                    {
                        Console.WriteLine("ключ был активирован. Вы получили ключ от двери...");
                        isKey = true;
                    }
                }
            }



            Console.WriteLine();
            Console.WriteLine("Поздравляем!!! Вы выбрались из квартиры " + name);
            Console.ReadKey();
        }

    }
}