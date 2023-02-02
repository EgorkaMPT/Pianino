namespace pianino
{
    internal class Program
    {

        static void Octave1()
        {
            int[] Octave1 = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            Klavisha(Octave1);
        }
        static void Octave2()
        {
            int[] Octave2 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            Klavisha(Octave2);
        }
        static void Octave3()
        {
            int[] Octave3 = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            Klavisha(Octave3);
        }
        static void Octave4() 
        {
            int[] Octave4 = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            Klavisha(Octave4);
        }
        static void Octave()
        {
            ConsoleKeyInfo octave = Console.ReadKey(true);
            switch (octave.Key)
            {
                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        Console.WriteLine("Была выбрана первая октава");
                        Octave1();
                        break;
                    }
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.WriteLine("Была выбрана вторая октава");
                        Octave2();
                        break;
                    }
                case ConsoleKey.F3:
                    {
                        Console.Clear();
                        Console.WriteLine("Была выбрана третья октава");
                        Octave3();
                        break;
                    }
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        Console.WriteLine("Была выбрана четвёртая октава");
                        Octave4();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        static void Klavisha(int[] zvyk)
        {
            while (true)
            {
                ConsoleKeyInfo pian = Console.ReadKey(true);
                switch (pian.Key)
                {
                    case ConsoleKey.E:
                        {
                            Console.Beep(zvyk[0], 350);
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.Beep(zvyk[1], 350);
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            Console.Beep(zvyk[2], 350);
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Console.Beep(zvyk[3], 350);
                            break;
                        }
                    case ConsoleKey.T:
                        {
                            Console.Beep(zvyk[4], 350);
                            break;
                        }
                    case ConsoleKey.G:
                        {
                            Console.Beep(zvyk[5], 350);
                            break;
                        }
                    case ConsoleKey.Y:
                        {
                            Console.Beep(zvyk[6], 350);
                            break;
                        }
                    case ConsoleKey.H:
                        {
                            Console.Beep(zvyk[7], 350);
                            break;
                        }
                    case ConsoleKey.U:
                        {
                            Console.Beep(zvyk[8], 350);
                            break;
                        }
                    case ConsoleKey.J:
                        {
                            Console.Beep(zvyk[9], 350);
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            Console.Beep(zvyk[10], 350);
                            break;
                        }
                    case ConsoleKey.K:
                        {
                            Console.Beep(zvyk[11], 350);
                            break;
                        }
                }
                if (pian.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Выбирайте октаву:\nF1 - Первая октава\nF2 - Вторая октава\nF3 - Третья октава\nF4 - Четвёртая октава\nEscape - Выход из пианино");
                    break;
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами - F1, F2, F3, F4\nEsc - Выход из октавы");
            while (true)
            {
                Octave();
            }
        }
    }
}