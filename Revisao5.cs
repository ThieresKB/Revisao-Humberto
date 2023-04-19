using System.Diagnostics;

namespace Review5
{
    public class Exercise5
    {
        public Exercise5()
        {
            string Target="https://visualgo.net/en/sorting?create=9,5,1,30,17,11,8,23,2,13&quicksort=true";
            
            while (true)
            {         
                StartWhile:
                Response5();
                string response1 = Console.ReadLine().ToUpper();
                if (response1 == "Y")
                {
                    Console.Clear();
                    Console.Write(
                        "Você esta sendo redirecionado para:\n" +
                        Target +
                        "\nDeseja continuar?[ Y/N ]: "
                    );
                    string response2 = Console.ReadLine().ToUpper();
                    if (response2 == "Y")
                    {
                        string edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                        Process.Start(edgePath, Target);
                    }
                    else if (response2 == "N") { break; }
                }
                else if (response1 == "N") { break; }
                else { goto StartWhile; }
            }
        }

        public void Response5()
        {
            Console.Clear();
            Console.WriteLine(
                "  O codigo analiza os elementos de 1 em 1 buscando o maior elemento primairo,\n" +
                "e analizando com o proximo elemento formando uma escadinha do maior para o menor\n" +
                " ate que apareça um proximo numero maior, então ele troca o maior numero com o da\n" +
                "fim da 'escadinha'.\n\n" +
                "O código vai sempre priorizar em jogar o maior numero para o final da escadinha e\n" +
                "continuará em looping até com o array estejá organizado.\n\n" +
                "( Complexidade => o(n²) )\n\n" +
                "Dejesa testar o codigo?[ Y/N ] "
            );
        }
    }
}
