using System;
using Figgle;
namespace hora_sistema
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            print("Hora do Sistema:",6,0,14,0);
            int Conta = 1;
            while(Conta <= 600)  {
                 DateTime horaSistema = DateTime.Now;
                 string ns = Convert.ToString(horaSistema.ToLongTimeString());
                 String DT = Convert.ToString(horaSistema.ToLongDateString());
                 string hora=FiggleFonts.Doom.Render(ns);
                
                 print(DT,10,4,5,1);
                 print(hora,10,0,0,2);// monta display relogio
                 for(int Tempo =1; Tempo <= 12000000; Tempo++) {}    
                 print(hora,0,0,0,2); // limpa rastro
                 Conta=Conta+1;
                 Console.SetCursorPosition(0, 10);// pra segurar o prompt em baixo
              }// fecha for
                Console.Clear();
            
            static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
               {
               ConsoleColor CorC = (ConsoleColor)COR_Caracter;
               ConsoleColor CorF = (ConsoleColor)COR_Fundo;
               Console.ForegroundColor = CorC;
               Console.BackgroundColor = CorF;
               Console.SetCursorPosition(X, Y);
               Console.Write(S);
               Console.ResetColor();
              }//fecha print                 
       }
    }
}