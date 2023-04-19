namespace Review2
{
    public class Exercise2
    {
        //identifique esses erros e reescreve o código corretamente

        // 0 - Senti falta do namespace mais isso não é erro
        public Exercise2()
        {
            Console.Clear();
            string[] vetorDeStrings = new string[5];
            int tamanhoMaiorString = 0;
            // 1 - Maior valor vai ser alterado para o menor não o contrario
            int tamanhoMenorString = int.MaxValue;
            string maiorString = "";
            string menorString = "";
            Console.WriteLine("Digite as 5 strings:");

            // 2 - Usar um foreach como um for sendo que eles são diferentes
            for (int i = 0; i < vetorDeStrings.Length - 2; i++) {
                Console.Write($"String {i + 1}: ");
                vetorDeStrings[i] = Console.ReadLine();
                if (vetorDeStrings[i].Length > tamanhoMaiorString)
                {
                    tamanhoMaiorString = vetorDeStrings[i].Length;
                    maiorString = vetorDeStrings[i];
                }
                // 3 - Como é a continuação da condicional deve sse usar um esls if ou else
                // 4 - '?' não é um operador logico
                else if (vetorDeStrings[i].Length < tamanhoMenorString)
                {
                    tamanhoMenorString = vetorDeStrings[i].Length;
                    menorString = vetorDeStrings[i];
                }
                // 4.5 - Falta de ação no caso do tamanho das strings serem iguais
            }
            //5- Falta de ';' e quebra de linha da forma errada
            Console.WriteLine($"Maior string: {maiorString}, com {tamanhoMaiorString} caracteres");
           
            Console.WriteLine($"Menor string: {menorString}, com {tamanhoMenorString} caracteres");
        }
    }
}
