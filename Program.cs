namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            int toplam;
            toplam = 0;
            for (int i = 0; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    toplam = toplam + i;
            System.Console.Write("1000'e kadar 3 yada 5'in katı olan sayıların toplamı: " + toplam);
            System.Console.WriteLine();
        }
    }
}
