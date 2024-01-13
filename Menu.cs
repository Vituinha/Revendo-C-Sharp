using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Black;

            DrawScream();
            WriteOptions();
        
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        
        public static void DrawScream()
        {
            Console.Write("+");
            for(int i = 0; i<= 30; i++)
                Console.Write("-");

            Console.WriteLine("+");

            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for(int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.WriteLine("|");
            }
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.WriteLine("+");
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.Write("============");
            Console.SetCursorPosition(3,4);
            Console.Write("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3,6);
            Console.Write("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }
    
        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Show();
                    break;
            }
        }
    }    
}