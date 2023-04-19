using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace Review3
{
    public class Exercise3
    {
        //Reproduzir o codigo

        public Exercise3()
        {
            ConsolePurple();
            Console.Clear();

            //Utilizei uma Matriz string para Trbalhar Mais facilmente com formatação de console
            string[,] Points = new string[7,4];
            for (int l=0; l<7; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    StartLooping:
                    try
                    {
                        TablePoints(Points);
                        int value = int.Parse(Console.ReadLine());
                        Points[l, c] = Convert.ToString(value).PadRight(7);
                    }catch(Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        goto StartLooping;
                    }
                    Console.Clear();
                }
            }
            TablePoints(Points);
            ResultTable(Points);

            Console.ResetColor();
        }

        static string[] week = new string[7] { "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb", "Dom" };
        static void TablePoints(string[,] Points)
        {
            Console.Write("Quantidade de Pratos Vendidos:\n\n     ");
            for(int i=1; i<=4; i++)
            {
                WriteGreen("Prato ");
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                WriteGreen($"{week[i]}  ");
                Console.WriteLine($"{Points[i, 0]} {Points[i, 1]} {Points[i, 2]} {Points[i, 3]}");
            }
            WriteGreen("\nDigite a pontuação: ");
        }
        static void ResultTable(string[,] Points)
        {
            Console.WriteLine("\nPrato mais popular em cada dia da semana:\n");
            for (int i = 0; i < 7; i++)
            {
                WriteGreen($"{week[i]}: ");
                Console.WriteLine($"Prato {ResultValue(Points, i)}");
            }            
        }

        static int ResultValue(string[,] Points, int Index)
        {
            int HighValue = int.MinValue, Value = 0;
            
            for(int c=0; c<4; c++)
            {
                if(HighValue < int.Parse(Points[Index, c].Trim()))
                {
                    HighValue = int.Parse(Points[Index, c].Trim());
                    Value = c + 1;
                }
            }
            return Value;
        }

        static void ConsolePurple()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;            
        }
        static void WriteGreen(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Text);
            ConsolePurple();
        }
    }
}
