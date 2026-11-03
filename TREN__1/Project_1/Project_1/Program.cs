using System;

    namespace ChristmasHouseAndTree
{
    class Program
    {
        
        static Random random = new Random();
        
            
        static void Main()
        {
            
            Console.CursorVisible = false;
            Console.Title = "С Новым Годом!";

            
            ConsoleColor[] garlandColors = {
                ConsoleColor.Red,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta,
                ConsoleColor.Green
            };

           
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                DrawSkyAndSnow();
                DrawHouse();
                DrawTree(garlandColors);

               
                Thread.Sleep(500);
            }
        }
        
        
        static void DrawSkyAndSnow()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            
            Console.SetCursorPosition(5, 2); Console.Write("*");
            Console.SetCursorPosition(15, 1); Console.Write("*");
            Console.SetCursorPosition(35, 3); Console.Write("*");
            Console.SetCursorPosition(55, 2); Console.Write("*");
            Console.SetCursorPosition(70, 1); Console.Write("*");

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("████████████████████████████████████████████████████████████████████████████████");
        }

        static void DrawHouse()
        {
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(19, 8); Console.Write("( )");

           
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(19, 9); Console.Write("||");
            Console.SetCursorPosition(19, 10); Console.Write("||");
            Console.SetCursorPosition(19, 11); Console.Write("||");

            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(22, 9);  Console.Write("/\\");
            Console.SetCursorPosition(21, 10); Console.Write("/  \\");
            Console.SetCursorPosition(20, 11); Console.Write("/    \\");
            Console.SetCursorPosition(19, 12); Console.Write("/      \\");
            Console.SetCursorPosition(18, 13); Console.Write("/        \\");
            Console.SetCursorPosition(17, 14); Console.Write("/          \\");
            Console.SetCursorPosition(16, 15); Console.Write("/____________\\"); 

            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(16, 16); Console.Write("|            |");
            Console.SetCursorPosition(16, 17); Console.Write("|            |");
            Console.SetCursorPosition(16, 18); Console.Write("|            |");
            Console.SetCursorPosition(16, 19); Console.Write("|____________|");

            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(19, 16); Console.Write("====");
            Console.SetCursorPosition(19, 17); Console.Write("║  ║");
            Console.SetCursorPosition(19, 18); Console.Write("====");
        }





        static void DrawTree(ConsoleColor[] garlandColors)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 6); Console.Write("★");

            
            Console.ForegroundColor = ConsoleColor.Green;

            
            Console.SetCursorPosition(49, 7); Console.Write("/ \\");
            Console.SetCursorPosition(48, 8); Console.Write("/   \\");
            Console.SetCursorPosition(47, 9); Console.Write("/     \\");
            Console.SetCursorPosition(46, 10); Console.Write("/_______\\");

           
            Console.SetCursorPosition(48, 11); Console.Write("/   \\");
            Console.SetCursorPosition(47, 12); Console.Write("/     \\");
            Console.SetCursorPosition(45, 13); Console.Write("/         \\");
            Console.SetCursorPosition(44, 14); Console.Write("/___________\\");

            
            Console.SetCursorPosition(46, 15); Console.Write("/     \\");
            Console.SetCursorPosition(44, 16); Console.Write("/         \\");
            Console.SetCursorPosition(42, 17); Console.Write("/             \\");
            Console.SetCursorPosition(40, 18); Console.Write("/_________________\\");

            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(49, 19); Console.Write("|||");
            
            DrawLight(50, 8, garlandColors);   
            DrawLight(49, 9, garlandColors);   
            DrawLight(51, 9, garlandColors);   
            DrawLight(50, 10, garlandColors);  

            
            DrawLight(50, 11, garlandColors);  
            DrawLight(49, 12, garlandColors);
            DrawLight(51, 12, garlandColors);
            DrawLight(48, 13, garlandColors);  
            DrawLight(52, 13, garlandColors);  
            DrawLight(47, 14, garlandColors);  
            DrawLight(53, 14, garlandColors);  

            
            DrawLight(50, 15, garlandColors);  
            DrawLight(48, 16, garlandColors);
            DrawLight(52, 16, garlandColors);
            DrawLight(46, 17, garlandColors);  
            DrawLight(54, 17, garlandColors);  
            DrawLight(44, 18, garlandColors);  
            DrawLight(50, 18, garlandColors);  
            DrawLight(56, 18, garlandColors);  
        }


        
        static void DrawLight(int x, int y, ConsoleColor[] garlandColors)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = garlandColors[random.Next(garlandColors.Length)];
            Console.Write("o");
        }
    }
}
