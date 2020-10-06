using System;

namespace hora_sistema
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Clear();


            DateTime horaSistema = DateTime.Now;
            print("Hora do Sistema:",6,0,17,0);
            //Console.WriteLine(horaSistema);
            //Console.WriteLine(horaSistema.Minute);
            string ns = Convert.ToString(horaSistema);
            print(ns,4,1,15,1);

          
            static void print(String S, int COR_FRENTE,int COR_FUNDO, int X,int Y)
            {
            switch (COR_FRENTE)
             {
                case 1:
                Console.ForegroundColor = ConsoleColor.Black;
                break;
                case 2:
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                break;
                case 3:
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
                case 4:
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
                case 5:
                 Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;
                case 6:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                break;
                case 7:
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
                case 8:
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
                case 9:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
                case 10:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
                case 11:
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
                case 12:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
                case 13:
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
                case 14:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
                case 15:
                Console.ForegroundColor = ConsoleColor.White;
                break;                       
              }// fecha switch
              switch (COR_FUNDO)
              {
                case 1:
                Console.BackgroundColor = ConsoleColor.Black;
                break;
                case 2:
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                break;
                case 3:
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                break;
                case 4:
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                break;
                case 5:
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                break;
                case 6:
                 Console.BackgroundColor = ConsoleColor.DarkYellow;
                break;
                case 7:
                Console.BackgroundColor = ConsoleColor.Gray;
                break;
                case 8:
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                break;
                case 9:
                Console.BackgroundColor = ConsoleColor.Blue;
                break;
                case 10:
                Console.BackgroundColor = ConsoleColor.Green;
                break;
                case 11:
                Console.BackgroundColor = ConsoleColor.Cyan;
                break;
                case 12:
                Console.BackgroundColor = ConsoleColor.Red;
                break;
                case 13:
                Console.BackgroundColor = ConsoleColor.Magenta;
                break;
                case 14:
                Console.BackgroundColor = ConsoleColor.Yellow;
                break;
                case 15:
                Console.BackgroundColor = ConsoleColor.White;
                break;                       
              }// fecha switch
             Console.SetCursorPosition(X, Y);
             Console.Write(S);
             Console.ResetColor();
            }//fecha print
                     
        }
    }
}