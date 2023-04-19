using Review1;
using Review2;
using Review3;
using Review4;
using Review5;

int option;

do
{
    try
    {
        Console.WriteLine("Escolha um dos exercicios:");
        start:
        Console.Write("1 a 5 (0 para finalizar): ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 0:
                continue;
            case 1:
                new Exercise1();
                ContinueSwitch();
                break;
            case 2:
                new Exercise2();
                ContinueSwitch();
                break;
            case 3:
                new Exercise3();
                ContinueSwitch();
                break;
            case 4:
                new Exercise4();
                ContinueSwitch();
                break;
            case 5:
                new Exercise5();
                ContinueSwitch();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Apenas numeros de 1 a 5:");
                goto start;
        }
        Console.Clear();
    }
    catch (Exception ex)
    {
        option = 6;
        Console.Clear();
        Console.WriteLine(ex.Message + "\nApenas numeros de 1 a 5:");
    }
}while(option != 0);
Console.WriteLine("Programa finalizado.");


static void ContinueSwitch()
{
    Console.WriteLine("\nPressione enter para continuar...");
    Console.ReadLine();
}