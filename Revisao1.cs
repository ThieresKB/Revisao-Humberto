namespace Review1
{
    public class Exercise1
    {
        //reescrever o seguinte trecho de código para usar nomes de variáveis mais adequados
        public Exercise1()
        {
            Console.Clear();
            int Quantity;
            float Price;
            float Total;
            Console.Write("Quantidade de itens: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.Write("Preço unitário: ");
            Price = float.Parse(Console.ReadLine());
            Total = Quantity * Price;
            Console.WriteLine("Preço total: " + Total);
        }
    }
}
