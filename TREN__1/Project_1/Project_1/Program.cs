using System;
using System.Threading;

namespace ChristmasHouseAndTree
{
    class Program
    {
        // Генератор случайных чисел для смены цветов гирлянды
        static Random random = new Random();

        static void Main(string[] sender)
        {
            // Настройка консоли
            Console.CursorVisible = false;
            Console.Title = "С Новым Годом и Рождеством!";

            // Массив доступных праздничных цветов для гирлянды
            ConsoleColor[] garlandColors = {
                ConsoleColor.Red,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta,
                ConsoleColor.Green
            };

            // Бесконечный цикл для анимации гирлянды
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                DrawSkyAndSnow();
                DrawHouse();
                DrawTree(garlandColors);

                // Задержка в 500 миллисекунд (полсекунды) перед следующим "миганием"
                Thread.Sleep(500);
            }
        }
        
        // Рисуем задний фон (небo, звезды и снег)
        static void DrawSkyAndSnow()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            // Звезды на небе
            Console.SetCursorPosition(5, 2); Console.Write("*");
            Console.SetCursorPosition(15, 1); Console.Write("*");
            Console.SetCursorPosition(35, 3); Console.Write("*");
            Console.SetCursorPosition(55, 2); Console.Write("*");
            Console.SetCursorPosition(70, 1); Console.Write("*");

            // Земля/Снег под домом и елкой
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("████████████████████████████████████████████████████████████████████████████████");
        }

        static void DrawHouse()
        {
            // Дым над трубой
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(19, 8); Console.Write("( )");

            // Кирпичная труба (ровно врезана в левый скат крыши на X = 17)
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(19, 9); Console.Write("||");
            Console.SetCursorPosition(19, 10); Console.Write("||");
            Console.SetCursorPosition(19, 11); Console.Write("||");

            // Идеальная симметричная крыша (Центр на X = 21, высота 5 строк)
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(22, 9); Console.Write("/\\");
            Console.SetCursorPosition(21, 10); Console.Write("/  \\");
            Console.SetCursorPosition(20, 11); Console.Write("/    \\");
            Console.SetCursorPosition(19, 12); Console.Write("/      \\");
            Console.SetCursorPosition(18, 13); Console.Write("/        \\");
            Console.SetCursorPosition(17, 14); Console.Write("/          \\");
            Console.SetCursorPosition(16, 15); Console.Write("/____________\\"); // Нижнее основание крыши (длина 14)

            // Стены дома (Начинаются строго со следующей строки Y = 16. Ширина 12 символов: от X = 16 до X = 27)
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(16, 16); Console.Write("|            |");
            Console.SetCursorPosition(16, 17); Console.Write("|            |");
            Console.SetCursorPosition(16, 18); Console.Write("|            |");
            Console.SetCursorPosition(16, 19); Console.Write("|____________|");

            // Светящееся окно ровно по центру (X = 20, ширина 4 символа)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(19, 16); Console.Write("====");
            Console.SetCursorPosition(19, 17); Console.Write("║  ║");
            Console.SetCursorPosition(19, 18); Console.Write("====");
        }





        static void DrawTree(ConsoleColor[] colors)
        {
            // Звезда ровно по центру верхушки (X = 50)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 6); Console.Write("★");

            // Ветки елки (Зеленые) — математически точные и зеркальные строки
            Console.ForegroundColor = ConsoleColor.Green;

            // Верхний ярус
            Console.SetCursorPosition(49, 7); Console.Write("/ \\");
            Console.SetCursorPosition(48, 8); Console.Write("/   \\");
            Console.SetCursorPosition(47, 9); Console.Write("/     \\");
            Console.SetCursorPosition(46, 10); Console.Write("/_______\\");

            // Средний ярус
            Console.SetCursorPosition(48, 11); Console.Write("/   \\");
            Console.SetCursorPosition(47, 12); Console.Write("/     \\");
            Console.SetCursorPosition(45, 13); Console.Write("/         \\");
            Console.SetCursorPosition(44, 14); Console.Write("/___________\\");

            // Нижний ярус
            Console.SetCursorPosition(46, 15); Console.Write("/     \\");
            Console.SetCursorPosition(44, 16); Console.Write("/         \\");
            Console.SetCursorPosition(42, 17); Console.Write("/             \\");
            Console.SetCursorPosition(40, 18); Console.Write("/_________________\\");

            // Ствол дерева ровно по центру под ветками (X = 49, 50, 51)
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(49, 19); Console.Write("|||");

            // Огоньки гирлянды установлены строго ВНУТРИ силуэта елки (ближе к оси X=50)

            // Верхний ярус (внутри)
            DrawLight(50, 8, colors);   // Строго по центру пустоты верхнего яруса
            DrawLight(49, 9, colors);   // Чуть левее от центра
            DrawLight(51, 9, colors);   // Чуть правее от центра
            DrawLight(50, 10, colors);  // На сплошной линии яруса

            // Средний ярус (внутри)
            DrawLight(50, 11, colors);  // По центру пустоты среднего яруса
            DrawLight(49, 12, colors);
            DrawLight(51, 12, colors);
            DrawLight(48, 13, colors);  // Внутренняя левая часть
            DrawLight(52, 13, colors);  // Внутренняя правая часть
            DrawLight(47, 14, colors);  // На сплошной линии второго яруса
            DrawLight(53, 14, colors);  // На сплошной линии второго яруса

            // Нижний ярус (внутри)
            DrawLight(50, 15, colors);  // По центру пустоты нижнего яруса
            DrawLight(48, 16, colors);
            DrawLight(52, 16, colors);
            DrawLight(46, 17, colors);  // Внутренняя левая часть ближе к низу
            DrawLight(54, 17, colors);  // Внутренняя правая часть ближе к низу
            DrawLight(44, 18, colors);  // Над самой нижней линией (слева)
            DrawLight(50, 18, colors);  // Над самой нижней линией (центр)
            DrawLight(56, 18, colors);  // Над самой нижней линией (справа)
        }


        // Метод для отрисовки одного огонька случайного цвета
        static void DrawLight(int x, int y, ConsoleColor[] colors)
        {
            Console.SetCursorPosition(x, y);
            // Выбираем случайный цвет из массива
            Console.ForegroundColor = colors[random.Next(colors.Length)];
            Console.Write("o");
        }
    }
}
